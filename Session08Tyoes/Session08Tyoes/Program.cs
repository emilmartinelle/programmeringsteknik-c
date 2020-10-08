using System;
using System.Collections;
using System.Collections.Generic;

namespace Session08Tyoes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Utvärderas när man kompilerar
            Type myStringType = typeof(string);

            // Utvärderar om man kör programmet, till för när man inte vet datatypen
            Type myStringTypeViaReflection = myStringType.GetType();
       

            // Jämföra omdet är samma datatyp
            if (myStringType==myStringTypeViaReflection)
            {

            }

            if (myStringTypeViaReflection.IsAssignableFrom(myStringType))
            {

            }

            List<string> myStringList = new List<string>();
            string[] myStringArray = new string[0];

            // Boxing
            IEnumerable<string> myEnumerable = myStringList;

            // Unboxing via casting till fel datatyp orsakar InvalidCastException
            // myStringList= (List<string>)myEnumerable

            // Unboxing via as blir null om datatypen är felaktig
            myStringList = myEnumerable as List<string>;

            // Här återställer vi till korrekta värden
            myEnumerable = myStringList;

            // Patetrn matching kan användas för att kontrollera om en variabel är av en viss typ 
            if (myEnumerable is List<string> myStringListPatternMatched)
            {
                myStringListPatternMatched.Add("added value");
            }

            //Går även att jämföra utan tilldelning
            if (myEnumerable is List<string>)
                    {
                // I sådant fall kan man exekvera annan logik tex.
            }

            Console.WriteLine(myEnumerable);
            Console.ReadLine();
        }
    }
}
