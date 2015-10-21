using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;
using EPiServer.Web.Hosting;
using Solita.LocalizationEditor.UI.Common;
using Solita.LocalizationEditor.UI.Models;

namespace Solita.LocalizationEditor.UI.DAL
{
    //public class VppFileAccessStrategy : FileAccessStrategy
    //{
    //    private const string TranslationFile = "Localizations.xml";
    //    public string TranslationFilePath { get; }

    //    public VppFileAccessStrategy()
    //    {
    //        var folderPath = VirtualPathUtility.AppendTrailingSlash(Settings.AutoPopulated.LangFolderVirtualPath);
    //        TranslationFilePath = VirtualPathUtility.Combine(folderPath, TranslationFile);
    //    }

    //    public override IList<XmlVersionInfo> GetTranslationFileVersions()
    //    {
    //        var versions = new List<XmlVersionInfo>();
    //        if (HostingEnvironment.VirtualPathProvider.FileExists(TranslationFilePath))
    //        {
    //            var file = (UnifiedFile)HostingEnvironment.VirtualPathProvider.GetFile(TranslationFilePath);
    //            var versioningFile = file as VersioningFile;
    //            if (versioningFile != null)
    //            {
    //                versions.AddRange(
    //                    versioningFile.GetVersions()
    //                        .Select(v => new XmlVersionInfo(v.Id.ToString(), v.Name, v.Created, v.CreatedBy)));
    //            }
    //        }

    //        return versions;
    //    }

    //    public override XmlDocument LoadXml(string version)
    //    {
    //        if (!HostingEnvironment.VirtualPathProvider.FileExists(TranslationFilePath))
    //        {
    //            return new XmlDocument();
    //        }
    //        var file = (UnifiedFile)HostingEnvironment.VirtualPathProvider.GetFile(TranslationFilePath);
    //        if (version != null)
    //        {
    //            // Will throw an exception if the VPP folder doesn't support versioning, but that's reasonable here.
    //            file = ((VersioningFile)file).GetVersion(version);
    //        }
    //        using (var stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.Read))
    //        {
    //            var document = new XmlDocument();
    //            document.Load(stream);
    //            return document;
    //        }
    //    }

    //    public override void SaveXml(XmlDocument xml)
    //    {
    //        var path = TranslationFilePath.Substring(0, TranslationFilePath.LastIndexOf("/", StringComparison.Ordinal) + 1);
    //        var unifiedDirectory = (UnifiedDirectory)HostingEnvironment.VirtualPathProvider.GetDirectory(path);

    //        var file = HostingEnvironment.VirtualPathProvider.FileExists(TranslationFilePath)
    //            ? (UnifiedFile)HostingEnvironment.VirtualPathProvider.GetFile(TranslationFilePath)
    //            : unifiedDirectory.CreateFile(TranslationFilePath);

    //        using (var stream = file.Open(FileMode.OpenOrCreate, FileAccess.Write))
    //        {
    //            xml.Save(stream);
    //        }
    //    }
    //}
}