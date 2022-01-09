
using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


/// <summary>
/// This Student View Controller
/// </summary>
namespace StudentManagementSystem.Controllers
{

    [Route("students")]
    public class StudentsController : Controller
    {
        
        // Create a new student
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        //Get All Students
        [Route("getall")]
        public ActionResult GetAll()
        {
             return View();
        }

        //Get a Single Student
        [Route("getstudent/{id}")]
        public ActionResult GetStudent(int id)
        {
           
            return View();
        }

        //Update a student
        [Route("updatestudent/{id}")]
        public ActionResult UpdateStudent(int id)
        {
           
            return View();
        }

        //Delete a student
        [Route("deletestudent/{id}")]
        public ActionResult DeleteStudent(int id)
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
     

    }
    
}
