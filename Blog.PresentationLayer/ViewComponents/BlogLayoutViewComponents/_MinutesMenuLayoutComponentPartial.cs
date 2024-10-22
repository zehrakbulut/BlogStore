using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.ViewComponents.BlogLayoutViewComponents
{
    public class _MinutesMenuLayoutComponentPartial : ViewComponent
    {
        private readonly IRecipeService _recipeService;

        public _MinutesMenuLayoutComponentPartial(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _recipeService.TGetAll()
                .Where(x => x.Time ==new TimeSpan(0, 15, 0))  // Time değeri 00:15:00'dan küçük olanları filtreliyoruz.
                .Take(4)                                      // İlk 4 öğeyi alıyoruz.
                .ToList();

            return View(values);
        }
    }
}
