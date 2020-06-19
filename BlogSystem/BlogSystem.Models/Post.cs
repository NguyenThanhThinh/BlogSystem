using BlogSystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogSystem.Models
{
    public class Post : ContentHolder
    {
        [Required]
        [DataType(DataType.Html)]
        public string ShortContent { get; set; }

        [Required]
        public string ImageOrVideoUrl { get; set; }

        public PostType Type { get; set; }

        public ICollection<PostComment> Comments { get; set; } = new HashSet<PostComment>();
    }
}
