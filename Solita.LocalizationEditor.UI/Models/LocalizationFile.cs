using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace Solita.LocalizationEditor.UI.Models
{
    [ContentType(
        GUID = "0E99DF44-8473-45AB-989B-6EF54ADF1D10",
        DisplayName = "LocalizationResult file"
        )]
    public class LocalizationFile : MediaData
    {
        
    }
}