using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ClassTypeName : IClassTypeName
    {
        #region Static

        public static ClassTypeName Instance { get; } = new ClassTypeName();

        #endregion
    }
}