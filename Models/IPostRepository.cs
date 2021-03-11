using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Models
{
    public interface IPostRepository
    {
        Post GetPost(int Id);
        IEnumerable<Post> GetAllPost();
        Post Add(Post post);
        Post Update(Post postChanges);
        Post Delete(int id);
    }
}
