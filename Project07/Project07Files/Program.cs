using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Project07Files
{
    class Program
    {
        const string separator = ";";

        static void Main(string[] args)

        {
            // Definera en listasom vi kan lagra produktdata i
            List<Product> products = new List<Product>();

            // Läsa in en fils textinehåll
            // Filestream för att läsa filens innehål som bytes från början till slut
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {
                // Streamreader för att konvertera bytes till tecken
                using (StreamReader reader = new StreamReader(stream))
                {
                    // Så här kan man få ut all text på en gång
                    string fileContent = reader.ReadToEnd();

                }
                // Går att skriva så här istället
                string simpleReadFileContent = File.ReadAllText("maxfritid.csv");


            }
            using (FileStream stream = File.Open("maxfritid.csv", FileMode.Open))
            {

                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        // Logik för raden
                        string[] columns = line.Split(separator);

                        try
                        {
                            Product product = CreateProduct(columns);
                          
                            // Placera behandlingen efter inläsningen, i samma try-sats
                            // För att undvika behandling av ogiltig data
                            products.Add(product);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                       
                        line = reader.ReadLine();

                    }

                }

            }

        }
        static void PrintProducts(IEnumerable<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Id}: {product.ProductName}");
            }
        }

        static Product CreateProduct(string[] coloumns)
        {
            return new Product
            {
                Id = Convert.ToInt32(columns[0]),
                ProuctNumber = columns[2],
                ProductName = columns[3],
                ProductBrand = ConvertToNullableInt(columns[4]),
                ProductSupplier = columns[5],
                ProductSynonyms = ConvertToArray(columns[6])
            }
        }

        static int ConvertToInt(string input)
        {
            int TryParse(input, out int result)

                    return result;
        }
        static int? ConvertToNullableInt(string input)
        {
            if (int TryParse(input, out int result))

                        {
                return result;
            }
            else
            {
                return null;
            }


        }
        // Konvertera till array 
        static string[] ConnvertToArray(string output)
        {
            if (input == null)
                return new string[0];

            return input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }

}
