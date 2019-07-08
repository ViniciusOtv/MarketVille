using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class CartItem
    {
        private int cartItemId;
        public int CardItemId
        {
            get { return cartItemId; }
            set { cartItemId = value; }
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { productId = value; }
        }
        public CartItem(
            int productId)
        {
            this.ProductId = productId;
        }

    }
}