using System;
using System.Web;
using System.Web.Mvc;

namespace PortfolioPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public PartialViewResult _Tictactoe()
        {
            return PartialView("_Tictactoe");
        }
        public PartialViewResult _ContactForm()
        {
            return PartialView("_ContactForm");
        }
        
        
    }
}