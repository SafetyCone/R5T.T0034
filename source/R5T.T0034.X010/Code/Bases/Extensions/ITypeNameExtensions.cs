using System;

using R5T.T0034;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string IServiceCollectionExtensions(this ITypeName _)
        {
            var output = _.GetExtensionsOfTypeNameTypeName(
                _.IServiceCollection());

            return output;
        }
    }
}
