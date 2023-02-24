using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class InterfaceTypeName : IInterfaceTypeName
    {
        #region Static

        public static InterfaceTypeName Instance { get; } = new InterfaceTypeName();

        #endregion
    }
}