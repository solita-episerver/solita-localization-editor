﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solita.LanguageEditor.Definitions
{
    public class LocalizationHelpers
    {
        public static IEnumerable<Type> FindLocalizationCategoryTypes()
        {
            var attributeAssemblyName = typeof(LocalizationCategoryAttribute).Assembly.GetName().Name;

            return from assembly in AppDomain.CurrentDomain.GetAssemblies()
                   where assembly.GetReferencedAssemblies().Any(a => a.Name == attributeAssemblyName)
                   from type in assembly.GetTypes()
                   let attribute = GetLocalizationCategoryAttribute(type)
                   where attribute != null
                   orderby attribute.Order
                   select type;
        }

        public static LocalizationCategoryAttribute GetLocalizationCategoryAttribute(Type type)
        {
            return (LocalizationCategoryAttribute) Attribute.GetCustomAttribute(type, typeof(LocalizationCategoryAttribute));
        }

        public static IEnumerable<FieldInfo> FindLocalizationFields(IReflect type)
        {
            return from field in type.GetFields(BindingFlags.Static | BindingFlags.Public)
                   where GetLocalizationAttribute(field) != null
                   select field;
        }

        public static LocalizationAttribute GetLocalizationAttribute(FieldInfo field)
        {
            return (LocalizationAttribute) Attribute.GetCustomAttribute(field, typeof(LocalizationAttribute));
        }
    }
}