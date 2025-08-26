using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.ViewComponents.BlogsViewComponents
{
    public class _BlogDetailsRecentBlogsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View();
           }

    }
}
