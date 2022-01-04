using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities;

namespace StudentManagementSystem.Controllers
{
    [Route("courses")]

    public class CourseController : Controller
    {


        //Create a New Course
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        //Get All Courses
        [Route("getall")]
        public ActionResult GetAll()
        {
            return View();
        }

        //Get a Single Course
        [Route("getcourse/{id}")]
        public ActionResult Getcourse(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        //Update a course
        [Route("updatecourse/{id}")]
        public ActionResult Updatecourse(int id)
        {
            ViewBag.ID = id;
            return View();
        }

        //Delete a course
        [Route("deletecourse/{id}")]
        public ActionResult Deletecourse(int id)
        {
            ViewBag.ID = id;
            return View();
        }


    }

}
