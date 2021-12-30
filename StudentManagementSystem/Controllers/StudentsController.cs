
using StudentManagementSystem.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Dto;

namespace StudentManagementSystem.Controllers
{
  
    [Route("api/students")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository _studentRepo;
        public StudentsController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        //Create a New Student
        [HttpPost("createStudent")]
        public async Task<IActionResult> CreateStudent(StudentForCreationDto student)
        {
            try
            {
                var createdStudent = await _studentRepo.CreateStudents(student);
                return CreatedAtRoute("StudentById", new { id = createdStudent.id }, createdStudent);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        //Get All Students
        [HttpGet("getStudents")]
        public async Task<IActionResult> GetStudents()
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
        [HttpGet("StudentById/{id}", Name ="StudentById")]
        public async Task<IActionResult> GetViewStudents(int id)
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
        public async Task<IActionResult> updateStudent(int id, StudentForCreationDto student)
        {
            try
            {
                var dbstudent = await _studentRepo.GetViewStudents(id);
                if (dbstudent == null)
                    return NotFound();
               var createdStudent=  await _studentRepo.UpdateStudent(id, student);
                return CreatedAtRoute("StudentById", new { id = id }, createdStudent);
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
                var dbStudent = await _studentRepo.GetViewStudents(id);
                if (dbStudent == null)
                    return NotFound();
                await _studentRepo.DeleteStudent(id);
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
