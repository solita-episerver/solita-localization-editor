using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Configuration;
using System.Xml;
using EPiServer.Framework.Blobs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solita.LocalizationEditor.Definitions;
using Solita.LocalizationEditor.UI;
using Solita.LocalizationEditor.UI.DAL;
using Solita.LocalizationEditor.UI.Helpers;
using Solita.LocalizationEditor.UI.Models;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Solita.LocalizationEditor.Tests
{
    [TestClass]
    public class TestData_load
    {
        [TestMethod]
        public void Loads_TestData()
        {
            var path = ConfigurationManager.AppSettings["LocalizationsFilePath"];
            var currentDir = Directory.GetCurrentDirectory();
            currentDir = currentDir.Substring(0, currentDir.IndexOf("bin"));
            var projectPath = Path.Combine(currentDir, path);

            var xml = new XmlDocument();
            xml.Load(projectPath);

            Assert.IsNotNull(xml.InnerXml);

        }
    }

    [TestClass]
    public class XmlLanguatgeFileHelper_Tests
    {
        XmlLanguageFileHelper langFileHelper = new XmlLanguageFileHelper();

        [TestMethod]
        public void GetKey_Returns_TranslationKeyForXmlElement()
        {
            XElement xmlTree = new XElement("common",
                new XElement("languagemenufi", "Finnish")
            );
            var langFiElement = xmlTree.Element("languagemenufi");
            Assert.AreEqual("languagemenufi", langFiElement.Name);
            var actual = XmlLanguageFileHelper.GetKey(langFiElement);
            var expected = "/common/languagemenufi";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetKeys_FromTranslationsXml()
        {
            var xDoc = XDocument.Parse(TestHelpers.GetTestXml());
            var expected = new string[]
            {
                "/common/languagemenufi",
                "/common/languagemenusv"
            };
            var actual = langFileHelper.GetTranslationKeys(xDoc);

            CollectionAssert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void XPath_Select_Test()
        {
            var xDoc = XDocument.Parse(TestHelpers.GetTestXml());
            var langEn = xDoc.Element("languages").Elements("language").FirstOrDefault();

            Assert.AreEqual("en", langEn.Attribute("id").Value);
            var selector = "./common/languagemenufi";
            var actual = langEn.XPathSelectElement(selector);

            Assert.AreEqual("languagemenufi", actual.Name);

        }

        [TestMethod]
        public void TransformXmlToTranslationsList_TwoLanguages_Returns_ListOfLocalizations()
        {
            var actual = langFileHelper.TransformXmlToTranslationsList(XDocument.Parse(TestHelpers.GetTestXml()));
            var expected = new List<LocalizationResult>()
            {
                new LocalizationResult()
                {
                    Key = "/common/languagemenufi",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation() {Language = "en", Value = "Finnish"},
                        new LocalizationResult.Translation() {Language = "fi", Value = "Suomi"}
                    }
                },
                new LocalizationResult()
                {
                    Key = "/common/languagemenusv",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation() {Language = "en", Value = "Swedish"},
                        new LocalizationResult.Translation() {Language = "fi", Value = "Ruotsi"}
                    }
                }
            };

            CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expected[0].Translations.ToList(), actual[0].Translations.ToList());
            CollectionAssert.AreEqual(expected[1].Translations.ToList(), actual[1].Translations.ToList());
        }

        [TestMethod]
        public void TransformXmlToTranslationsList_Threelanguages_Returns_ListOfLocalizations()
        {
            var xml =
           @"<languages>" +
              "<language id=\"en\" name=\"English\">" +
                "<common>" +
                    "<sitename>My company</sitename>" +
                    "<languagemenufi>Finnish</languagemenufi>" +
                    "<languagemenusv>Swedish</languagemenusv>" +
                "</common>" +
              "</language>" +
              "<language id=\"fi\" name=\"suomi\">" +
                "<common>" +
                  "<sitename>Mun firma</sitename>" +
                  "<languagemenufi>Suomi</languagemenufi>" +
                  "<languagemenusv>Ruotsi</languagemenusv>" +
                "</common>" +
             "</language>" +
             "<language id=\"sv\" name=\"svenska\">" +
                "<common>" +
                   "<sitename>Min firm</sitename>" +
                   "<languagemenufi>Finska</languagemenufi>" +
                   "<languagemenusv>Svenska</languagemenusv>" +
                "</common>" +
             "</language>" +
           "</languages>";

            var actual = langFileHelper.TransformXmlToTranslationsList(XDocument.Parse(xml));
            var expected = new List<LocalizationResult>()
            {
                new LocalizationResult()
                {
                    Key = "/common/sitename",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation("en", "My company"),
                        new LocalizationResult.Translation("fi", "Mun firma"),
                        new LocalizationResult.Translation("sv", "Min firm")
                    }
                },
                new LocalizationResult()
                {
                    Key = "/common/languagemenufi",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation("en", "Finnish"),
                        new LocalizationResult.Translation("fi", "Suomi"),
                        new LocalizationResult.Translation("sv", "Finska")
                    }
                },
                new LocalizationResult()
                {
                    Key = "/common/languagemenusv",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation("en", "Swedish"),
                        new LocalizationResult.Translation("fi", "Ruotsi"),
                        new LocalizationResult.Translation("sv", "Svenska")
                    }
                }
            };

            CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expected[0].Translations.ToList(), actual[0].Translations.ToList());
            CollectionAssert.AreEqual(expected[1].Translations.ToList(), actual[1].Translations.ToList());
            CollectionAssert.AreEqual(expected[2].Translations.ToList(), actual[2].Translations.ToList());
        }
    }

    [TestClass]
    public class LocalizationPersister_Tests
    {
        static FileAccessStrategy mockStrategy = new MockFileAccessStrategy(TestHelpers.GetLocalizationsFilePath());
        TestLocalizationPersister _persister = new TestLocalizationPersister(mockStrategy);

        [TestMethod]
        public void GetLocalizations_Returns_Translations()
        {
            var actual = _persister.GetLocalizations();

            Assert.IsTrue(actual.Count > 0);
        }

        [TestMethod]
        public void GetLocalizations_Returns_Expected_Translation()
        {
            var translations = new Dictionary<string, string>();
            translations.Add("fi", "myCompany");
            translations.Add("en", "myCompany");
            translations.Add("sv", "myCompany");
            translations.Add("de", "myCompany");
            var expected = new CategoryList.Translation()
            {
                DefaultValue = "myCompany",
                Description = "myCompany",
                Key = "/common/sitename",
                Translations = translations
            };
            var actual = _persister.GetLocalizations().First().Translations.First();

            Assert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expected.Translations.ToList(), actual.Translations.ToList());
        }

        [TestMethod]
        public void GetLocalizations_Returns_ExpectedAmounfOfCategories()
        {
            var actual = _persister.GetLocalizations().Select(t => t.Name);
            var expectedCategoryCount = 2;

            Assert.AreEqual(expectedCategoryCount, actual.Count());
        }

        [TestMethod]
        public void GetEnabledLanguages_Returns_EnabledLanguages()
        {
            var expected = new List<string> { "fi", "en", "sv", "de" };
            var actual = _persister.GetEnabledLanguages().ToList();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindExistingTranslation_Returns_TranslationsFromXmlFile()
        {
            var xml = _persister.LoadXml();
            var lang = "fi";
            var key = "/common/sitename";

            var expected = "myCompany";
            var actual = _persister.FindExistingTranslation(xml, lang, key);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SaveLocalizations_Saves_LocalizationsToXml()
        {
            var translations = new Dictionary<string, string>();
            translations.Add("en", "Share");
            translations.Add("fi", "Jaa");

            var model = new LocalizationEditorViewModel()
            {
                Languages = new List<string>() { "fi", "en" },
                Categories = new CategoryList()
                {
                    new CategoryList.Category()
                    {
                        Name = "Common",
                        Translations = new List<CategoryList.Translation>()
                        {
                            new CategoryList.Translation() {Key = "/common/sitename", DefaultValue = "Share", Translations = translations}
                        }
                    }
                }
            };
            var actual = _persister.SaveLocalizations(model);

            var fiResult = actual.SelectSingleNode("/languages/language[@id='fi']/common/sitename");
            var enResult = actual.SelectSingleNode("/languages/language[@id='en']/common/sitename");

            Assert.AreEqual("Jaa", fiResult.InnerText);
            Assert.AreEqual("Share", enResult.InnerText);

        }

        [TestMethod]
        public void GetTranslations_Returns_CorrectNumberOfTranslations()
        {
            var existingLocalizationsKeys = new List<LocalizationDefinition>()
            {
                new LocalizationDefinition("/common/sitename", null, null, "MySite"),
                new LocalizationDefinition("/common/languagemenufi", null, null, "finnish")
            };
            var persister = new TestLocalizationPersister(new MockFileAccessStrategy(TestHelpers.GetLocalizationsFilePath()), existingLocalizationsKeys);
            var actual = persister.GetTranslationsForVersion(null);

            Assert.AreEqual(existingLocalizationsKeys.Count, actual.Count());
        }

        [TestMethod]
        public void GetLocalizations_Returns_ExistingLocalizationsONLY()
        {
            var existingLocalizationsKeys = new List<LocalizationDefinition>()
            {
                new LocalizationDefinition("/common/sitename", null, null, "MySite"),
                new LocalizationDefinition("/common/languagemenufi", null, null, "finnish")
            };
            var persister = new TestLocalizationPersister(new MockFileAccessStrategy(TestHelpers.GetLocalizationsFilePath()), existingLocalizationsKeys);
            var actual = persister.GetTranslationsForVersion(null).ToList();

            var expected = new List<LocalizationResult>()
            {
                new LocalizationResult()
                {
                    Key = "common/sitename",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation() {Language = "fi", Value = "myCompany"},
                        new LocalizationResult.Translation() {Language = "en", Value = "myCompany"},
                        new LocalizationResult.Translation() {Language = "sv", Value = "myCompany"},
                        new LocalizationResult.Translation() {Language = "de", Value = "myCompany"}
                    }
                },
                new LocalizationResult()
                {
                    Key = "common/languagemenufi",
                    Translations = new List<LocalizationResult.Translation>()
                    {
                        new LocalizationResult.Translation() {Language = "fi", Value = "Suomi"},
                        new LocalizationResult.Translation() {Language = "en", Value = "Finnish"},
                        new LocalizationResult.Translation() {Language = "sv", Value = "Suomi"},
                        new LocalizationResult.Translation() {Language = "de", Value = "Suomi"}
                    }
                }
            };

            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0].Translations.FirstOrDefault(), actual[0].Translations.FirstOrDefault());
        }

        

        [TestMethod]
        public void GetTypeName_Returns_TypeName()
        {
            var actual = typeof(LocalizationFile).Name;

            Assert.AreEqual("LocalizationFile", actual);
        }
    }

    [TestClass]
    public class PathHelper_Tests
    {
        [TestMethod]
        public void GetPathRelativeToCurrentRoot_Returns_Path()
        {
            var path = @"\app_data\someFolder\someFile.txt";
            var actual = PathHelper.GetPathRealtiveToCurrentDirectory(path);
            string expected = $"Solita.LocalizationEditor\\Solita.LocalizationEditor.Tests\\{path}";

            StringAssert.Contains(actual, path);
        }
    }

    [TestClass]
    public class TestHelpers_Tests
    {
        [TestMethod]
        public void GetLocalizationsFilePath_Returns_LocalizationsFilePath()
        {
            var actual = TestHelpers.GetLocalizationsFilePath();
            var expectedPath = "Solita.LocalizationEditor.Tests\\TestData\\Localizations.xml";

            StringAssert.Contains(actual, expectedPath);
        }
    }


    [TestClass]
    public class Episerver_Blob_Testing
    {
        [TestMethod]
        public void GetContainerIdentifier_Returns_Identifier()
        {
            var container = Blob.GetContainerIdentifier(Guid.NewGuid());

            Assert.IsNotNull(container);
        }

        BlobFactory GetBlobFactory()
        {
            var fileBlobProvider = (FileBlobProvider)ProvidersHelper.InstantiateProvider(new ProviderSettings(Blob.DefaultProvider, typeof(FileBlobProvider).AssemblyQualifiedName), typeof(FileBlobProvider));

            return new BlobFactory(Blob.DefaultProvider, new BlobProvider[] { fileBlobProvider });
        }
    }
    public static class TestHelpers
    {
        private const string LocalizationFileRelativeLocation = "TestData\\Localizations.xml";

        public static string GetLocalizationsFilePath()
        {
            var currentDir = Directory.GetCurrentDirectory();
            var testProjectLocation = currentDir.Substring(0, currentDir.IndexOf("bin"));

            return Path.Combine(testProjectLocation, LocalizationFileRelativeLocation);
        }

        public static string GetTestXml()
        {
            return 
            @"<languages>" +
              "<language id=\"en\" name=\"English\">" +
                "<common>" +
                  "<languagemenufi>Finnish</languagemenufi>" +
                  "<languagemenusv>Swedish</languagemenusv>" +
                "</common>" +
              "</language>" +
              "<language id=\"fi\" name=\"suomi\">" +
                "<common>" +
                  "<languagemenufi>Suomi</languagemenufi>" +
                  "<languagemenusv>Ruotsi</languagemenusv>" +
                "</common>" +
             "</language>" +
           "</languages>";
        }
    }

    public class TestLocalizationPersister : LocalizationPersister
    {
        public IList<LocalizationDefinition> Definitions { get; private set; }

        public TestLocalizationPersister(FileAccessStrategy strategy) : base(strategy)
        {

        }

        public TestLocalizationPersister(FileAccessStrategy strategy, IList<LocalizationDefinition> definitions) : base(strategy)
        {
            Definitions = definitions;
        }
        public override IList<string> GetEnabledLanguages()
        {
            return new List<string>()
            {
                "fi",
                "en",
                "sv",
                "de"
            };
        }

        public override XmlDocument LoadXmlVersion(string version)
        {
            return base.LoadXml();
        }

        public override IList<LocalizationDefinition> GetLocalizationDefinitions()
        {
            if (Definitions == null)
            {
                return base.GetLocalizationDefinitions();
            }

            return Definitions;
        }
    }

    public class MockFileAccessStrategy : XmlFileAccessStrategy
    {
        public MockFileAccessStrategy(string filePath) : base(filePath)
        {

        }
        public override void SaveXml(XmlDocument xml)
        {

        }
    }
}
