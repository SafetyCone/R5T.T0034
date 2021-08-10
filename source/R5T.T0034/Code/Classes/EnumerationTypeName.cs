using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class EnumerationTypeName : IEnumerationTypeName
    {
        #region Static

        public static EnumerationTypeName Instance { get; } = new();

        #endregion
    }
}