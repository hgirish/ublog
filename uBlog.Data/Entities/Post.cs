using System;
using System.Collections.Generic;
using System.Text;

namespace uBlog.Data.Entities
{
   public class Post
    {
        public int Id { get; set; }

        /// <summary>
        /// Title of the post
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Short url slug of the post
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// Markdown content of the post
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Date and time post have been created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Post is publishen when this property is false
        /// </summary>
        public bool Draft { get; set; }
    }
}
