using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsTagCloudComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           return View();
        }
    }
}
