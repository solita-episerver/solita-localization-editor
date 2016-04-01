using System.Collections.Specialized;
using System.Linq;
using EPiServer;
using EPiServer.Framework.Localization.XmlResources;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using Solita.LocalizationEditor.UI.Common;
using Solita.LocalizationEditor.UI.Models;

namespace Solita.LocalizationEditor.UI
{
    public class LocalizationContentProvider : XmlLocalizationProvider
    {
        public void Reset()
        {
            LoadFromContent();
        }

        public override void Initialize(string name, NameValueCollection config)
        {
            LoadFromContent();
            base.Initialize(name, config);
        }

        private void LoadFromContent()
        {
            var localization = ServiceLocator.Current
                ?.GetInstance<IContentRepository>()
                ?.GetChildren<LocalizationXml>(Settings.AutoPopulated.StorageRoot)
                ?.FirstOrDefault();

            if (localization == null)
            {
                return;
            }

            using (var stream = localization.BinaryData.OpenRead())
            {
                Load(stream);
            }
        }
    }

}