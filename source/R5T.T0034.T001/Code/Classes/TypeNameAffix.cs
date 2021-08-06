using System;


namespace R5T.T0034.T001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameAffix : ITypeNameAffix
    {
        #region Static

        public static TypeNameAffix Instance { get; } = new();

        #endregion
    }
}