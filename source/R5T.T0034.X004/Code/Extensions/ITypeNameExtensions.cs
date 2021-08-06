using System;
using System.Linq;


namespace R5T.T0034.X004
{
    public static class ITypeNameExtensions
    {
        public static string GetClassName(this ITypeName _, string typeNameStem)
        {
            // Just return the type name.
            return typeNameStem;
        }

        public static string GetInterfaceName(this ITypeName _, string typeNameStem)
        {
            var output = $"{Instances.TypeNameAffix.InterfaceNamePrefix()}{typeNameStem}";
            return output;
        }

        public static bool IsInterface(this ITypeName typeName,
            string typeNameValue)
        {
            typeName.VerifyIsNonEmpty(typeNameValue);

            // Is the first character of the type name the interface name prefix character.
            var output = typeNameValue.First() == Instances.TypeNameAffix.InterfaceNamePrefixChar();
            return output;
        }
    }
}
