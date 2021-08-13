using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaModels
{
    public class PostCreate
    {
        [Required]
        [MinLength(2,ErrorMessage = "Please enter a minumum of 2 characters")]
        [MaxLength(100, ErrorMessage = "Title should be 100 characters or less")]
        public string Title { get; set; }
        [MaxLength(8000)]
        public string Text { get; set; }
        public Guid AuthorId { get; set; }
    }


    
}
