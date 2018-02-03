/*
 Name: Zed Trzcinski
 Date: 1/27/2018
 Lab2
 
 */


using System.Linq;
using System.Web.Mvc;
using CST320_lab2.Data.Entities;
using CST320_lab2.Data;

namespace CST320_lab2.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid) { 
            //check if the user already exists
            foreach (var item in DataBase.users)
            {
                if (user.FirstName == DataBase.users.FirstOrDefault().FirstName
                    && user.LastName == DataBase.users.FirstOrDefault().LastName)
                {
                    ModelState.AddModelError("FirstName", "the name already exist");
                    return View(user);


                }
            }
            }
            
            user.UserId = DataBase.NextId();
            DataBase.users.Add(user);

            return RedirectToAction("Index");
        }
      
        // GET: User
        public ActionResult Index()
        {
            var data = DataBase.users;
            return View(data);
        }
       
        public ActionResult List()
        {
            var data = DataBase.users;
            return View(data);
        }
    }
}