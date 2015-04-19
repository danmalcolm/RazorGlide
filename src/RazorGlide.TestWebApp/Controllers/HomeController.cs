using System.Web.Mvc;

namespace RazorGlide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new EditorTestModel
            {
                Name = "Dan",
                Name2 = "Dan",
                Name3 = ""
            };
            ModelState.AddModelError("Name3", "Enter a value");
            return View(model);
        }
    }
}