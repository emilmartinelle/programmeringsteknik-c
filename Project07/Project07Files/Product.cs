using System;
using System.Collections.Generic;
using System.Text;

namespace Project07Files
{
    class Product
    {
        public int Id {get; set; }
        public string ProuctNumber { get; set; }
        public string ProductName { get; set; }
        public int? ProductBrand { get; set; }
        public string ProductSupplier { get; set; }
        public string[] ProductSynonyms { get; set; }

    }
}
