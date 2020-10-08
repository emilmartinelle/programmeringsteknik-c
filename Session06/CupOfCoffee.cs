using System;
using System.Collections.Generic
using System.Text

namespace Session06
{
	class CupOfCoffee
	{

		public static string DefaultBeanType = "Java";

		public string BeanType
		public bool Instant
		public bool Milk;
		public byte SugarCubes
		public string Description;

		private string _id; // Privata fält ska det vara '_' i början

		public CupOfCoffee() // Detta är konstruktorn, identiskt namn som class-namnet
        {

        }

		// Konstruktor med inparameter
		public CupOfCoffee(bool milk, byte sugar)
		{
			SugarCubes = sugarCubes;
			Milk = milk;
		}

		// Finalizer eller destructor || Ej nödvändig för implementering i kursen, bara veta att den existerar
		~CupOfCoffee()
        {

        }

	}
}
