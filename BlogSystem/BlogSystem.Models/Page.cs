using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Page : ContentHolder
    {
        [Required]
        public string Permalink { get; set; }
    }
}
