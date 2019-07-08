using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class ProductDetail
    {
        public int ProductDetailId { get; set; }

        public int CostPrice { get; set; }

        public  int SellingPrice { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public int? Voltage { get; set; }

        public string SmallImage { get; set; }

        public string MediumImage { get; set; }

        public string LargeImage { get; set; }

        public string ShortDescription { get; set; }

        public string Details { get; set; }

    }
}
