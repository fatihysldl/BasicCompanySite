using Microsoft.AspNetCore.Mvc;

namespace companyWebSiteWithCore.Areas.userLayoutPartials.Controllers
{
    [Area("userLayoutPartials")]
    public class userLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult userHeaderPartial()
        {
            return PartialView();
        }
    }
}
