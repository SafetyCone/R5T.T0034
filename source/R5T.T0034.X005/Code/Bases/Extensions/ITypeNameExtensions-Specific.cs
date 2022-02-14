using System;

using R5T.T0034;
using R5T.T0034.X005;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string StringArray(this ITypeName _)
        {
            var output = _.GetArrayOf(_.String());
            return output;
        }

        public static string GetTaskOfTypeNameByTypeName(this ITypeName _,
            string typeName)
        {
            var output = _.GetGenericOfByTypeName(_.Task(), typeName);
            return output;
        }
    }
}
