/*
 Name: Zed Trzcinski
 Date: 1/27/2018
 Lab2
 
 */

using System.Web.Mvc;

namespace CST320_lab2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    
    }
}