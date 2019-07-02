using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class CartItem
    {
        public int CardItemId { get; set; }

        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public CartItem(
            int productId, 
            string name, 
            decimal unitPrice)
        {
            this.ProductId = productId;
            this.Name = name;
            this.UnitPrice = unitPrice;
        }

        public decimal TotalPrice =>
            UnitPrice * Quantity;

    }
}