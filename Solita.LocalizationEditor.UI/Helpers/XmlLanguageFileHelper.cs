using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Xml;
using Solita.LocalizationEditor.UI.Common;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Solita.LocalizationEditor.UI.Helpers
{
    public class XmlLanguageFileHelper
    {
        public const string LanguagesRootXPath = "/languages";
        private const string LanguageXPath = LanguagesRootXPath + "/language";
        private const string TranslationXPath = LanguageXPath + "[@id='{0}']{1}";
        private readonly XmlDocument _xmlDoc;

        public XmlDocument XmlDoc
        {
            get
            {
                if(_xmlDoc == null) { throw new InvalidOperationException("member _xmlDoc is null.");}
                return _xmlDoc;
            } 
        }

        public XmlLanguageFileHelper()
        {
            _xmlDoc = new XmlDocument();
        }

        public static string FindExistingTranslation(XmlNode xml, string lang, string key)
        {
            var xpath = string.Format(TranslationXPath, lang, key);
            var node = xml.SelectSingleNode(xpath);

            return node == null ? null : node.InnerText;
        }

        public void EnsureLanguagesXPath()
        {
            XmlDoc.CreateXPath(LanguagesRootXPath);
        }

        public void SetTranslation(string key, string lang, string value)
        {
            var xPath = string.Format(TranslationXPath, lang, key);
            var node = XmlDoc.CreateXPath(xPath);
            node.InnerText = value;
        }

        public void SetTranslation(XmlDocument xmlDoc, string key, string lang, string value)
        {
            var xPath = string.Format(TranslationXPath, lang, key);
            var node = xmlDoc.CreateXPath(xPath);
            node.InnerText = value;
        }

        public void AddLanguageNames()
        {
            var nodes = XmlDoc.SelectNodes(LanguageXPath);
            if (nodes == null) { return; }

            foreach (XmlNode node in nodes)
            {
                var id = node.Attributes["id"].InnerText;
                var attribute = XmlDoc.CreateAttribute("name");
                attribute.InnerText = CultureInfo.GetCultureInfo(id).NativeName;
                node.Attributes.Append(attribute);
            }
        }

        public void AddLanguageNames(XmlDocument xmlDoc)
        {
            var nodes = xmlDoc.SelectNodes(LanguageXPath);
            if (nodes == null) { return; }

            foreach (XmlNode node in nodes)
            {
                var id = node.Attributes["id"].InnerText;
                var attribute = xmlDoc.CreateAttribute("name");
                attribute.InnerText = CultureInfo.GetCultureInfo(id).NativeName;
                node.Attributes.Append(attribute);
            }
        }

        public string[] GetTranslationKeys(XDocument xDoc)
        {
            var langElements = xDoc.Elements("languages").Elements("language");
            var keys =
                (langElements.SelectMany(lang => lang.Elements(), (lang, category) => new { lang, category })
                    .SelectMany(@t => @t.category.Elements(),
                        (@t, translation) => $"/{@t.category.Name}/{translation.Name.ToString()}")
                    ).Distinct().ToArray();

            return keys;
        }

        public List<LocalizationResult> TransformXmlToTranslationsList(XDocument xDoc)
        {
            var keys = GetTranslationKeys(xDoc);
            var localizations = new List<LocalizationResult>();
            var languages = xDoc.Element("languages").Elements("language");
            foreach (var lang in languages)
            {
                var id = lang.Attribute("id") != null ? lang.Attribute("id").Value : string.Empty;
                if (string.IsNullOrEmpty(id)) { continue; }
                foreach (var key in keys)
                {
                    var selector = $".{key}";
                    var translationValue = lang.XPathSelectElement(selector);
                    if (translationValue == null) { continue; }
                    var existingLocalizationResult = localizations.SingleOrDefault(loc => loc.Key == key);
                    var translation = new LocalizationResult.Translation(id, translationValue.Value);
                    if (existingLocalizationResult != null)
                    {
                        existingLocalizationResult.Translations.Add(translation);
                    }
                    else
                    {
                        var localizationResult = new LocalizationResult()
                        {
                            Key = key,
                            Translations = new List<LocalizationResult.Translation>() { translation }
                        };
                        localizations.Add(localizationResult);
                    }
                }
            }

            return localizations;
        }

        public static string GetKey(XElement translation)
        {
            var category = translation.Parent.Name;

            return $"/{category}/{translation.Name}";
        }
    }
}