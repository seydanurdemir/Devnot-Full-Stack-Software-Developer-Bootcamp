using introDotNetCoreWithMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var post = new Post { Title = "MVC Mimarisi Nedir?", Content = "Lorem ipsum dolor sit amet", Name = "Turkay Urkmez"};
            var comments = new List<Comment>
            {
                new Comment { Name = "Tosun", Context = "Guzel paylasim." },
                new Comment { Name = "Melih", Context = "Ayni viewde birden fazla islem nasil gosteririm" }
            };

            var model = new PostAndCommentsViewModel { Post = post, Comments = comments };

            return View(model);
        }

        [HttpPost]

        public IActionResult Index(Comment comment)
        {
            return View();
        }
    }
}
