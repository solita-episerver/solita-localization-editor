using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Solita.LocalizationEditor.TestProject.Models.Pages
{
    [ContentType
        (DisplayName = "start page",
        GUID = "021EBC43-C6BE-4564-B332-5D9840A72070")
        ]
    public class StartPage : PageData
    {
        public virtual XhtmlString PageContent { get; set; }
    }
}