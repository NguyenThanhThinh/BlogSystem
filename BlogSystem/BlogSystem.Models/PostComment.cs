using BlogSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class PostComment : DeletableEntity
    {
        public PostComment()
        {
            this.IsVisible = true;
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Content { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }

        [Required]
        public string UserId { get; set; }

        public AppUser User { get; set; }

        public bool IsVisible { get; set; }
    }
}
