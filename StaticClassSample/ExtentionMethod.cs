using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassSample
{
    public static class ExtentionMethod
    {
        public static string ChangeTurkishCharacters(this string str) {
            str = str.ToLower()
                .Trim()
                .Replace("ç", "c")
                .Replace("ğ", "g")
                .Replace("ı", "i")
                .Replace("ö", "o")
                .Replace("ş", "s")
                .Replace("ü", "u")
                .Replace("   ", " ")
                .Replace("  ", " ");
            return CultureInfo.CurrentUICulture.TextInfo.ToTitleCase(str); // str'deki kelimelerin ilk harfleri büyük yapar
        }
    }
}
