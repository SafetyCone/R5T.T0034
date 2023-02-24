using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameStem : ITypeNameStem
    {
        #region Static

        public static TypeNameStem Instance { get; } = new TypeNameStem();

        #endregion
    }
}