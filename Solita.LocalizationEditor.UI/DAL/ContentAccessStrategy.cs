using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Solita.LocalizationEditor.UI.Models;
using EPiServer.ServiceLocation;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer;
using EPiServer.Framework.Blobs;
using System.IO;
using EPiServer.DataAccess;
using Solita.LocalizationEditor.UI.Common;

namespace Solita.LocalizationEditor.UI.DAL
{
    public class ContentAccessStrategy : FileAccessStrategy
    {
        private readonly IContentRepository _contentRepository;
        private readonly ContentReference _storageRoot;
        private const string TranslationFile = "data.localizationdata";
        private const string TranslationFileExtension = ".localizationdata";

        public ContentAccessStrategy()
        {
            _contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            _storageRoot = Settings.AutoPopulated.StorageRoot;
        }

        public override IList<XmlVersionInfo> GetTranslationFileVersions()
        {
            var versions = new List<XmlVersionInfo>();

            var versionRepository =
                ServiceLocator.Current.GetInstance<IContentVersionRepository>();
            var localization = _contentRepository
                .GetChildren<LocalizationXml>(_storageRoot)
                ?.FirstOrDefault();

            if (localization == null)
            {
                return versions;
            }

            versions.AddRange(
                versionRepository
                    .List(localization.ContentLink)
                    .Select(x =>
                        new XmlVersionInfo(
                            x.ContentLink.WorkID.ToString(),
                            x.ContentLink.WorkID.ToString(),
                            x.Saved,
                            x.SavedBy)));

            return versions;
        }

        public override XmlDocument LoadVersion(string version)
        {
            var localization = _contentRepository
                .GetChildren<LocalizationXml>(_storageRoot)
                ?.FirstOrDefault();

            if (localization == null)
            {
                return new XmlDocument();
            }
            if (version != null)
            {
                localization = _contentRepository
                    .Get<LocalizationXml>(
                        new ContentReference(
                            localization.ContentLink.ID,
                            int.Parse(version)));
            }
            using (var stream = localization.BinaryData.OpenRead())
            {
                var document = new XmlDocument();
                document.Load(stream);

                return document;
            }
        }

        public override XmlDocument LoadXml()
        {
            return LoadVersion(null);
        }

        public override void SaveXml(XmlDocument xml)
        {
            var localization = _contentRepository
                .GetChildren<LocalizationXml>(_storageRoot)
                ?.FirstOrDefault();

            if (localization != null)
            {
                localization = (LocalizationXml)localization.CreateWritableClone();
            }
            else
            {
                localization = _contentRepository
                    .GetDefault<LocalizationXml>(_storageRoot);
                localization.Name = TranslationFile;
            }

            var blob = ServiceLocator.Current.GetInstance<BlobFactory>()
                .CreateBlob(
                    Blob.GetContainerIdentifier(localization.ContentGuid),
                    TranslationFileExtension);

            using (var s = blob.OpenWrite())
            {
                var w = new StreamWriter(s);
                xml.Save(s);
                w.Flush();
            }

            localization.BinaryData = blob;
            _contentRepository.Save(localization, SaveAction.Publish);
        }

        
    }
}