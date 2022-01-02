using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities;

namespace StudentManagementSystem.Controllers
{

    [Route("api/teachers")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepo;
        

        public TeacherController(ITeacherRepository teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        //Create a New Teacher
        [HttpPost("createTeacher")]
        public async Task<IActionResult> CreateTeacher(Teacher teacher)
        {
            try
            {
                var createdTeacher = await _teacherRepo.CreateTeacher(teacher);
                return CreatedAtRoute("TeacherById", new { id = createdTeacher.id }, createdTeacher);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get All Teachers
        [HttpGet("getTeacher")]
        public async Task<IActionResult> GetTeacher()
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
        [HttpGet("teacherById/{id}", Name = "TeacherById")]
        public async Task<IActionResult> GetViewTeacher(int id)
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
        [HttpPut("updateTeacher/{id}")]
        public async Task<IActionResult> updateTeacher(int id, Teacher teacher)
        {
            try
            {
                var dbteacher = await _teacherRepo.GetViewTeacher(id);
                if (dbteacher == null)
                    return NotFound();
                var createdTeacher = await _teacherRepo.UpdateTeacher(id, teacher);
                return CreatedAtRoute("TeacherById", new { id = id }, createdTeacher);
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
                var dbTeacher = await _teacherRepo.GetViewTeacher(id);
                if (dbTeacher == null)
                    return NotFound();
                await _teacherRepo.DeleteTeacher(id);
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
