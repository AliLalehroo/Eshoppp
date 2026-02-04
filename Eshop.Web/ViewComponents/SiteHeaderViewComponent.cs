using Eshop.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.ViewComponents
{
    public class SiteHeaderViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public SiteHeaderViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewData["Categories"] = await _categoryService.GetAllActiveCategories();
            return View("SiteHeader");
        }
    }
}
