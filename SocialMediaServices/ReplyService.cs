using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialMediaData;
using SocialMediaModels;

namespace SocialMediaServices
{
    public class ReplyService
    {
        private readonly Guid _authorId;

        public ReplyService(Guid authorId)
        {
            _authorId = authorId;
        }

        public bool CreateReply(ReplyCreate model)
        {
            var entity =
                new Reply()
                {
                    AuthorId = _authorId,
                    CommentId = model.CommentId,
                    Text = model.Text
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Reply.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }

        public IEnumerable<ReplyListItem> GetRepliesByCommentId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Reply
                        .Where(e => e.CommentId == id)
                        .Select(
                            e =>
                                new ReplyListItem()
                                {
                                    ReplyId = e.ReplyId,
                                    Text = e.Text
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
