using Fashion.Business.Abstract;
using Fashion.Business.Concrete;
using Fashion.Identity;
using Fashion.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Controllers
{
    public class CartController : Controller
    {
        private ICartService _Cart;
        private UserManager<User> _User;
        public CartController(ICartService Cart, UserManager<User> User)
        {
            _Cart = Cart;
            _User = User;
        }
        public async Task<IActionResult> Index()
        {
            var user =await _User.FindByNameAsync(User.Identity.Name);

            if(user == null)
            {
                return RedirectToAction("index", "Home");
            }
            var cart = _Cart.GetCarts(user.Id);
            CartModel cartmodel = new CartModel()
            {
                CartId = cart.Id,
                CardItems = cart.CartItems 
            };
            return View(cartmodel);
        }
        [HttpPost]
        public async Task<IActionResult> AddCart(int ProductId,int Quantity)
        {
            var user =await _User.FindByNameAsync(User.Identity.Name);
            _Cart.AddCartItem(user.Id, ProductId, Quantity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCart(int id)
        {
            var user =await _User.FindByNameAsync(User.Identity.Name);
            var cart = _Cart.GetCarts(user.Id);
            Console.WriteLine(id);
            _Cart.DeleteFromCart(cart.Id, id);

           return RedirectToAction("index");
        }

    }
}
