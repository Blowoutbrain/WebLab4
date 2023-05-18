using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}