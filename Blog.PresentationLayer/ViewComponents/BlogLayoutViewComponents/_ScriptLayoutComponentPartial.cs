﻿using Microsoft.AspNetCore.Mvc;

namespace Blog.PresentationLayer.ViewComponents.BlogLayoutViewComponents
{
    public class _ScriptLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
