using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_Sem7.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        [HttpGet]
        public IActionResult Display()
        {
            return Ok("ok");
        }
    }
}
