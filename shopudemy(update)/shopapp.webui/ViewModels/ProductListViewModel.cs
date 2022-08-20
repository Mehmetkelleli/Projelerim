using System.Collections.Generic;
using shopapp.entity;
using shopapp.webui.Models;

namespace shopapp.webui.ViewModels
{
    public class ProductListViewModel
    {
        public page PageInfo { get; set; }
        public List<shopapp.entity.Product> Products { get; set; }
    }
}