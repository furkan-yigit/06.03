using Microsoft.AspNetCore.Mvc;

namespace uygulama.ViewComponents
{
    public class NavbarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
