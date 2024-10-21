using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.Controllers
{
    public class UIDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
