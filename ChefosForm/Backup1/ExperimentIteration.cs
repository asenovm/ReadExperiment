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
        }

        public SupplierOffer[] Suppliers;
	}
}
