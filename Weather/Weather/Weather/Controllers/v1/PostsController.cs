using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Weather.Contracts;
using Weather.Domain;

namespace Weather.Controllers
{
    public class PostsController : Controller
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post(Guid.NewGuid().ToString()));
            }
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}