using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Dto;

namespace StudentManagementSystem.Controllers
{
    [Route("api/course")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepo;
        public CourseController(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        //Create a New Course
        [HttpPost("createCourse")]
        public async Task<IActionResult> CreateCourse(CourseForCreationDto course)
        {
            try
            {
                var createdCourse = await _courseRepo.CreateCourse(course);
                return CreatedAtRoute("CourseById", new { id = createdCourse.id }, createdCourse);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get All Course
        [HttpGet("getCourse")]
        public async Task<IActionResult> GetCourse()
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
        [HttpGet("CourseById/{id}", Name = "CourseById")]
        public async Task<IActionResult> GetViewCourse(int id)
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
        [HttpPut("updateCourse/{id}")]
        public async Task<IActionResult> updateCourse(int id, CourseForCreationDto course)
        {
            try
            {
                var dbcourse = await _courseRepo.GetViewCourse(id);
                if (dbcourse == null)
                    return NotFound();
                var createdCourse = await _courseRepo.UpdateCourse(id, course);
                return CreatedAtRoute("CourseById", new { id = id }, createdCourse);
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
                var dbCourse = await _courseRepo.GetViewCourse(id);
                if (dbCourse == null)
                    return NotFound();
                await _courseRepo.DeleteCourse(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
