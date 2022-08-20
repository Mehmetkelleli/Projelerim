using blog.data.Abstract;
using Microsoft.EntityFrameworkCore;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.data.Concrete.EfCoreMysql
{
    public class EfPostRepository :
        EfCoreGenericRepository<Post, MyBlogContext>, IPostRepository
    {
        public Post GetByIdPost(int id)
        {
            using (var db = new MyBlogContext())
            {
                return db.Posts.FirstOrDefault(i => i.Id == id);
            }
        }

        public List<Post> GetPosts(int? id)
        {
            using (var db = new MyBlogContext())
            {
                if(id!=null)
                {
                    return db.Posts.Where(i=>i.CategoryId==id).Include(i => i.Category).ToList();

                }
                return db.Posts.Include(i => i.Category).ToList();

            }
        }

        public List<Post> lastpost()
        {
            throw new NotImplementedException();
        }
    }
}
