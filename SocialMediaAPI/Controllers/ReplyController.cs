using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel.DataAnnotations;
using SocialMediaServices;
using SocialMediaModels;
using Microsoft.AspNet.Identity;

namespace SocialMediaAPI.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {
        public IHttpActionResult Get(int id)
        {
            ReplyService replyService = CreateReplyService();
            var replies = replyService.GetRepliesByCommentId(id);
            return Ok(replies);
        }

        public IHttpActionResult Post(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();

            return Ok();
        }

        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(userId);
            return replyService;
        }
    }
}
