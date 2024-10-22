using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.ViewComponents.BlogLayoutViewComponents
{
    public class _RecipesLayoutComponentPartial:ViewComponent
    {
        private readonly IRecipeService _recipeService;

        public _RecipesLayoutComponentPartial(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _recipeService.TGetAll()
                .Where(x => x.CategoryId == 4)   // CategoryId = 1 olanları filtreliyoruz.
                .Take(4)                         // İlk 4 öğeyi alıyoruz.
                .ToList();

            return View(values);
        }
    }
}
