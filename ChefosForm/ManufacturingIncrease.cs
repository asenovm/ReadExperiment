using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class ManufacturingIncrease
    {

        private double increase;

        public ManufacturingIncrease(double increase) {
            this.increase = increase;
        }

        public override string ToString()
        {
            return increase.ToString();
        }
    }
}
