using System;

namespace Covid_19_Tracking.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Heading { get; set; }
        public DateTime DateTime { get; set; }
        public string Link { get; set; }
    }
}