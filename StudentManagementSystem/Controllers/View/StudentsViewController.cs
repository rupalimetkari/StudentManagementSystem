
using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


/// <summary>
/// This Student View Controller
/// </summary>
namespace StudentManagementSystem.Controllers
{

    [Route("students")]
    public class StudentsViewController : Controller
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
     

    }
    
}
