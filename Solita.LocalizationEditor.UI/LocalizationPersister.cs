using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Xml;
using EPiServer.DataAbstraction;
using EPiServer.Events.Clients;
using EPiServer.ServiceLocation;
using EPiServer.Web.Hosting;
using Solita.LocalizationEditor.Definitions;
using Solita.LocalizationEditor.UI.Common;
using Solita.LocalizationEditor.UI.DAL;
using Solita.LocalizationEditor.UI.Helpers;
using Solita.LocalizationEditor.UI.Models;
using System.Xml.Linq;
using System.Xml.XPath;
using Castle.Core.Internal;

namespace Solita.LocalizationEditor.UI
{
    public class LocalizationPersister
    {
        private const string TranslationFile = "Localizations.xml";
        public FileAccessStrategy AccessStrategy { get; }

        public LocalizationPersister(FileAccessStrategy accessStrategy)
        {
            AccessStrategy = accessStrategy != null ? accessStrategy : new BlobFileAccessStrategy();
        }

        public virtual IList<string> GetEnabledLanguages()
        {
            return ServiceLocator.Current.GetInstance<ILanguageBranchRepository>()
                              .ListEnabled()
                              .Select(branch => branch.LanguageID)
                              .ToList();
        }

        public CategoryList GetLocalizations()
        {
            var xml = LoadXml();
            var languages = GetEnabledLanguages();
            var categories = new CategoryList();

            foreach (var localization in GetLocalizationDefinitions())
            {
                var translation = categories.AddTranslation(
                    localization.Key, localization.Description, localization.Category, localization.DefaultValue);

                foreach (var lang in languages)
                {
                    var value = XmlLanguageFileHelper.FindExistingTranslation(xml, lang, translation.Key);
                    translation.AddTranslation(lang, value ?? string.Empty);
                }
            }

            return categories;
        }

        private IEnumerable<LocalizationResult.Translation> GetTranslationsForKey(IEnumerable<string> languages, string translationValue)
        {
            return languages.Select(l => new LocalizationResult.Translation()
            {
                Language = l,
                Value = translationValue
            });
        }

        public IEnumerable<LocalizationResult> GetTranslationsForVersion(string version)
        {
            var xml = LoadXmlVersion(version);
            var languages = GetEnabledLanguages();
            var definitions = GetLocalizationDefinitions();

            var matchingDefinitions =
                    from definition in definitions
                    let translations = FindExistingTranslations(xml, languages, definition.Key)
                    where translations.Count() > 0
                    select new LocalizationResult
                    {
                        Key = definition.Key,
                        Translations = translations.ToList()

                    };

            return matchingDefinitions;
        }

        public virtual IList<LocalizationDefinition> GetLocalizationDefinitions()
        {
            return LocalizationHelpers.GetLocalizationDefinitions();
        }

        public IList<XmlVersionInfo> GetTranslationFileVersions()
        {
            return AccessStrategy.GetTranslationFileVersions();
        }

        public virtual XmlDocument LoadXml()
        {
            return AccessStrategy.LoadXml();
        }

        public virtual XmlDocument LoadXmlVersion(string version)
        {
            return AccessStrategy.LoadVersion(version);
        }

        public string FindExistingTranslation(XmlNode xml, string lang, string key)
        {
            return XmlLanguageFileHelper.FindExistingTranslation(xml, lang, key);
        }

        public IEnumerable<LocalizationResult.Translation> FindExistingTranslations(XmlNode node, IEnumerable<string> languages, string key)
        {
            return languages.Select(lang => new LocalizationResult.Translation()
            {
                Language = lang,
                Value = FindExistingTranslation(node, lang, key)
            });
        }

        public XmlDocument SaveLocalizations(LocalizationEditorViewModel model)
        {
            XmlLanguageFileHelper languageXmlFileHelper = new XmlLanguageFileHelper();
            languageXmlFileHelper.EnsureLanguagesXPath();

            foreach (var translation in model.Categories.SelectMany(category => category.Translations))
            {
                foreach (var dictionary in translation.Translations)
                {
                    if (!string.IsNullOrWhiteSpace(dictionary.Value))
                    {
                        languageXmlFileHelper.SetTranslation(translation.Key, dictionary.Key, dictionary.Value);
                    }
                }
            }

            languageXmlFileHelper.AddLanguageNames();
            AccessStrategy.SaveXml(languageXmlFileHelper.XmlDoc);
            LocalizationsUpdatedEventHandler.RaiseLocalizationsUpdatedEvent();

            return languageXmlFileHelper.XmlDoc;
        }
    }

    public class LocalizationResult
    {
        public string Key { get; set; }

        public List<Translation> Translations { get; set; }

        public override bool Equals(object obj)
        {
            LocalizationResult result = obj as LocalizationResult;
            if (result == null || result.Key != Key)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return (Key ?? string.Empty).GetHashCode();
        }

        public class Translation
        {
            public Translation() { }
            public Translation(string language, string value)
            {
                Language = language;
                Value = value;
            }
            public string Language { get; set; }
            public string Value { get; set; }

            public override bool Equals(object obj)
            {
                Translation trans = obj as Translation;
                if (trans == null || trans.Language != Language || trans.Value != Value)
                {
                    return false;
                }

                return true;
            }

            public override int GetHashCode()
            {
                return (Language ?? string.Empty).GetHashCode() + (Value ?? string.Empty).GetHashCode();
            }
        }
    }
}