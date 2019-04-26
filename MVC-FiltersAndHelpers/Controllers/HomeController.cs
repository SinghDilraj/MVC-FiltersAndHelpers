using MVC_FiltersAndHelpers.Models;
using MVC_FiltersAndHelpers.Models.Filters;
using System.Web.Mvc;

namespace MVC_FiltersAndHelpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RequestFilter(Request.UserAgent, View());
        }

        public ActionResult Unauthorized()
        {
            return View();
        }

        private ActionResult RequestFilter(string userAgent, ViewResult view)
        {
            if(userAgent == "googlebot")
            {
                return RedirectToAction("Unauthorized");
            }
            else
            {
                return view();
            }
        }
    }
}