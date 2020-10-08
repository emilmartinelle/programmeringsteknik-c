using System;
using System.Collections.Generic;
using System.Text;

namespace Session06Konstruktor
{
    abstract class Animal
    {
        // Abstrakt metoddefinition
        public abstract void EatFood(); // Blir void då den inte har någon metod / instruktion

        // Konkret metoddefinition
        public void Breed()
        {
            /* This implementation does nothing */
        }
    }
}
