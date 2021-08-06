using System;

using R5T.T0034;
using R5T.T0034.X005;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string GetGenericOf(this ITypeName _,
            string genericTypeName,
            string typeParameterTypeName)
        {
            var output = $"{genericTypeName}{Instances.Syntax.TypeArgumentsListOpen()}{typeParameterTypeName}{Instances.Syntax.TypeArgumentsListClose()}";
            return output;
        }

        public static string GetTaskOfTypeName(this ITypeName typeName, string typeNameValue)
        {
            var output = typeName.GetGenericOf(typeName.Task(), typeNameValue);
            return output;
        }
    }
}
