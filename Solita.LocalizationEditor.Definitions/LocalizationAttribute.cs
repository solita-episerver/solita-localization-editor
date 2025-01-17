﻿using System;

namespace Solita.LocalizationEditor.Definitions
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class LocalizationAttribute : Attribute
    {
        public string Description { get;  set; }
        public string DefaultValue { get; set; }
    }
}