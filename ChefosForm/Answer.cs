using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{

    public class Answer
    {

        private string vendor;

        private int satisfaction;

        public Answer(string vendor, int satisfaction) {
            this.vendor = vendor;
            this.satisfaction = satisfaction;
        }

        public override string ToString(){
            return vendor + " " + satisfaction;
        }

        public Dictionary<string, string> AsDictionary() { 
            Dictionary<string, string> result= new Dictionary<string,string>();
            result.Add("vendor", vendor);
            result.Add("satisfaction", satisfaction.ToString());
            return result;
        }
       
    }
}
