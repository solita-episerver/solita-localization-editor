using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using Solita.LocalizationEditor.UI.Models;

namespace Solita.LocalizationEditor.UI.DAL
{
    public class XmlFileAccessStrategy : FileAccessStrategy
    {
        private readonly string _localizationsFilePath;

        public XmlFileAccessStrategy(string filepath)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                throw new ArgumentNullException("localizationFilePath");
            }
            if (!File.Exists(filepath))
            {
                throw new InvalidOperationException($"file does not exist in path: '{filepath}'");
            }
            _localizationsFilePath = filepath;
        }

        public override IList<XmlVersionInfo> GetTranslationFileVersions()
        {
            return new List<XmlVersionInfo>();
        }

        public override XmlDocument LoadXml()
        {
            if (!File.Exists(_localizationsFilePath)) { return new XmlDocument();}
            XmlDocument doc = new XmlDocument();
            using (var stream = File.OpenRead(_localizationsFilePath))
            {
                doc.Load(stream);
                stream.Flush();
            }
            return doc;
        }

        public override XmlDocument LoadVersion(string version)
        {
            throw new NotImplementedException();
        }

        public override void SaveXml(XmlDocument xml)
        {
            using (var stream = File.OpenRead(_localizationsFilePath))
            {
                xml.Save(stream);
                stream.Flush();
            }
        }
    }
}