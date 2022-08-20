using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Abstract
{
    public interface ICartRepository:IGenericRepository<Cart>
    {
        void InitializeCart(string UserId);
        Cart GetCarts(string UserId);
        void DeleteFromCart(int CartId, int ProductId);
    }
}
