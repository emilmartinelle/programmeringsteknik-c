using System;

namespace Session06Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffee.DefaultBeanType;

            Animal myAnimal = new Chicken();
            Chicken myChicken = new Chicken(); // Samma sak som ovan
            myAnimal = new Cow();

            // Tvingad datakonvertering
            // Genrerar InvalidCastException
            Cow myCow = (Cow)myAnimal;

            // Säker datakonvertering
            // Blir null om det inte går att konvertera
            myCow = myAnimal as Cow;

            IBarnyardAnimal barnyardAnimal = new Chicken();
            myBarnyardAnimal.FeedingArea = "Main yard";
            // myBarnyardAnimal.RestingArea="Går inte";

            myAnimal= (Animal)myBarnyardAnimal;
        }
    }
}
