using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string Obj, int cutLength)
        {
            return Obj.Length <= cutLength ? Obj : Obj.Substring(0, cutLength) + "...";
        }
    }
}
