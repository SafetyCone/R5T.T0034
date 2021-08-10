using System;
using System.Linq;

using R5T.T0034;
using R5T.T0034.X004;


namespace System
{
    public static class ITypeNameExtensions
    {
        public static string GetClassName(this ITypeName _,
            string typeNameStem)
        {
            // Just return the type name.
            return typeNameStem;
        }

        public static string GetExtensionsOfTypeNameTypeName(this ITypeName _,
            string typeName)
        {
            var output = $"{typeName}{Instances.TypeNameAffix.ExtensionsSuffix()}";
            return output;
        }

        public static string GetInterfaceName(this ITypeName _,
            string typeNameStem)
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

        public static string Pluralize(this ITypeName _,
            string typeName)
        {
            var output = typeName + Strings.S_LowerCase;
            return output;
        }
    }
}
