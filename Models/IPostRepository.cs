using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Models
{
    public interface IPostRepository
    {
        Post GetPost(int Id);
        List<Post> GetAllPost();
        void Add(Post post);
        Post Update(Post postChanges);
        Post Delete(int id);
    }
}
