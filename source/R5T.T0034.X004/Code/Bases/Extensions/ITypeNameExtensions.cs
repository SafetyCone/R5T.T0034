using System;
using System.Linq;

using R5T.T0034;
using R5T.T0034.X004;


namespace System
{
    public static partial class ITypeNameExtensions
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

        public static string GetDefaultImplementationClassNameForInterfaceName(this ITypeName _,
            string interfaceName)
        {
            // Use -checked for robustness.
            var output = _.GetDefaultImplementationClassNameForInterfaceName_Checked(interfaceName);
            return output;
        }

        public static string GetInterfaceName(this ITypeName _,
            string typeNameStem)
        {
            var output = $"{Instances.TypeNameAffix.InterfaceNamePrefix()}{typeNameStem}";
            return output;
        }

        public static bool IsInterface(this ITypeName _,
            string typeName)
        {
            _.VerifyIsNonEmpty(typeName);

            // Is the first character of the type name the interface name prefix character.
            var output = typeName.First() == Instances.TypeNameAffix.InterfaceNamePrefixChar();
            return output;
        }

        public static string Pluralize(this ITypeName _,
            string typeName)
        {
            var output = typeName + Strings.S_LowerCase;
            return output;
        }

        public static void VerifyIsInterface(this ITypeName _,
            string typeName)
        {
            var isInterface = _.IsInterface(typeName);
            if (!isInterface)
            {
                throw new Exception($"'{typeName}': Type name not recognized as an interface name.");
            }
        }
    }
}
