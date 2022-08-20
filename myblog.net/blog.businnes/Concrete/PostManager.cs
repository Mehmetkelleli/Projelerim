using blog.businnes.Abstract;
using blog.data.Abstract;
using blog.data.Concrete.EfCoreMysql;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class PostManager : IPostService
    {
        private IPostRepository _post;
        public PostManager(IPostRepository post)
        {
            _post = post;
        }
        public void create(Post t)
        {
            _post.create(t);
        }

        public Post GetById(int id)
        {
            return _post.GetById(id); 
        }

        public List<Post> GetList()
        {
            return _post.GetList();
        }

        public void update(Post t)
        {
            _post.update(t);
        }
        public void delete(int id)
        {
            _post.delete(id);
        }

        public List<Post> LastPost()
        {
            return _post.lastpost();
        }

        public List<Post> GetPosts(int? id)
        {
            return _post.GetPosts(id);
        }
        public Post GetByIdPost(int id)
        {
            return _post.GetByIdPost(id);
        }
    }
}
