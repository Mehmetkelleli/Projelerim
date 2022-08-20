using Fashion.entity;
using System.Collections.Generic;
using System.Linq;

namespace Fashion.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItem> CardItems { get; set; }
        public double TotalPrice() {
            return this.CardItems.Sum(i => i.Quantity * i.Product.Price);
        } 
    }
}
