using System;
using System.Collections.Generic;
using System.Text;

namespace Session06Konstruktor
{
    class CupOfCoffee
    {
			public static string DefaultBeanType = "Java";

			public string BeanType;
			public bool Instant;
			public bool Milk;
			public byte SugarCubes;
			public string Description;

			private string _id; // Privata fält ska det vara '_' i början

		// Statisk Construktor
		static CupOfCoffee()
        {
			BeanTypes = new[]
			{
				"Arusha", "Arabica", "Blue Mountain","Robusta"
			}; // '};' Detta används som en instruktion och det är inget kodblock. Används som snabbkommando för att -
			  // lista en array
        }

		/* Ovan är samma sak som detta
		 * BeanTypes = newstring [4];
		 * BeanTypes[0] = "Arusha";
		 * BeanTypes[1] = "Arabica";
		 * BeanTypes[2] = "Blue Mountain";
		 * BeanTypes[3] = "Robusta";
		 */
			public CupOfCoffee() // Detta är konstruktorn, identiskt namn som class-namnet
			{

			}

			// Konstruktor med inparameter
			public CupOfCoffee(bool milk, byte sugar, byte sugarCubes)
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

