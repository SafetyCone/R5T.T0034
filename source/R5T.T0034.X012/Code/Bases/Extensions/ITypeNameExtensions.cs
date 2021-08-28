using System;

using R5T.T0034;
using R5T.T0034.X012;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string Int(this ITypeName _)
        {
            return CSharpKeywordTypeNames.Int;
        }

        public static string String(this ITypeName _)
        {
            return CSharpKeywordTypeNames.String;
        }

        public static string Void(this ITypeName _)
        {
            return CSharpKeywordTypeNames.Void;
        }
    }
}
