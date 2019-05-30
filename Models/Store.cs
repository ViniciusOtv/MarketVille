using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string Name { get; set; }

        public List<Product> ProductId { get; set; }

        public int SupplierId { get; set; }
    }
}
