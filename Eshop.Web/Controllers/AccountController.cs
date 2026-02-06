using System.Data;
using System.Security.Claims;
using Eshop.Application.Services.Interfaces;
using Eshop.Data.DTOs.Account;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AccountController : SiteBaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("login")]
        [HttpGet("register")]
        public IActionResult AuthUiPlaceholder()
        {
            return StatusCode(StatusCodes.Status501NotImplemented, new
            {
                message = "Authentication UI is intentionally removed. Use API endpoints: POST /api/auth/register and POST /api/auth/login."
            });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO dto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            try
            {
                await _userService.RegisterUser(dto);
            }
            catch (DuplicateNameException)
            {
                return Conflict(new { message = "A user with this email already exists." });
            }

            return Ok(new { message = "User registered successfully." });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto dto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var user = await _userService.AuthenticateUser(dto);
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password." });
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal, new AuthenticationProperties { IsPersistent = true });

            return Ok(new { message = "Login successful." });
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Ok(new { message = "Logged out successfully." });
        }
    }
}
