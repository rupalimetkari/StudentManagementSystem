
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Contracts
{
    public interface ITeacherRepository
    {
        //Create a New Teacher
        public Task<Teacher> CreateTeacher(Teacher teacher);

        //Get All Teacher
        public Task<IEnumerable<Teacher>> GetTeacher();

        //Get a Single Teacher
        public Task<Teacher> GetViewTeacher(int id);

        //Update a Teacher
        public Task<Teacher> UpdateTeacher(int id, Teacher teacher);

        //Delete a Teacher
        public Task DeleteTeacher(int id);

        //Log in a Teacher
        public Task<Teacher> LoginTeacher(string email, string password);

        //Update Teacher Password
        public Task<string> UpdatePasswordTeacher(int id, string password);
    }
}
