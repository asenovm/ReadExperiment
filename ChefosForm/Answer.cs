using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    public class Answer
    {
        private static string KEY_VENDOR = "vendor";

        private static string KEY_SATISFACTION = "satisfaction";

        private string vendor;

        private int satisfaction;

        /**
         *  Creates a new Answer out of the <tt>vendor</tt> 
         *  and <tt>satisfaction</tt> values provided
         */
        public Answer(string vendor, int satisfaction)
        {
            this.vendor = vendor;
            this.satisfaction = satisfaction;
        }

        /**
         *  Returns the answer values as a dictionary
         */
        public Dictionary<string, string> AsDictionary()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            result.Add(KEY_VENDOR, vendor);
            result.Add(KEY_SATISFACTION, satisfaction.ToString());
            return result;
        }

        public override string ToString()
        {
            return vendor + " " + satisfaction;
        }

    }
}
