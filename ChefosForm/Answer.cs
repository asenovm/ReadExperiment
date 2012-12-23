using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{

    public class Answer
    {

        private string vendor;

        public Answer(string vendor) {
            this.vendor = vendor;
        }

        public override string ToString(){
            return vendor;
        }
       
    }
}
