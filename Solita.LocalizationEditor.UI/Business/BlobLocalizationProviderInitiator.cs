using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Framework.Localization;
using EPiServer.Events.Clients;
using System.Collections.Specialized;
using Solita.LocalizationEditor.UI.Services;
using EPiServer.Logging.Compatibility;
using EPiServer;
using EPiServer.ServiceLocation;
using EPiServer.Events;

namespace Solita.LocalizationEditor.UI.Business
{

    [InitializableModule]
    //[ModuleDependency(typeof(FrameworkInitialization))]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))] 
    public class BlobLocalizationProviderInitiator : IInitializableModule
    {
        private const string ProviderName = "Translations";
        private static readonly ILog Log = LogManager.GetLogger(typeof(BlobLocalizationProviderInitiator));
        private static bool initialized;
        private ProviderBasedLocalizationService localizationService;

        private ProviderBasedLocalizationService LocalizationService
        {
            get
            {
                return this.localizationService ?? (this.localizationService = GetLocalizationService());
            }
        }

        /// <summary>
        ///     Initializes this instance.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <remarks>
        ///     Gets called as part of the EPiServer Framework initialization sequence. Note that it will be called
        ///     only once per AppDomain, unless the method throws an exception. If an exception is thrown, the initialization
        ///     method will be called repeatedly for each request reaching the site until the method succeeds.
        /// </remarks>
        public void Initialize(InitializationEngine context)
        {
            // If there is no context, we can't do anything.
            if (context == null)
            {
                return;
            }

            // If already initialized, no need to do it again.
            if (initialized)
            {
                return;
            }

            Log.Info("[LocalizationResult] Initializing translation provider.");
            // Initialize the provider after the initialization is complete, else the StartPage cannot be found.
            context.InitComplete += this.InitComplete;
            initialized = true;

            Log.Info("[LocalizationResult] Translation provider initialized.");
        }

        public void Preload(string[] parameters)
        {
        }

        /// <summary>
        ///     Resets the module into an uninitialized state.
        /// </summary>
        /// <param name="context">
        ///     The context.
        /// </param>
        /// <remarks>
        ///     <para>
        ///         This method is usually not called when running under a web application since the web app may be shut down very
        ///         abruptly, but your module should still implement it properly since it will make integration and unit testing
        ///         much simpler.
        ///     </para>
        ///     <para>
        ///         Any work done by
        ///         <see
        ///             cref="M:EPiServer.Framework.IInitializableModule.Initialize(EPiServer.Framework.Initialization.InitializationEngine)" />
        ///         as well as any code executing on
        ///         <see cref="E:EPiServer.Framework.Initialization.InitializationEngine.InitComplete" />
        ///         should be reversed.
        ///     </para>
        /// </remarks>
        public void Uninitialize(InitializationEngine context)
        {
            // If there is no context, we can't do anything.
            if (context == null)
            {
                return;
            }

            // If already uninitialized, no need to do it again.
            if (!initialized)
            {
                return;
            }

            Log.Info("[LocalizationResult] Uninitializing translation provider.");

            var translationProvider = this.GetTranslationProvider();
            initialized = this.UnLoadProvider(translationProvider);
            Log.Info("[LocalizationResult] Translation provider uninitialized.");
        }

        internal void InitComplete(object sender, EventArgs e)
        {
            initialized = this.LoadProvider();
        }

        private static ProviderBasedLocalizationService GetLocalizationService()
        {
            ProviderBasedLocalizationService service;

            try
            {
                // Casts the current LocalizationService to a ProviderBasedLocalizationService to get access to the current list of providers.
                service = ServiceLocator.Current.GetInstance<LocalizationService>() as ProviderBasedLocalizationService;
            }
            catch (ActivationException)
            {
                return null;
            }

            return service;
        }

        private static void LoadTranslations(BlobLocalizationService localizationProvider)
        {
            if (localizationProvider != null)
            {
                localizationProvider.LoadTranslations();
                return;
            }

            Log.Info("[LocalizationResult] Translation provider not found, no translations loaded.");
        }

        private BlobLocalizationService GetTranslationProvider()
        {
            if (this.LocalizationService == null)
            {
                return null;
            }

            // Gets any provider that has the same name as the one initialized.
            LocalizationProvider localizationProvider =
                this.LocalizationService.Providers.FirstOrDefault(
                    p => p.Name.Equals(ProviderName, StringComparison.Ordinal));

            return localizationProvider as BlobLocalizationService;
        }

        /// <summary>
        ///     Loads the provider.
        /// </summary>
        /// <returns>
        ///     [true] if the provider has been loaded.
        /// </returns>
        private bool LoadProvider()
        {
            if (this.LocalizationService == null)
            {
                return false;
            }

            // This config value could tell the provider where to find the translations, 
            // set to 0 though, will be looked up after initialization in the provider itself.
            NameValueCollection configValues = new NameValueCollection { { "containerid", "0" } };
            var translationProviderProvider = new BlobLocalizationService();
            translationProviderProvider.Initialize(ProviderName, configValues);
            try
            {
                this.LocalizationService.Providers.Add(translationProviderProvider);
            }
            catch (NotSupportedException notSupportedException)
            {
                Log.Error("[LocalizationResult] Error add provider to the LocalizationResult Service.", notSupportedException);
                return false;
            }
            LoadTranslations(translationProviderProvider);

            return true;
        }

        /// <summary>
        ///     Uns the load provider.
        /// </summary>
        /// <returns>
        ///     [false] if the provider has been unloaded, as it's not initialized anymore.
        /// </returns>
        private bool UnLoadProvider(LocalizationProvider localizationProvider)
        {
            if (this.LocalizationService == null)
            {
                return false;
            }

            if (localizationProvider != null)
            {
                // If found, remove it.
                this.LocalizationService.Providers.Remove(localizationProvider);
            }

            return false;
        }

        public void ReInitProvider()
        {
            var service = ServiceLocator.Current.GetInstance<LocalizationService>() as ProviderBasedLocalizationService;
            if (service == null)
            {
                Log.Error("LocalizationService unavailable");
                return;
            }
            var translationProvider = this.GetTranslationProvider();
            UnLoadProvider(translationProvider);
            LoadProvider();
        }
    }
}