using System;


namespace R5T.T0034.T001.X002
{
    public static class ComplexTypeNameAffixes
    {
        public static string AggregationSuffix => "Aggregation";

        [Obsolete("See R5T.F0000.ITypeNameAffixes.ExtensionsSuffix")]
        public static string ExtensionsSuffix => "Extensions";
    }
}
