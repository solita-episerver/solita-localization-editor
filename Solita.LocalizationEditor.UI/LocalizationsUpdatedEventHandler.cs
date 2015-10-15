using EPiServer.Events;
using EPiServer.Events.Clients;
using System;
using log4net;
using Solita.LocalizationEditor.UI.Business;

namespace Solita.LocalizationEditor.UI
{
    public class LocalizationsUpdatedEventHandler
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(LocalizationsUpdatedEventHandler));
        public static readonly Guid EventId = new Guid("A7D728F4-BEFF-4931-9FD4-A3C9E69B7BCA");
        public static readonly Guid RaiserId = new Guid("AEA3DCB6-612A-4512-B442-805129DC3EB9");

        public static void RaiseLocalizationsUpdatedEvent()
        {
            Log.Debug("RaiseLocalizationsUpdatedEvent called");

            // no parameters required
            Event.Get(EventId).Raise(RaiserId, null);
        }

        public static void HandleUpdate(object sender, EventNotificationEventArgs e)
        {
            Log.Debug("HandleUpdate called");

            // reload provider to retrieve latest localizations
            LocalizationProviderInitiator.ReInitProvider();
            BlobLocalizationProviderInitiator blobProviderInitiator = new BlobLocalizationProviderInitiator();
            blobProviderInitiator.ReInitProvider();
        }
    }
}
