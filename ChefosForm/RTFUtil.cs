using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChefosForm
{
    public class RTFUtil
    {
        public static String AppendRTF(string rtf, string appendee) {
            return "{\\rtf1\\ansicpg1251 " + appendee + " \\r\\n " + rtf.Substring("{\\rtf1\\ansicpg1251 ".Length + 4);
        }

        public static string ToRTF(string text) {
            return "{\\rtf1\\ansicpg1251 " + text + "}";
        }
    }
}
