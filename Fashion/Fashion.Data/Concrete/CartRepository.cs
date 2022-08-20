using Fashion.Data.Abstract;
using Fashion.Data.Context;
using Fashion.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Concrete
{
    public class CartRepository : EfGenericRepository<Cart,ShopDataContext>, ICartRepository
    {
        
        public Cart GetCarts(string UserId)
        {
            using (var db = new ShopDataContext())
            {
                return db.Cart.Include(i => i.CartItems).ThenInclude(i => i.Product).FirstOrDefault(i => i.UserId == UserId) ;
            }
        }
        public override void Update(Cart T)
        {
            using (var db = new ShopDataContext())
            {
                db.Cart.Update(T);
                db.SaveChanges();
            }
        }

        public void InitializeCart(string UserId)
        {
            
        }

        public void DeleteFromCart(int CartId, int ProductId)
        {
            using (var db= new ShopDataContext())
            {
                var cart = db.Cart.Include(i=>i.CartItems).Where(i => i.Id == CartId).FirstOrDefault();
                var cartItems = cart.CartItems.FirstOrDefault(i => i.ProductId == ProductId);
                db.CartItems.Remove(cartItems);
                db.SaveChanges();
            }
        }
    }
}
