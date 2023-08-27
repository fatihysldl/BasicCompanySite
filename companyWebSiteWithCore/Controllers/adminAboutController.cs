using businessLayer.concrete;
using dataAccessLayer.entityFramework;
using entityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace companyWebSiteWithCore.Controllers
{
    public class adminAboutController : Controller
    {
        aboutManager about = new aboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var values = about.list();
            return View(values);
        }
        [HttpGet]
        public IActionResult editAbout(int Id)
        {
            var value = about.GetId(Id);
            return View(value);
        }
        [HttpPost]
        public IActionResult editAbout(about p)
        {
            about.update(p);
            return RedirectToAction("Index");
        }
        public IActionResult deleteAbout(int Id)
        {
            var value = about.GetId(Id);
            about.delete(value);
            return RedirectToAction("Index");
        }
    }
}
