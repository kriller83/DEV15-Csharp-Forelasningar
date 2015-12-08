using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning10._1_Extensions
{
    //public static, public static, this....
    public static class MyStringExtension
    {
        public static string Dotify(this string text)
        {
            string result = text.Trim();
            if (result[result.Length - 1] != '.')
                return result + '.';
            else
                return result;
        }
        public static string Plussa(this string tal)
        {
            return tal + tal;
        }
        public static string BigLetter(this string text)
        {
            string result = text.ToUpper();
            if (result[result.Length + 1] != '.')
                return result + '.';
            else
                return result;
        }
    }
}
