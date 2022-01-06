
using Dapper;
using StudentManagementSystem.Common;
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
    public class StudentService : IStudentRepository
    {

        private readonly DapperContext _context;
        public StudentService(DapperContext context)
        {
            _context = context;
        }

        SaltEncryption salt = new SaltEncryption();

        //Create a New Student
        public async Task<Students> CreateStudents(Students student)
        {
            var procedureName = "createstudentslist";
            var parameters = new DynamicParameters();
            parameters.Add("Fname", student.Fname, DbType.String);
            parameters.Add("Lname", student.Lname, DbType.String);
            parameters.Add("Email", student.Email, DbType.String);
            var _password = salt.ComputeHash(student.password, "SHA512", null);
            parameters.Add("password", _password, DbType.String);
            parameters.Add("phone", student.phone, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdStudent = new Students
                {
                    id = id,
                    Fname = student.Fname,
                    Lname = student.Lname,
                    Email = student.Email,
                    password = student.password,
                    phone = student.phone
                };
                return createdStudent;
            }
        }

        //Get All Students
        public async Task<IEnumerable<Students>> GetStudents()
        {
            var procedureName = "getstudentslist";
            using (var connection = _context.CreateConnection())
            {
                var students = await connection.QueryAsync<Students>
                    (procedureName, commandType: CommandType.StoredProcedure);
                return students;
            }
        }

        //Get a Single Student
        public async Task<Students> GetViewStudents(int id)
        {
            var procedureName = "StudentViewByID";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var students = await connection.QuerySingleAsync<Students>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return students;
            }
        }

        //Update a student
        public async Task<Students> UpdateStudent(int id, Students student)
        {
            var procedureName = "updateStudent";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32);
            parameters.Add("Fname", student.Fname, DbType.String);
            parameters.Add("Lname", student.Lname, DbType.String);
            parameters.Add("Email", student.Email, DbType.String);
            parameters.Add("password", student.password, DbType.String);
            parameters.Add("phone", student.phone, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdStudent = new Students
                {
                    id = id,
                    Fname = student.Fname,
                    Lname = student.Lname,
                    Email = student.Email,
                    password = student.password,
                    phone = student.phone
                };
                return createdStudent;
            }
        }

        //Delete a Student
        public async Task DeleteStudent(int id)
        {
            var procedureName = "deletestudent";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }
        }

      
    }
}
