using System;

using R5T.T0034;
using R5T.T0034.X006;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string GetCSharpCodeFileName(this ITypeName _,
            string typeName)
        {
            // Just use the type name directly, assuming it only contains valid characters.
            var output = $"{typeName}.{Instances.FileExtension.cs()}";
            return output;
        }
    }
}
