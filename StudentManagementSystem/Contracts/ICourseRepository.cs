
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentManagementSystem.Contracts
{
    
        public interface ICourseRepository
        {
            //Create a New Course
            public Task<Course> CreateCourse(Course course);

            //Get All Course
            public Task<IEnumerable<Course>> GetCourse();

            //Get a Single Course
            public Task<IEnumerable<Course>> GetViewCourse(int id);

            //Update a Course
            public Task<Course> UpdateCourse(int id, Course course);

            //Delete a Course
            public Task DeleteCourse(int id);
            
        }
    
}
