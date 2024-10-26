using Microsoft.AspNetCore.Mvc;

namespace TaskDemo.Controllers
{
    public class DashboardController : Controller
    {
        // GET: DashboardController
        public ActionResult Index()
        {
            return View();
        }

    }
}
