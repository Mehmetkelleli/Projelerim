using System.Collections.Generic;

namespace myblog.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Post { get; set; }
    }
}
