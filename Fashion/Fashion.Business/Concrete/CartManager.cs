using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _Cart;
        public CartManager(ICartRepository Cart)
        {
            _Cart = Cart;
        }

        public void AddCartItem(string UserId, int ProductId, int Quantity)
        {
            var Carts = _Cart.GetCarts(UserId);
            if(Carts != null)
            {
                //iki işlem yapılacak aynı urun varsa yoksa
                var item = Carts.CartItems.Where(i=>i.ProductId == ProductId).FirstOrDefault();
                if(item != null)
                {
                    item.Quantity++;
                }
                else
                {
                    Carts.CartItems.Add(new CartItem()
                    {
                        ProductId = ProductId,
                        Quantity = Quantity,
                        CartId = Carts.Id
                    });
                    
                }
                _Cart.Update(Carts);
            }
        }

        public void DeleteFromCart(int CartId, int ProductId)
        {
            
            _Cart.DeleteFromCart(CartId, ProductId);
        }

        public Cart GetCarts(string UserId)
        {
           return _Cart.GetCarts(UserId);
        }

        public void InitializeCart(string UserId)
        {
            _Cart.Create(new entity.Cart { UserId = UserId });
        }
    }
}
