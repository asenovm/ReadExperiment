using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChefosForm
{
    public class RTFUtil
    {
        public static String AppendRTF(string rtf, string appendee)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("{\\rtf1\\ansicpg1251 ");
            builder.Append(appendee);
            builder.Append("\\line");
            builder.Append("\\line");
            builder.Append(rtf.Substring("{\\rtf1\\ansicpg1251 ".Length + 4));
            return builder.ToString();
        }

        public static string ToRTF(string text)
        {
            return "{\\rtf1\\ansicpg1251 " + text + "}";
        }
    }
}
