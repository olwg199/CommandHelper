using System.ComponentModel.DataAnnotations;

namespace CommandHelper.DTOs
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }

        [Required]
        public string CMDSnippet { get; set; }

        [Required]
        [MaxLength(100)]
        public string Platform { get; set; }
    }
}
