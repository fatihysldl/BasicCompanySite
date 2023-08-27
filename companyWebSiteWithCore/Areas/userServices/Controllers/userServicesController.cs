using businessLayer.concrete;
using dataAccessLayer.entityFramework;
using Microsoft.AspNetCore.Mvc;

namespace companyWebSiteWithCore.Areas.userAbout.Controllers
{
    [Area("userServices")]

    public class userServicesController : Controller
    {
        companyServicesManager services = new companyServicesManager(new EfCompanyServicesDal());
        public IActionResult Index()
        {
            var values=services.list();
            return View(values);
        }
    }
}
