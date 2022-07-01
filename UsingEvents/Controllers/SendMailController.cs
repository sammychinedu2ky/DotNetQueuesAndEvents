using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsingEvents.LongRunning;

namespace UsingEvents.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMailController : ControllerBase
    {
        private IPublisher _publisher;

        public SendMailController(IPublisher publisher)
        {
            _publisher = publisher;
        }

        [HttpGet("{userId}")]
        public ActionResult<string> sendMail(int userId)
        {
            _publisher.SendMail(userId);
            return "email will be sent controller 2";
          
        }
    }
}
