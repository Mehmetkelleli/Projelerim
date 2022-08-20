using myblog.Entity;
using System.Collections.Generic;

namespace myblog.model
{
    public class PostCategoriesViewModel
    {
        public List<Post> Posts { get; set; }
        public List<Category> Categories { get; set; }
    }
}
