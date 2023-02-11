using System;

using R5T.T0034;
using R5T.T0034.X011;


namespace System
{
    [Obsolete("See R5T.Z0027.IClassNames and R5T.Z0027.IInterfaceNames")]
    public static class ITypeNameExtensions
    {
        public static string Class1(this ITypeName _)
        {
            return TypeNames.Class1;
        }

        public static string Interface1(this ITypeName _)
        {
            return TypeNames.Interface1;
        }

        public static string Program(this ITypeName _)
        {
            return TypeNames.Program;
        }

        public static string Startup(this ITypeName _)
        {
            return TypeNames.Startup;
        }
    }
}
