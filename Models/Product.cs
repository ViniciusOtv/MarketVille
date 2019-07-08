using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int? CostPrice { get; set; }

        public int SellingPrice { get; set; }

        public string Color { get; set; }

        public string Size { get; set; }

        public int? Voltage { get; set; }

        public string SmallImage { get; set; }

        public string MediumImage { get; set; }

        public string LargeImage { get; set; }

        public string ShortDescription { get; set; }

        public string Details { get; set; }

        public string Image { get; set; }

        public int? SupplierId { get; set;  }

        public int StoreId { get; set; }

        public int CategoriyId { get; set; }

        public int SubCategoryId { get; set; }
        
    }
}
