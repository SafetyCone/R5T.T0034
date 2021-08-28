using System;

using R5T.T0034;
using R5T.T0034.X007;


namespace System
{
    public static class INamespacedTypeNameExtensions
    {
        public static string String(this INamespacedTypeName namespacedTypeName)
        {
            var output = namespacedTypeName.From(
                Instances.NamespaceName.System().Value(),
                Instances.TypeName.String());

            return output;
        }

        public static string Task(this INamespacedTypeName namespacedTypeName)
        {
            var output = namespacedTypeName.From(
                Instances.NamespaceName.System().Threading().Tasks().Value(),
                Instances.TypeName.Task());

            return output;
        }
    }
}
