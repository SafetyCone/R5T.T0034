using System;

using R5T.T0034;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string IServiceCollectionExtensions(this ITypeName typeName)
        {
            var output = typeName.GetExtensionsOfTypeNameTypeName(typeName.IServiceCollection());
            return output;
        }
    }
}
