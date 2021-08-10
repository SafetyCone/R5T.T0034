using System;


namespace R5T.T0034
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class AttributeTypeName : IAttributeTypeName
    {
        #region Static

        public static AttributeTypeName Instance { get; } = new();

        #endregion
    }
}