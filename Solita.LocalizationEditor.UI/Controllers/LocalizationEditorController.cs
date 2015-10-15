using System;
using System.Configuration;
using System.IO;
using System.Web.Mvc;
using EPiServer.Shell.Navigation;
using Newtonsoft.Json;
using Solita.LocalizationEditor.UI.Common;
using Solita.LocalizationEditor.UI.DAL;
using Solita.LocalizationEditor.UI.Helpers;
using Solita.LocalizationEditor.UI.Lang;
using Solita.LocalizationEditor.UI.Models;
using System.Net;
using System.Xml.Linq;
using System.Xml;

namespace Solita.LocalizationEditor.UI.Controllers
{
    public class LocalizationEditorController : Controller
    {
        private readonly LocalizationPersister _persister;

        public LocalizationEditorController()
        {
            _persister = new LocalizationPersister(new BlobFileAccessStrategy());
        }

        [MenuItem("/global/cms/localizations", TextResourceKey = "CmsMenuTitle", ResourceType = typeof(CmsMenuTitleProvider))]
        public ActionResult Index()
        {
            var model = new LocalizationEditorViewModel
            {
                Categories = _persister.GetLocalizations(),
                Languages = _persister.GetEnabledLanguages(),
                Versions = _persister.GetTranslationFileVersions(),
                PowertoolsMode = !Settings.AutoPopulated.DisablePowertoolsMode
            };

            return View(ModuleUtil.PathTo("Views/LocalizationEditor/Index.cshtml"), model);
        }

        [HttpPost]
        public ActionResult Save(LocalizationEditorViewModel model)
        {
            _persister.SaveLocalizations(model);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult GetJsonLocalizations()
        {
            var localizations = _persister.GetLocalizations();

            return Json(localizations);
        }

        [HttpPost]
        public JsonResult GetJsonLocalizations(string version)
        {
            var localizations = _persister.GetTranslationsForVersion(version);

            return Json(localizations);
        }

        [HttpPost]
        public JsonResult TransformLocalizationXmlToJsonLocazlitaions()
        {
            using (var stream = HttpContext.Request.InputStream)
            {
                var xDoc = XDocument.Load(stream);
                XmlLanguageFileHelper helpr = new XmlLanguageFileHelper();
                var localizations = helpr.TransformXmlToTranslationsList(xDoc);

                return Json(localizations);
            }
        }
    }
}