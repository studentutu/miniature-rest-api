using System;

namespace Weather.Domain
{
    public class Post
    {
        public string Id { get; set; }

        public Post(string id)
        {
            Id = id;
        }
    }
}