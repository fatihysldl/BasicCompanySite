using businessLayer.concrete;
using dataAccessLayer.entityFramework;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace companyWebSiteWithCore.Controllers
{
    public class adminCompanyServicesController : Controller
    {
        companyServicesManager services =new companyServicesManager(new EfCompanyServicesDal());
        public IActionResult Index()
        {
            var values = services.list();
            return View(values);
        }
        [HttpGet]
        public IActionResult editservices(int Id)
        {
            var value = services.GetId(Id);
            return View(value);
        }
        [HttpPost]
        public IActionResult editservices(companyServices p)
        {
            services.update(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult insertservices()
        {
            return View();
        }
        [HttpPost]
        public IActionResult insertservices(companyServices p)
        {
            services.insert(p);
            return RedirectToAction("Index");
        }
        public IActionResult deleteservices(int Id)
        {
            var value = services.GetId(Id);
            services.delete(value);
            return RedirectToAction("Index");
        }
    }
}
