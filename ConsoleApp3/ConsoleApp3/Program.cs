using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace Newtonsoft
{
    class Program
    {
        static void Main(string[] args)

            // Enklaste sättet att skriva json
        {
            string jsonText = File.ReadAllText("Template.json");

            JToken json = JsonConvert.DeserializeObject<JToken>(jsonText);
        }
    }
}
