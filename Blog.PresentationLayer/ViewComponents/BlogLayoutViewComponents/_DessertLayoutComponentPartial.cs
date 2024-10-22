using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class _DessertLayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
