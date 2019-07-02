using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarktVille.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Itens;

        public Cart()
        {
            Itens = new Dictionary<int, CartItem>();
        }

        public void AddItem(Product product)
        {
            if (Itens.ContainsKey(product.ProductId))
            {
                Itens[product.ProductId].Quantity++;
            }
            else
            {
                var cardItem = new CartItem(product.ProductId,
                    product.Name,
                    product.Price);

                Itens.Add(product.ProductId, cardItem);
            }
        }

        public void Decrement(int id)
        {
            Itens[id].Quantity--;

            if (Itens[id].Quantity <= 0)
            {
                Delete(id);
            }
        }

        public void Delete(int id)
        {
            Itens.Remove(id);
        }

        public int QuantityItens => Itens.Values.Sum(item => item.Quantity);


        public void CleanItens()
        {
            Itens.Clear();
        }

        public decimal GetTotalPrice()
        {
            decimal result = 0;
            foreach (var item in Itens.Values)
            {
                result += item.TotalPrice;
            }

            return result;
        }
    }
}
