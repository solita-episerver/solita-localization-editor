using Solita.LocalizationEditor.UI.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Framework;

namespace Solita.LocalizationEditor.TestProject.Business
{
    [InitializableModule]
    [ModuleDependency(typeof(FrameworkInitialization))]
    public class LocalizationInit : TranslationProviderInitialization
    {
        
    }
}