using System;

using R5T.Magyar.T002;


namespace R5T.T0034.X001
{
    public static class IExceptionMessageGeneratorExtensions
    {
        public static string TypeNameValueWasEmpty(this IExceptionMessageGenerator _)
        {
            var output = "Type name value was empty.";
            return output;
        }
    }
}
