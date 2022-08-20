using Fashion.entity;
using System.Collections.Generic;

namespace Fashion.ViewModel
{
    public class HomePageViewModel
    {
        public List<HomePageSlider> HomePageSliders { get; set; }
        public List<MainCategory> MainCategories { get; set; }
        public List<Product> Products { get; set; }
    }
}
