using System;


namespace R5T.T0034.T001.X001
{
    public static class SimpleTypeNameAffixes
    {
        public static char InterfacePrefixChar => 'I';
        public static string InterfacePrefix { get; } = InterfacePrefixChar.ToString();
    }
}
