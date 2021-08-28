using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class NamespacedTypeName : INamespacedTypeName
    {
        #region Static

        public static NamespacedTypeName Instance { get; } = new();

        #endregion
    }
}