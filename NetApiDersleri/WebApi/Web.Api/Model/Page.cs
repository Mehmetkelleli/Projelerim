using System;

namespace Web.Api.Model
{
    public class Page
    {
        public  int TotalItem;
        public  int CurrentPage;
        public string CurrentCategory;
        public  int PageSize;
        public int TotalPage { get; set; }
        public Page(int TotalItem,int CurrentPage,string CurrentCategory,int PageSize)
        {
            this.TotalItem = TotalItem;
            this.CurrentPage = CurrentPage;
            this.CurrentCategory = CurrentCategory;
            this.PageSize = PageSize;
            this.TotalPage = (int)Math.Ceiling((decimal)TotalItem / PageSize);
        }
    }
}
