using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SocialMediaModels
{
    public class ReplyCreate
    {
        [Required]
        public int CommentId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")] 
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Text { get; set; }
    }
}
