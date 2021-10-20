using System;


namespace R5T.T0034.X004
{
    public static partial class ITypeNameExtensions
    {
        public static string GetTypeNameStemForInterfaceName_Unchecked(this ITypeName _,
            string interfaceName)
        {
            var output = interfaceName[1..];
            return output;
        }

        public static string GetTypeNameStemForInterfaceName_Checked(this ITypeName _,
            string interfaceName)
        {
            // Verify the input is an interface name.
            _.VerifyIsInterface(interfaceName);

            var output = _.GetTypeNameStemForInterfaceName_Unchecked(interfaceName);
            return output;
        }
    }
}
