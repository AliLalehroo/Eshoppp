using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.ViewComponents
{
    public class SiteFooterViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SiteFooter");
        }
    }
}
