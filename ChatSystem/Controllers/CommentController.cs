using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using ChatSystem.Hubs;

namespace ChatSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IHubContext<CommentHub> _commentHub;

        public CommentController(IHubContext<CommentHub> commentHub)
        {
            _commentHub = commentHub;
        }

        [HttpPost]
        public async Task<IActionResult> Create(MessagePost messagePost)
        {
            await _commentHub.Clients.All.SendAsync("SendToReact", "The Message" + messagePost.Message + "Has been recieved");

            return Ok();
        }

        public class MessagePost
        {
            public virtual string Message { get; set; }
        }

    }
}
