﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public int SupplierId { get; set;  }

        public int StoreId { get; set; }

        public int CategoriyId { get; set; }

        public int SubCategoryId { get; set; }
        
    }
}
