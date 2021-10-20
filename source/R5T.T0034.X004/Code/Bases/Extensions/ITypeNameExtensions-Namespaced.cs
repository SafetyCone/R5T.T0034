using System;


namespace R5T.T0034.X004
{
    public static partial class ITypeNameExtensions
    {
        public static string GetDefaultImplementationClassNameForInterfaceName_Unchecked(this ITypeName _,
            string interfaceName)
        {
            var output = interfaceName[1..];
            return output;
        }

        public static string GetDefaultImplementationClassNameForInterfaceName_Checked(this ITypeName _,
            string interfaceName)
        {
            // Verify the input is an interface name.
            _.VerifyIsInterface(interfaceName);

            var output = _.GetDefaultImplementationClassNameForInterfaceName_Unchecked(interfaceName);
            return output;
        }
    }
}
