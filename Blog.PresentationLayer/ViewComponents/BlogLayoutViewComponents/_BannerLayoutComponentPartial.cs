using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.ViewComponents.BlogLayoutViewComponents
{
    public class _BannerLayoutComponentPartial:ViewComponent
    {
        private readonly IRecipeService _recipeService;  //veritabanına bağlanma anahtarı

        public _BannerLayoutComponentPartial(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _recipeService.TGetAll().Take(3).ToList();
            return View(values);
        }
    }
}
