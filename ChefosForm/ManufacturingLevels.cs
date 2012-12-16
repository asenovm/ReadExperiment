using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class ManufacturingLevels
    {

        private int manufacturingLevels;

        public ManufacturingLevels(int levels){
            manufacturingLevels = levels;
        }

        public override string ToString()
        {
            return manufacturingLevels.ToString();
        }

    }
}
