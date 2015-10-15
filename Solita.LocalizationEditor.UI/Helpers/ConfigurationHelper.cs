using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Solita.LocalizationEditor.UI.Helpers
{
    public class ConfigurationHelper
    {
        public static string GetConfiguration(string selector)
        {
            return ConfigurationManager.GetSection(selector) as string;
        }

        public static Configuration GetConfigFile(string configName)
        {
            return ConfigurationManager.OpenExeConfiguration(configName);
        }
    }

    public static class PathHelper
    {
        public static string GetPathRealtiveToCurrentDirectory(string fileRelativePath)
        {
            var rootPath = AppDomain.CurrentDomain.BaseDirectory;
            if (rootPath.EndsWith("\\"))
            {
                rootPath = rootPath.TrimEnd('\\');
            }
            return $"{rootPath}\\{fileRelativePath}";
        }

        public static string TrimTrailingSlash(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            return str.TrimEnd('/').TrimEnd('\\');
        }
    }
}