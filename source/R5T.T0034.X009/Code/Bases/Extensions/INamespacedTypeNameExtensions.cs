using System;
using System.Collections.Generic;
using System.Linq;

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

        public static string GetRelativeNamespacedTypeName(this INamespacedTypeName _,
            string namespacedTypeName,
            string otherNamespaceName)
        {
            var namespacedTypeNameTokens = Instances.NamespaceName.Tokenize(namespacedTypeName);
            var otherNamespaceNameTokens = Instances.NamespaceName.Tokenize(otherNamespaceName);

            var namespacedTypeNameComplementaryTrailingTokens = namespacedTypeNameTokens.GetTrailingComplement(otherNamespaceNameTokens);

            var relativeNamespacedTypeName = Instances.NamespaceName.CombineTokens(namespacedTypeNameComplementaryTrailingTokens);
            return relativeNamespacedTypeName;
        }

        public static string GetRelativeNamespacedTypeNameOld(this INamespacedTypeName _,
            string namespacedTypeName,
            string otherNamespaceName)
        {
            var namespaceNameForType = _.GetNamespaceName(namespacedTypeName);

            var isInOtherNamespace = Instances.NamespaceName.IsIn(namespaceNameForType, otherNamespaceName);
            if(isInOtherNamespace)
            {
                var extraBeyondOtherNamespace = namespacedTypeName[otherNamespaceName.Length..];

                var output = extraBeyondOtherNamespace.TrimStart(Instances.NamespaceName.TokenSeparatorCharacter());
                return output;
            }
            else
            {
                // Else, just return the whole namespaced type name since no part of the namespaced type name is in the other namespace.
                return namespacedTypeName;
            }
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
            var indexOfTick = namespacedTypeName.IndexOf(Characters.Tick);

            var indexOfLastPeriod = StringHelper.IsFound(indexOfTick)
                ? namespacedTypeName.LastIndexOf(Characters.Period, indexOfTick)
                : namespacedTypeName.LastIndexOf(Characters.Period)
                ;

            var output = namespacedTypeName[(indexOfLastPeriod + 1)..];
            return output;
        }

        /// <summary>
        /// A description, not a transformation.
        /// Takes the form {Type Name}: {Namespaced Type Name}.
        /// This makes it easy to sort alphabetically and see all common type names pair with their namespaced type names.
        /// </summary>
        public static string GetTypeNameWithNamespacedTypeNameDescription(this INamespacedTypeName _,
            string namespacedTypeName)
        {
            var typeName = _.GetTypeName(namespacedTypeName);

            var output = $"{typeName}: {namespacedTypeName}";
            return output;
        }
    }
}
