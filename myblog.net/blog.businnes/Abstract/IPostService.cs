using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface IPostService
    {
        void create(Post t);
        void update(Post t);
        Post GetById(int id);
        List<Post> GetList();
        void delete(int id);
        List<Post> LastPost();
        List<Post> GetPosts(int? id);
        Post GetByIdPost(int id);

    }
}
