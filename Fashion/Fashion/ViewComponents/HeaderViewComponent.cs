using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fashion.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private ISiteConfigRepository _SiteConfig;
        private ICartService _Cart;
        private UserManager<User> _User;
        public HeaderViewComponent(ISiteConfigRepository SiteConfig,ICartService Cart, UserManager<User> User)
        {
            _SiteConfig = SiteConfig;
            _Cart = Cart;
            _User = User;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if(User.Identity.Name != null)
            {
                var users = await _User.FindByNameAsync(User.Identity.Name);
                if (users != null)
                {
                    TempData["Cart"] = _Cart.GetCarts(users.Id);
                }
            }
            TempData["Social"] = _SiteConfig.GetById(3);
            return View(_SiteConfig.GetById(3));
        }
    }
}
