using System;
using System.Collections.Generic;

namespace BlogItla.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string PostBody { get; set; }
        public DateTime? PostDate { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
