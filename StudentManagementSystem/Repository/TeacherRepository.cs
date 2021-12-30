using Dapper;
using StudentManagementSystem.Context;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Dto;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DapperContext _context;
        public TeacherRepository(DapperContext context)
        {
            _context = context;
        }
       
        //Create a New Student
        public async Task<Teacher> CreateTeacher(TeacherForCreationDto teacher)
        {
            var procedureName = "createTeacherlist";
            var parameters = new DynamicParameters();
            parameters.Add("Fname", teacher.Fname, DbType.String);
            parameters.Add("Lname", teacher.Lname, DbType.String);
            parameters.Add("Email", teacher.Email, DbType.String);
            parameters.Add("password", teacher.password, DbType.String);
            parameters.Add("phone", teacher.phone, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdTeacher = new Teacher
                {
                    id = id,
                    Fname = teacher.Fname,
                    Lname = teacher.Lname,
                    Email = teacher.Email,
                    password = teacher.password,
                    phone = teacher.phone
                };
                return createdTeacher;
            }
        }

        //Delete a Teacher
        public async Task DeleteTeacher(int id)
        {
            var procedureName = "deleteTeacher";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        //Get All Teachers
        public async Task<IEnumerable<Teacher>> GetTeacher()
        {
            var procedureName = "getTeacherlist";
            using (var connection = _context.CreateConnection())
            {
                var Teacher = await connection.QueryAsync<Teacher>
                    (procedureName, commandType: CommandType.StoredProcedure);
                return Teacher;
            }
        }

        //Get a Single Teacher
        public async Task<IEnumerable<Teacher>> GetViewTeacher(int id)
        {
            var procedureName = "TeacherViewByID";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var Teacher = await connection.QueryAsync<Teacher>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return Teacher;
            }
        }

        //Update a student
        public async Task<Teacher> UpdateTeacher(int id, TeacherForCreationDto teacher)
        {
            var procedureName = "updateTeacher";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("Fname", teacher.Fname, DbType.String);
            parameters.Add("Lname", teacher.Lname, DbType.String);
            parameters.Add("Email", teacher.Email, DbType.String);
            parameters.Add("password", teacher.password, DbType.String);
            parameters.Add("phone", teacher.phone, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdTeacher = new Teacher
                {
                    id = id,
                    Fname = teacher.Fname,
                    Lname = teacher.Lname,
                    Email = teacher.Email,
                    password = teacher.password,
                    phone = teacher.phone
                };
                return createdTeacher;
            }
        }
    }
}
