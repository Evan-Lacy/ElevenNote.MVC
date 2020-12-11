using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(10, ErrorMessage = "Your title must be longer than 10 characters.")]
        [MaxLength(100, ErrorMessage ="Your title must be less than 100 characters.")]
        public string Title { get; set; }
        [MaxLength(5000)]
        public string Content { get; set; }
    }
}
