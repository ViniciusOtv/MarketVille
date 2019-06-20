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

        public string Description { get; set; }

        public string CoverImage { get; set; }

        public string Image { get; set; }

        public int SupplierId { get; set; }

        public int LocationId { get; set; }
    }
}
