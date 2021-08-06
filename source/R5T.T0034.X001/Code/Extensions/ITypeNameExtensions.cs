using System;


namespace R5T.T0034.X001
{
    public static class ITypeNameExtensions
    {
        public static bool IsNonEmpty(this ITypeName _, string typeName)
        {
            var output = typeName.IsNonNullOrEmpty();
            return output;
        }

        public static void VerifyIsNonEmpty(this ITypeName typeName, string typeNameValue)
        {
            var isNonEmpty = typeName.IsNonEmpty(typeNameValue);
            if (!isNonEmpty)
            {
                throw new ArgumentException(Instances.ExceptionMessage.TypeNameValueWasEmpty(), nameof(typeNameValue));
            }
        }
    }
}
