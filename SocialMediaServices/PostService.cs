using SocialMediaData;
using SocialMediaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaServices
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService (Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    AuthorId = model.AuthorId,
                    Title = model.Title,
                    Text = model.Text
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Posts
                        .Where(p => p.AuthorId == _userId)
                        .Select(
                            p =>
                                   new PostListItem
                                   {
                                       Id = p.Id,
                                       Title = p.Title
                                   }
                        );
                return query.ToArray();
            }
        }

    }
}
