using StudentManagementSystem.Dto;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Contracts
{
    public interface IStudentRepository
    {
        //Create a New Student
        public Task<Students> CreateStudents(StudentForCreationDto student);

        //Get All Students
        public Task<IEnumerable<Students>> GetStudents();

        //Get a Single Student
        public Task<IEnumerable<Students>> GetViewStudents(int id);

        //Update a student
        public Task<Students> UpdateStudent(int id, StudentForCreationDto student);

        //Delete a student
        public Task DeleteStudent(int id);
       
    }
}
