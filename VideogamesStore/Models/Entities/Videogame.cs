using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VideogamesStore.Models.Base;

namespace VideogamesStore.Models.Entities
{
    public class Videogame : IHasId
    {
        public int Id { get; set; }
       
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        [Column(TypeName = "Date")]
        public DateTime? ReleaseDate { get; set; }

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
