﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Read
{
    public class ManufacturingLevels
    {

        private double manufacturingLevels;

        public ManufacturingLevels(double levels)
        {
            manufacturingLevels = levels;
        }

        public override string ToString()
        {
            return manufacturingLevels.ToString();
        }

    }
}
