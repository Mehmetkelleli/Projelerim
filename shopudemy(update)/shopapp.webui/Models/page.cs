using System;

namespace shopapp.webui.Models
{
    public class page
    {
        public int TotalItem { get; set; }
        public int  ItemsPerPage{ get; set; }
        public int CurrentPage { get; set; }
        public string CurretCategory { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItem / ItemsPerPage);
        }
    }
}
