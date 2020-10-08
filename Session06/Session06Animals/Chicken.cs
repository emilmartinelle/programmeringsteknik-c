using System;
using System.Collections.Generic;
using System.Text;

namespace Session06Konstruktor

    // Ett sätt att ge en färdig bas till en egem class där det delar egenskaper som finns i bas-classen.
    // Ett smidigare sätt utan att behöva skriva all kod till varje class
    // I detta fall är Animal bas-classen med olika egenskaper som sedan Chicken-classen använder, plus lägger till sina -
    // - egna unika egenskaper.

{
    class Chicken : Animal, IBarnyardAnimal // 'class ... : "Abstrakta basklassen"'
    {
        public string RestingArea => throw new NotImplementedException();

        private string _feedingArea;


        public string RestingArea => _restingArea 

        public string FeedingArea
        {
            get
            {
                return _feedingArea;
            }
            set
            {
                _feedingArea = value;
            }
        }
           

        public override void EatFood()
        {

        //   throw new NotImplementedException(); // Ett fel som visas om koden inte är klar
        /* Implementation av metoden */
        /* Fyller metoden med logik */
        }
    }
}
