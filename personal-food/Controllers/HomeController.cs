using System.Web.Mvc;

namespace personal_food.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
    }
}