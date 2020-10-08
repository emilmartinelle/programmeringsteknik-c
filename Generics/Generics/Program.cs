using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionaryWithIntigerKeys = new Dictionary<int, string>();

            dictionaryWithIntigerKeys.Add(1, "stop");
            dictionaryWithIntigerKeys.Add(2, "start");

            // Samma sätt som ovan

            //Dictionary<int, string> dictionaryWithIntigerKeys = new Dictionary<int, string>()
            //{
            //    { 1, "stop"},
            //    { 2,"go"}
            //};

            // Kontrollera om ett värde finns eller ej
            bool dictionaryContainsOne = dictionaryWithIntigerKeys.ContainsKey(1);

            string stringValueWithStop = dictionaryWithIntigerKeys[1]; // Värdet 'stop'

            //if (dictionaryContainsOne)
            //{
            //    string stringValueWithStop = dictionaryWithIntigerKeys[1];

            //    // Detta genererar fel
            //   // string notFoundValue = dictionaryWithIntigerKeys[3];
            //}


            // Loopa alla värden i dictionary
            foreach (var value in dictionaryWithIntigerKeys.Values)
            {

            }

            // Loopa alla nycklar i dictionary
            // Denna är enklast och användbarast (oftasts)
            foreach (var key in dictionaryWithIntigerKeys.Keys)
            {
                // möjlighet att hämta värdet
                string value = dictionaryWithIntigerKeys[key];
            }

            // Loopa alla nyckelvärden i dictionary
            foreach (var keyValue in dictionaryWithIntigerKeys)
                {
                // Värdet
                // keyValue.Value;

                //Nyckeln
                //keyValue;
            }
            // Array med nyckelvärdepar
            // Ej sorterad, måste eftersorteras med .Sort eller LINQ
            dictionaryWithIntigerKeys.ToList();

            foreach (var keyValue in dictionaryWithIntigerKeys)
            {
                Console.WriteLine($"Key: {keyValue.Key}, Value; {keyValue.Value}");
            }

            Console.WriteLine("\n");

            // Array med värden
            // Ej sorterad heller
            string[] valueArray = dictionaryWithIntigerKeys.Values.ToArray();

            for (int i = 0; i < valueArray.Length; i++)
            {
                Console.WriteLine(valueArray[i]);
            }

            Guid.NewGuid();

            Dictionary<int, (int Id, string Name)> inventory = new Dictionary<int, (int Id, string Name)>
            {
                {1, (1, "Bok, Kalas Alfons Åberg") },
                {2, (2, "Leksak, Ugglis, Pyjamashjältarna") }
            };

            if(inventory.ContainsKey(1))
            {
                var value = inventory[i];

                // I detta fallet pekavr value på referenstyp
                // Värdet i inventory kommer ej uppdateras
                value.Name = "New name for product 1";
            }

            Dictionary<int, Product> ProductInventory = new Dictionary<int, Product>
            {
                {1, new Product{Id=1,Name="Briotåg"} },
                {2, new Product{Id=2, Name="Leksakshäst"} }
            };

            if (ProductInventory.ContainsKey(1))
            {
                var value = ProductInventory[1];

                value.Name = "Briotåg 2";
            }

            Index<int, Product> productIndex = new Index<int, Product>();
            indexWithIntigers.Add(1);
            var value = indexWithIntigers.Find(x => x == 1);
        }
    }
}
