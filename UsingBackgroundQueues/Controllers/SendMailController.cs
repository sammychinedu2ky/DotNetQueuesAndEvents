using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using UsingBackgroundQueues.LongRunning;

namespace UsingBackgroundQueues.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMailController : ControllerBase
    {
        private readonly Channel<int> _queue;
      

        public SendMailController(BackgroundQueue queue)
        {
            _queue = queue.Queue;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<string>> sendMail(int userId)
        {
            await _queue.Writer.WriteAsync(userId);
            return  "email will be sent controller 1";
          
        }
    }
}
