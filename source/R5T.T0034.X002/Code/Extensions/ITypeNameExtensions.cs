using System;

using R5T.T0034;
using R5T.T0034.X002;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string String(this ITypeName _)
        {
            return SystemTypeNames.String;
        }

        public static string Task(this ITypeName _)
        {
            return SystemTypeNames.Task;
        }
    }
}
