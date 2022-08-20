using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string UserId);
        Cart GetCarts(string UserId);
        void AddCartItem(string UserId, int ProductId, int Quantity);
        void DeleteFromCart(int CartId, int ProductId);
    }
}
