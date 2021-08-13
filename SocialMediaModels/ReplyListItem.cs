using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaModels
{
    public class ReplyListItem
    {
        public int ReplyId { get; set; }
        
        [Display(Name ="Reply")]
        public string Text { get; set; }
    }
}
