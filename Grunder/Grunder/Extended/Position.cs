using System;
using System.Collections.Generic;
using System.Text;

namespace Grunder
{
    // Värdetyp via struct
    public struct Position
    {
        public readonly double X;
        public readonly double Y;

        public Position(double x, double y)
        {
            X = x;

            Y = y;
        }
    }
}
