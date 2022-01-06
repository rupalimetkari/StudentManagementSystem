using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities;

namespace StudentManagementSystem.Controllers
{

    [Route("teachers")]
    public class TeacherController : Controller
    {
        
        // Create a new Teacher
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        //Get All Teacher
        [Route("getall")]
        public ActionResult GetAll()
        {
            return View();
        }

        //Get a Single Teacher
        [Route("getteacher/{id}")]
        public ActionResult GetTeacher(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        //Update a Teacher
        [Route("updateteacher/{id}")]
        public ActionResult UpdateTeacher(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        //Delete a Teacher
        [Route("deleteteacher/{id}")]
        public ActionResult DeleteTeacher(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
