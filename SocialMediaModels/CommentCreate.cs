using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaModels
{
    public class CommentCreate
    {
        [ForeignKey(nameof(PostId))]
        public int PostId { get; set; }
        [Required, MaxLength(144)]
        public string Text { get; set; }
       

    }
}
