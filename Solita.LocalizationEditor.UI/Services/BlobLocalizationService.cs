using EPiServer.Framework.Localization.XmlResources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using EPiServer.Framework.Localization;
using EPiServer.ServiceLocation;
using EPiServer;
using EPiServer.DataAbstraction;
using EPiServer.Core;
using EPiServer.Web;
using Solita.LocalizationEditor.UI.DAL;
using EPiServer.Logging.Compatibility;

namespace Solita.LocalizationEditor.UI.Services
{
    public class BlobLocalizationService : XmlLocalizationProvider
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(BlobLocalizationService));
        internal void LoadTranslations()
        {
            var blobFileAccessStrategy = new BlobFileAccessStrategy();
            var media = blobFileAccessStrategy.GetLocalizationFile();
            var binaryData = media.BinaryData;

            if (binaryData != null)
            {
                try
                {
                    using (var stream = binaryData.OpenRead())
                    {
                        this.Load(stream);
                    }
                }
                catch (DirectoryNotFoundException ex)
                {
                    Log.Error(ex.Message);
                }
            }
        }
    }
}