
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
            ViewBag.ID = id;
            return View();
        }

        //Update a student
        [Route("updatestudent/{id}")]
        public ActionResult UpdateStudent(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        //Delete a student
        [Route("deletestudent/{id}")]
        public ActionResult DeleteStudent(int id)
        {
            ViewBag.ID = id;
            return View();
        }


        [Route("index")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("SessionKeyUserType") == null)
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.currstdid = HttpContext.Session.GetInt32("SessionKeyId");
            ViewBag.currstdactive = HttpContext.Session.GetInt32("SessionKeyActive");
            ViewBag.currstdusertype = HttpContext.Session.GetInt32("SessionKeyUserType");
            ViewBag.currstdfname = HttpContext.Session.GetString("SessionKeyFname");
            ViewBag.currstdlname = HttpContext.Session.GetString("SessionKeyLname");
            ViewBag.currstdemail = HttpContext.Session.GetString("SessionKeyEmail");
            ViewBag.currstdpassword = HttpContext.Session.GetString("SessionKeypassword");
            ViewBag.currstdphone = HttpContext.Session.GetString("SessionKeyphone");
            return View();
        }
     

    }
    
}
