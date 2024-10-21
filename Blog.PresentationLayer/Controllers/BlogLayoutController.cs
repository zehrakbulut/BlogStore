using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.Controllers
{
    public class BlogLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
