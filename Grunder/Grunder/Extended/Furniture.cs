using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Grunder
{
    // Klasser med nyckelordet 'abstract' kan ej skapa via new
    public abstract class Furniture
    {


        //public int WidthInMM { get; set; }
        //public int HeightInMM { get; set; }
        //public int DepthInMM { get; set; }

        public Dimensions Dimensions { get; set; }

        //public double Positionx { get; set; }
        //public double PositionY { get; set; }

        public Position Position { get; set; }

        // Publik Konstruktor
        public Furniture(int width, int height, int depth, int posX, int posY)
        {
            Dimensions = new Dimensions (width, height, depth);
            Position = new Position (posX, posY);

        }
        public Furniture(Dimensions dimensions, Position position)
        {
            Dimensions = dimensions;
            Position = position;
        }

    }
}