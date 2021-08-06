using System;

using R5T.Magyar;


namespace R5T.T0034.X001
{
    public static class IExceptionMessageExtensions
    {
        public static string TypeNameValueWasEmpty(this IExceptionMessage _)
        {
            var output = "Type name value was empty.";
            return output;
        }
    }
}
