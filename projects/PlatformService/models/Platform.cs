using System.ComponentModel.DataAnnotations;

namespace PlatformService
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Publisher { get; set; }

        [Required]
        [MaxLength(50)]
        public string cost { get; set; }

    }
}