using System.Web.UI.WebControls;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Web;
using EPiServer.Web.WebControls;

namespace Solita.LocalizationEditor.UI.Common
{
    [GuiPlugIn]
    public class Settings
    {
        public static Settings AutoPopulated
        {
            get
            {
                var settings = new Settings();
                PlugInSettings.AutoPopulate(settings);
                if (string.IsNullOrWhiteSpace(settings.LangFolderVirtualPath))
                {
                    settings.LangFolderVirtualPath = "~/i18n/";
                }
                return settings;
            }
        }

        [PlugInProperty(Description = "Virtual path to lang folder (default: ~/i18n/)",
            AdminControl = typeof (TextBox),
            AdminControlValue = "Text")]
        public string LangFolderVirtualPath { get; set; }

        [PlugInProperty(Description = "Disable powertools mode",
           AdminControl = typeof(CheckBox),
           AdminControlValue = "Checked")]
        public bool DisablePowertoolsMode { get; set; }

        [PlugInProperty(Description = "Alternative storage root (default: global assests)",
           AdminControl = typeof(InputPageReference),
           AdminControlValue = "PageLink")]
        public ContentReference AlternativeStorageRoot { get; set; }

        public ContentReference StorageRoot
        {
            get
            {
                if (!ContentReference.IsNullOrEmpty(AlternativeStorageRoot))
                {
                    return AlternativeStorageRoot;
                }
                return SiteDefinition.Current.GlobalAssetsRoot;
            }
        }
    }
}