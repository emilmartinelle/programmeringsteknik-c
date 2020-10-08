using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace JSONConverterTest
{
    public class Program
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }


        static void Main(string[] args)
        {
            string json = @"{
    'Name': 'Super73-SG1-BLK',
    'DisplayName': 'Super73 – SG1, Black',
    }";
            Program name = JsonConvert.DeserializeObject<Program>(json);
            Program displayName = JsonConvert.DeserializeObject<Program>(json);

            Console.WriteLine(displayName.DisplayName);
        }
    }
}
