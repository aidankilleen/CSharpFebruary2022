using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserDaoLibrary;

namespace WebApplicationHelloWorld
{
    public class UserController : Controller
    {
        private UserDao dao = new UserDao();

        public IActionResult Index()
        {
            // 
            List<User> users = dao.GetUsers();

            // TODO send the users to the View...
            ViewBag.message = "User List";
            ViewBag.users = users;

            return View();
        }
    }
}
