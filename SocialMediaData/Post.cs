using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaData
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Text  { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }

        [Required]
        public Guid AuthorId { get; set; }


    }
}
