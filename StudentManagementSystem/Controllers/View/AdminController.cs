using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace StudentManagementSystem.Controllers.View
{
    [Route("admin")]
    public class AdminController : Controller
    {

        // Create a new student
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        //Get a Single Admin
        [Route("getadmin/{id}")]
        public ActionResult GetAdmin(int id)
        {

            return View();
        }

        [Route("index")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [Route("profile")]
        public IActionResult Profile()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }


        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [Route("getstudent/{id}")]
        public IActionResult GetStudent()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [Route("GetAllTeachers")]
        public IActionResult GetAllTeachers()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        //Update a admin
        [Route("updateadmin/{id}")]
        public ActionResult UpdateAdmin(int id)
        {

            return View();
        }

        [Route("GetAllCourses")]
        public IActionResult GetAllCourses()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }

        [Route("CreateCourse")]
        public IActionResult CreateCourse()
        {
            if (HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }

            return View();
        }


    }
}
