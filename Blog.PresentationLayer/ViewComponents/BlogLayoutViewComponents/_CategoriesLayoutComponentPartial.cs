using Blog.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.ViewComponents.BlogLayoutViewComponents
{
    public class _CategoriesLayoutComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoriesLayoutComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetAll().Take(3).ToList();
            return View(values);
        }
    }
}
