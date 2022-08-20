using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Abstract
{
    public interface IPostRepository:IGenericRepository<Post>
    {
        List<Post> lastpost();
        List<Post> GetPosts(int? id);
        Post GetByIdPost(int id);
    }
}
