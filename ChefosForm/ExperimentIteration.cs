using System;

namespace ChefosForm
{
	public class ExperimentIteration 
	{
		public ExperimentIteration(string iterationAsString)
		{
			char[] separators = new char[2];
			separators[0] = ' ';
			separators[1] = '\t';
			string[] items = iterationAsString.Split(separators);

            Suppliers = new SupplierOffer[4];
            Suppliers[0] = new SupplierOffer(items[0], items[1]);
            Suppliers[1] = new SupplierOffer(items[2], items[3]);
            Suppliers[2] = new SupplierOffer(items[4], items[5]);
            Suppliers[3] = new SupplierOffer(items[6], items[7]);
            if (items.Length > 8) {
                manufacturingLevels = new ManufacturingLevels(double.Parse(items[8], System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
                manufacturingIncrease = new ManufacturingIncrease(double.Parse(items[9], System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            }
        }

        public SupplierOffer[] Suppliers;

        private ManufacturingLevels manufacturingLevels;

        private ManufacturingIncrease manufacturingIncrease;

        public Boolean HasEconomicData() {
            return manufacturingLevels != null && manufacturingIncrease != null;
        }

        public string GetManufacturingLevels() {
            return manufacturingLevels.ToString();
        }

        public string GetManufacturingIncrease() {
            return manufacturingIncrease.ToString();
        }

	}
}
