using System;
using System.Collections.Generic;
using System.Text;

namespace ChefosForm
{
    public class ManufacturingIncrease
    {

        private double increase;

        public ManufacturingIncrease(double increase)
        {
            this.increase = increase;
        }

        public override string ToString()
        {
            if (increase < 0)
            {
                return "- " + Math.Abs(increase).ToString() + "%";
            }
            return "+ " + increase.ToString() + "%";
        }
    }
}
