using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakDemo.Models
{
    public class DummyRepositoryPost : IPostRepository
    {
        private List<Post> _PostList;

        public DummyRepositoryPost()
        {
            _PostList = new List<Post>()
            {
                new Post() {Id = 1, Author = "Daniel Brodowski", 
                            Title = "Dummy Titel Daniel", 
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged",  
                            Tag = "Tag Daniel"},
                new Post() {Id = 2, Author = "Ruben Zwinkels", 
                            Title = "Dummy Titel Ruben", 
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged",  
                            Tag = "Tag Ruben"},
                new Post() {Id = 3, Author = "Kris Verbakel", 
                            Title = "Dummy Titel Kris", 
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged",  
                            Tag = "Tag Kris"}   
            };
        }

        public Post Add(Post post)
        {
            post.Id = _PostList.Max(e => e.Id) + 1;
            _PostList.Add(post);
            return post;
        }

        public Post Delete(int id)
        {
            Post post = _PostList.FirstOrDefault(e => e.Id == id);
            if (post != null)
            {
                _PostList.Remove(post);
            }

            return post;
        }

        public IEnumerable<Post> GetAllPost()
        {
            return _PostList;
        }

        public Post GetPost(int Id)
        {
            return _PostList.FirstOrDefault(e => e.Id == Id);
        }

        public Post Update(Post postChanges)
        {
            Post post = _PostList.FirstOrDefault(e => e.Id == postChanges.Id);
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
