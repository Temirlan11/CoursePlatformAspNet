using StudyProject.interfaces;
using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.mocks
{
    public class MockPost : IAllPosts
    {
        private readonly IAllPosts _allPosts = new MockPost();
        public IEnumerable<Post> Posts {
            get
            {
                return new List<Post>
                {
                    new Post{title = "AB", text = "ABC", img = "picture", author = "Oyazbayev Temirlan"},
                    new Post{title = "Ho", text = "Hey", img = "picture", author = "Nurpeissova Assem"}
                };
            }
        }

        public Post getPost(int id)
        {
            throw new NotImplementedException();
        }
    }
}
