using System;

using R5T.T0034.T001;
using R5T.T0034.T001.X001;


namespace System
{
    public static class ITypeNameAffixExtensions
    {
        public static string InterfaceNamePrefix(this ITypeNameAffix _)
        {
            return SimpleTypeNameAffixes.InterfacePrefix;
        }

        public static char InterfaceNamePrefixChar(this ITypeNameAffix _)
        {
            return SimpleTypeNameAffixes.InterfacePrefixChar;
        }
    }
}
