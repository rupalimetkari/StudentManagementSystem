using Dapper;
using StudentManagementSystem.Context;
using StudentManagementSystem.Contracts;

using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks; 

namespace StudentManagementSystem.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DapperContext _context;
        public CourseRepository(DapperContext context)
        {
            _context = context;
        }

        //Create a New Course
        public async Task<Course> CreateCourse(Course course)
        {
            var procedureName = "createCourselist";
            var parameters = new DynamicParameters();
            parameters.Add("name", course.name, DbType.String);
            parameters.Add("course_no", course.course_no, DbType.Int32);
            
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdCourse = new Course
                {
                    id = id,
                    name = course.name,
                    course_no = course.course_no
                    
                };
                return createdCourse;
            }
        }

        //Delete a Course
        public async Task DeleteCourse(int id)
        {
            var procedureName = "deleteCourse";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        //Get All Course
        public async Task<IEnumerable<Course>> GetCourse()
        {
            var procedureName = "getCourselist";
            using (var connection = _context.CreateConnection())
            {
                var Course = await connection.QueryAsync<Course>
                    (procedureName, commandType: CommandType.StoredProcedure);
                return Course;
            }
        }

        //Get a Single Course
        public async Task<Course> GetViewCourse(int id)
        {
            var procedureName = "CourseViewByID";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var Course  = await connection.QuerySingleAsync<Course>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return Course;
            }
        }

        //Update a Course
        public async Task<Course> UpdateCourse(int id, Course course)
        {
            var procedureName = "updateCourse";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("name", course.name, DbType.String);
            parameters.Add("course_no", course.course_no, DbType.Int32);
          
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdCourse = new Course
                {
                    id = id,
                    name = course.name,
                    course_no = course.course_no
                   
                };
                return createdCourse;
            }
        }
    }
}
