using StudyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyProject.interfaces
{
    public interface IAllPosts
    {
        IEnumerable<Post> Posts { get; }
        Post getPost(int id); 
    }
}
