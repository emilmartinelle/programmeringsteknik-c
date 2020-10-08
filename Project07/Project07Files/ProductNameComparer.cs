using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Project07Files
{
    class ProductNameComparer : IComparer<Product>
    {
        public int Compare([NotNull] Product x, [NotNull] Product y)
        {
            // Enklet sätt att använda underliggande egenskaper
            return x.ProductName.CompareTo(y.ProductName);
        }
    }
}
