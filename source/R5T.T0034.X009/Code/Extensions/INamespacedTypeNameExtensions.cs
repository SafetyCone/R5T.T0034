using System;

using R5T.T0034;
using R5T.T0034.X009;


namespace System
{
    public static class INamespacedTypeNameExtensions
    {
        public static string From(this INamespacedTypeName _,
            string namespaceName,
            string typeName)
        {
            var output = $"{namespaceName}{Instances.NamespaceName.TokenSeparator()}{typeName}";
            return output;
        }

        public static string GetNamespaceName(this INamespacedTypeName _,
            string namespacedTypeName)
        {
            var index = namespacedTypeName.LastIndexOf(Instances.NamespaceName.TokenSeparator());

            var output = namespacedTypeName.Substring(0, index);
            return output;
        }

        /// <summary>
        /// Quality-of-life overload for <see cref="From(INamespacedTypeName, string, string)"/>.
        /// </summary>
        public static string GetNamespacedName(this INamespacedTypeName namespacedTypeName,
            string namespaceName,
            string typeName)
        {
            var output = namespacedTypeName.From(namespaceName, typeName);
            return output;
        }

        public static string GetTypeName(this INamespacedTypeName _,
            string namespacedTypeName)
        {
            var output = Instances.NamespaceName.GetLastToken(namespacedTypeName);
            return output;
        }
    }
}
