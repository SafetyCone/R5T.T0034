using System;

using R5T.Magyar.T002;


namespace R5T.T0034.X001
{
    public static class Instances
    {
        public static IExceptionMessageGenerator ExceptionMessageGenerator { get; } = Magyar.T002.ExceptionMessageGenerator.Instance;
    }
}
