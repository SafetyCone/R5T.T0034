using System;

using R5T.Magyar;

using R5T.T0034;
using R5T.T0034.X001;


namespace System
{
    public static class IAttributeTypeNameExtensions
    {
        public static string GetAttributeSuffixedTypeName(this IAttributeTypeName _,
            string typeName)
        {
            var output = $"{typeName}{TypeNameAffixes.AttributeSuffix}";
            return output;
        }

        public static string GetEnsuredAttributeSuffixedTypeName(this IAttributeTypeName _,
            string typeName)
        {
            var isAttributeSuffixedTypeName = _.IsAttributeSuffixedTypeName(typeName);
            if(!isAttributeSuffixedTypeName)
            {
                var output = _.GetAttributeSuffixedTypeName(typeName);
                return output;
            }
            else
            {
                return typeName;
            }
        }

        public static string GetEnsuredNonAttributeSuffixedTypeName(this IAttributeTypeName _,
            string typeName)
        {
            var isAttributeSuffixedTypeName = _.IsAttributeSuffixedTypeName(typeName);
            if (isAttributeSuffixedTypeName)
            {
                var output = _.GetNonAttributeSuffixedTypeName(typeName);
                return output;
            }
            else
            {
                return typeName;
            }
        }

        public static string GetNonAttributeSuffixedTypeName(this IAttributeTypeName _,
            string attributeSuffixedTypeName)
        {
            var output = attributeSuffixedTypeName.ExceptEnding(TypeNameAffixes.AttributeSuffix);
            return output;
        }

        public static bool IsAttributeSuffixedTypeName(this IAttributeTypeName _,
            string typeName)
        {
            var output = typeName.EndsWith(TypeNameAffixes.AttributeSuffix);
            return output;
        }
    }
}
