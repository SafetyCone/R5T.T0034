using System;

using R5T.T0034.T001;
using R5T.T0034.T001.X002;


namespace System
{
    public static class ITypeNameAffixExtensions
    {
        public static string AggregationSuffix(this ITypeNameAffix _)
        {
            return ComplexTypeNameAffixes.AggregationSuffix;
        }

        [Obsolete("See R5T.F0000.ITypeNameAffixes.ExtensionsSuffix")]
        public static string ExtensionsSuffix(this ITypeNameAffix _)
        {
            return ComplexTypeNameAffixes.ExtensionsSuffix;
        }
    }
}
