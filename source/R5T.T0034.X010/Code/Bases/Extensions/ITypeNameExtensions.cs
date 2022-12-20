using System;

using R5T.T0034;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string IServiceCollectionExtensions(this ITypeName _)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var output = _.GetExtensionsOfTypeNameTypeName(
                _.IServiceCollection());
#pragma warning restore CS0618 // Type or member is obsolete

            return output;
        }
    }
}
