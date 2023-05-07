using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Shubham_Dalvi.Models.Dto
{
    public class PersonallInfoViewModels
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]  
        public string Email { get; set; } = null!;

        public string? Message { get; set; }
    }
}
