using BlogSystem.Common;
using BlogSystem.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Video : DeletableEntity
    {
        public int Id { get; set; }

        [Required]
        public string VideoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public VideoProvider Provider { get; set; }
    }
}
