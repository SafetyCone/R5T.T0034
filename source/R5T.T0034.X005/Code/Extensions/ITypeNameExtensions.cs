using System;

using R5T.T0034;
using R5T.T0034.X005;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string GetArrayOf(this ITypeName _,
            string type)
        {
            var output = $"{type}{Instances.Syntax.ArrayEmpty()}";
            return output;
        }

        /// <summary>
        /// Works on strings that are either just type names or namespaced type names.
        /// </summary>
        private static string GetGenericOfByTypeNameOrNamespacedTypeName(this ITypeName _,
            string genericType,
            string typeParameterType)
        {
            // String construction works for both type names and namespaced type names.
            var output = $"{genericType}{Instances.Syntax.TypeArgumentsListOpen()}{typeParameterType}{Instances.Syntax.TypeArgumentsListClose()}";
            return output;
        }

        public static string GetGenericOfByTypeName(this ITypeName _,
            string genericTypeName,
            string typeParameterTypeName)
        {
            var output = _.GetGenericOfByTypeNameOrNamespacedTypeName(
                genericTypeName,
                typeParameterTypeName);

            return output;
        }

        public static string GetGenericOfByNamespacedTypeName(this ITypeName _,
            string genericNamespacedTypeName,
            string typeParameterNamespacedTypeName)
        {
            var output = _.GetGenericOfByTypeNameOrNamespacedTypeName(
                genericNamespacedTypeName,
                typeParameterNamespacedTypeName);

            return output;
        }

        /// <summary>
        /// Chooses namespaced type name method <see cref="GetGenericOfByNamespacedTypeName(ITypeName, string, string)"/> as the default.
        /// </summary>
        public static string GetGenericOf(this ITypeName _,
            string genericNamespacedTypeName,
            string typeParameterNamespacedTypeName)
        {
            var output = _.GetGenericOfByNamespacedTypeName(
                genericNamespacedTypeName,
                typeParameterNamespacedTypeName);

            return output;
        }
    }
}
