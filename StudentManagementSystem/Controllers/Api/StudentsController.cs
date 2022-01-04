using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
/// <summary>
/// This is Student API Controller
/// </summary>
/// 
namespace StudentManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepo;

        public StudentsController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        //Create a new student
        [HttpPost("createstudent")]
        public IActionResult CreateStudent(Students model)
        {

            try
            {
                _studentRepo.CreateStudents(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return Ok();
        }

        //Get All Student
        [HttpGet("getallstudents")]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var students = await _studentRepo.GetStudents();
                return Ok(students);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get a Single Student
        [HttpGet("getstudent/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            try
            {
                var students = await _studentRepo.GetViewStudents(id);
                if (students == null)
                    return NotFound();
                return Ok(students);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        //Update a student
        [HttpPut("updateStudent/{id}")]
        public async Task<IActionResult> updateStudent(int id, Students student)
        {

            try
            {
                await _studentRepo.UpdateStudent(id, student);
                return Ok();
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        //Delete a Student
        [HttpDelete("deletestudent/{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            try
            {
                await _studentRepo.DeleteStudent(id);
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
