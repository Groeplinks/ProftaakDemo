using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Models
{
    public class DummyRepositoryPost
    {
        static List<IPost> _PostList = new List<IPost>
            {
               
            };       

        public static void Add(IPost post)
        {
            try { post.Id = _PostList.Max(e => e.Id) + 1;}
            catch { post.Id = 0; }
            
            _PostList.Add(post);
            Console.WriteLine( _PostList.Count);
        }

        public IPost Delete(int id)
        {
            IPost post = _PostList.FirstOrDefault(e => e.Id == id);
            if (post != null)
            {
                _PostList.Remove(post);
            }

            return post;
        }

        public static List<IPost> GetAllPost()
        {
            return _PostList;
        }

        public IPost GetPost(int Id)
        {
            return _PostList.FirstOrDefault(e => e.Id == Id);
        }

        public IPost Update(IPost postChanges)
        {
            IPost post = _PostList.FirstOrDefault(e => e.Id == postChanges.Id);
            if (post != null)
            {
                post.Author = postChanges.Author;
                post.Title = postChanges.Title;
                post.Description = postChanges.Description;
                post.Tag = postChanges.Tag;
            }

            return post;
        }
    }
}
