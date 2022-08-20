using System;

namespace Fashion.Models
{
    public class Page
    {
        public int TotalItem { get; set; }
        public int PageSize { get; set; }
        public string CurrentCategory { get; set; }
        public int CurrentPage { get; set; }
        public int CurrentMinPrice;
        public int CurrentMaxPrice;
        public int CurrentColor;
        public  int TotalPage() {
            return (int)Math.Ceiling((decimal)TotalItem / PageSize);
        } 
    }
}
