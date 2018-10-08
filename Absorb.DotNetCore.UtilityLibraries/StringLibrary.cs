using System;

namespace Absorb.DotNetCore.UtilityLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            return char.IsUpper(str[0]);
        }

        public static bool StartsWithLower(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            return char.IsLower(str[0]);
        }

        public static GetEnum<TEnum>()
    }
}
