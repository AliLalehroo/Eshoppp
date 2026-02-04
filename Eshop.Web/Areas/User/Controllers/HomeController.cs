using Eshop.Application.Services.Interfaces;
using Eshop.Web.UserExtensions;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Dashboard()
        {
            var model = await _userService.UserDashboardDetail(User.GetUserId());
            return View(model);
        }
    }
}
