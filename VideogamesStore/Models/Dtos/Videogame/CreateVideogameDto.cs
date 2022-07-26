using System.ComponentModel.DataAnnotations;

namespace VideogamesStore.Models.Dtos
{
    public class CreateVideogameDto
    {
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required]
        public bool Released { get; set; }

        [Required]
        [MaxLength(80)]
        public string Developer { get; set; }

        [Required]
        [MaxLength(120)]
        public string Platforms { get; set; }
    }
}
