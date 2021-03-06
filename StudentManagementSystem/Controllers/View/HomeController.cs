using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers.View
{
    [Route("/")]
    public class HomeController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == 1)
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (HttpContext.Session.GetInt32("SessionKeyUserType") == 2)
            {
                return RedirectToAction("Index", "Teacher");
            }
            else if (HttpContext.Session.GetInt32("SessionKeyUserType") == 3)
            {
                return RedirectToAction("Index", "Students");
            }
            return View();
        }

        [Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("profile")]
        public IActionResult Profile()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == 1)
            {
                return RedirectToAction("Profile", "Admin");
            }
            else if (HttpContext.Session.GetInt32("SessionKeyUserType") == 2)
            {
                return RedirectToAction("Profile", "Teacher");
            }
            else if (HttpContext.Session.GetInt32("SessionKeyUserType") == 3)
            {
               return RedirectToAction( "Profile", "Students");
            }
            return View();
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("login")]
        public IActionResult Login()
        {

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();   
            return RedirectToAction("Login");
        }

    }
}
 
