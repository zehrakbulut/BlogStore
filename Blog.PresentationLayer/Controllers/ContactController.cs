using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
