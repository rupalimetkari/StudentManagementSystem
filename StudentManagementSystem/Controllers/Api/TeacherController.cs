using Microsoft.AspNetCore.Http;
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
               var tch= await _teacherRepo.UpdateTeacher(id, teacher);
                HttpContext.Session.SetString("SessionKeyFname", tch.Fname);
                HttpContext.Session.SetString("SessionKeyLname", tch.Lname);
                HttpContext.Session.SetString("SessionKeyphone", tch.phone);
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
                await _teacherRepo.DeleteTeacher(id);
                HttpContext.Session.Clear();
                return Ok();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("loginteacher")]
        public async Task<IActionResult> LoginTeacher(string email, string password)
        {
            try
            {
                var teacher = await _teacherRepo.LoginTeacher(email, password);

                if (teacher == null)
                {
                    return NotFound();
                }
                else
                {
                    HttpContext.Session.SetInt32("SessionKeyId", teacher.id);
                    HttpContext.Session.SetInt32("SessionKeyActive", teacher.active);
                    HttpContext.Session.SetInt32("SessionKeyUserType", teacher.usertype);
                    HttpContext.Session.SetString("SessionKeyFname", teacher.Fname);
                    HttpContext.Session.SetString("SessionKeyLname", teacher.Lname);
                    HttpContext.Session.SetString("SessionKeyEmail", teacher.Email);
                    HttpContext.Session.SetString("SessionKeyphone", teacher.phone);
                    return Ok(teacher);
                }

            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }


        [HttpPut("UpdatePasswordTeacher")]
        public async Task<IActionResult> UpdatePasswordTeacher(int id, string password)
        {
            try
            {
                var pass = await _teacherRepo.UpdatePasswordTeacher(id, password);
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
