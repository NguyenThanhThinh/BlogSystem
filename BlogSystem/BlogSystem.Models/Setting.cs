using System.ComponentModel.DataAnnotations;

namespace BlogSystem.Models
{
    public class Setting
    {
        [Key]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Value { get; set; }
    }
}
