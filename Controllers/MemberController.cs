using Microsoft.AspNetCore.Mvc;

namespace HealthEquityMembers.Controllers
{
    [ApiController]
    [Route("[controller]/contact")]
    public class MemberController : ControllerBase
    {
        [HttpGet]
        [Route("id")]
        public void Get(int id)
        {
            
        }

        [HttpPost]
        public IActionResult PatchMember([FromBody] Member member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return null;
        }
    }
}