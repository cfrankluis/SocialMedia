using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaModels
{
    public class CommentDetails
    {
        public int CommentId { get; set; }

        [ForeignKey(nameof(PostId))]
        public int PostId { get; set; }
        [MaxLength(144)]
        public string Content { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public Guid AuthorId { get; set; }

    }
}
