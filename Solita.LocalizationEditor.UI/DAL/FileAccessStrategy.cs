using System.Collections.Generic;
using System.Xml;
using EPiServer.Framework.Blobs;
using Solita.LocalizationEditor.UI.Models;

namespace Solita.LocalizationEditor.UI.DAL
{
    public abstract class FileAccessStrategy
    {
        public string FilePath { get; }        

        public abstract IList<XmlVersionInfo> GetTranslationFileVersions();

        public abstract XmlDocument LoadXml();

        public abstract XmlDocument LoadVersion(string version);

        public abstract void SaveXml(XmlDocument xml);
    }
}