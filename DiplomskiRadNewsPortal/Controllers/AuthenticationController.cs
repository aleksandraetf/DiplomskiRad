using Microsoft.AspNetCore.Mvc;
using NewsPortal.BusinessLogic.User;
using NewsPortal.BusinessLogic.User.Model;

namespace DiplomskiRadNewsPortal.Controllers
{
    [Route("api/login")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthenticationController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest("Username or password is incorrect");


            Response.Cookies.Append("token", response.Token);

            return Ok();
        }

    }
}
