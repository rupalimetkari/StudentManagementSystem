using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepo;

        public TeacherController(ITeacherRepository teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        //Create a New Teacher
        [HttpPost("createteacher")]
        public IActionResult CreateTeacher(Teacher teacher)
        {
            try
            {
                _teacherRepo.CreateTeacher(teacher);
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return Ok();
        }

        //Get All Teachers
        [HttpGet("getallteachers")]
        public async Task<IActionResult> GetAllTeacher()
        {
            try
            {
                var Teacher = await _teacherRepo.GetTeacher();
                return Ok(Teacher);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get a Single Teacher
        [HttpGet("getteacher/{id}")]
        public async Task<IActionResult> GetTeacher(int id)
        {
            try
            {
                var Teacher = await _teacherRepo.GetViewTeacher(id);
                if (Teacher == null)
                    return NotFound();
                return Ok(Teacher);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        //Update a Teacher
        [HttpPut("updateteacher/{id}")]
        public async Task<IActionResult> updateTeacher(int id, Teacher teacher)
        {
            try
            {
                 await _teacherRepo.GetViewTeacher(id);
                return Ok();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        //Delete a Teacher
        [HttpDelete("deleteteacher/{id}")]
        public async Task<IActionResult> DeleteTeacher(int id)
        {
            try
            {
                await _teacherRepo.GetViewTeacher(id);
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
