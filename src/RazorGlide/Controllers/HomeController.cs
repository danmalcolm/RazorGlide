using System.Web.Mvc;

namespace RazorGlide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new TestModel
            {
                Name = "Dan"
            };
            return View(model);
        }
    }
}