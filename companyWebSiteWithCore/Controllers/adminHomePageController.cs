using Microsoft.AspNetCore.Mvc;

namespace companyWebSiteWithCore.Controllers
{
    public class adminHomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
