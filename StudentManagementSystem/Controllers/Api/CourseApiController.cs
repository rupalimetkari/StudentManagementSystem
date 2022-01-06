using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Entities;

namespace StudentManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class CourseApiController : Controller
    {
        private readonly ICourseRepository _courseRepo;
        public CourseApiController(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }



        //Create a New Course
        [HttpPost("createcourse")]
        public IActionResult CreateCourse(Course course)
        {
            try
            {
                 _courseRepo.CreateCourse(course);
               
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return Ok();
        }

        //Get All Course
        [HttpGet("getallcourse")]
        public async Task<IActionResult> GetallCourse()
        {
            try
            {
                var Course = await _courseRepo.GetCourse();
                return Ok(Course);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get a Single Course
        [HttpGet("getcourse/{id}")]
        public async Task<IActionResult> GetCourse(int id)
        {
            try
            {
                var Course = await _courseRepo.GetViewCourse(id);
                if (Course == null)
                    return NotFound();
                return Ok(Course);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        //Update a Course
        [HttpPut("updatecourse/{id}")]
        public async Task<IActionResult> updateCourse(int id, Course course)
        {
            try
            {
                await _courseRepo.UpdateCourse(id, course);
                return Ok();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        //Delete a Course
        [HttpDelete("deletecourse/{id}")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            try
            {
                await _courseRepo.DeleteCourse(id);
                return Ok();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
