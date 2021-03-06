using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaData
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        public virtual List<Reply> Reply { get; set; }
        [ForeignKey(nameof(PostId))]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
