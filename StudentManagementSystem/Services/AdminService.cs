using Dapper;
using StudentManagementSystem.Common;
using StudentManagementSystem.Context;
using StudentManagementSystem.Contracts;

using StudentManagementSystem.Entities;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
namespace StudentManagementSystem.Services
{
    public class AdminService : IAdminRepository
    {
        private readonly DapperContext _context;
        public AdminService(DapperContext context)
        {
            _context = context;
        }

        SaltEncryption salt = new SaltEncryption();

        public async Task<Admin> CreateAdmin(Admin admin)
        {
            var procedureName = "createadmin";
            var parameters = new DynamicParameters();
            parameters.Add("Fname", admin.Fname, DbType.String);
            parameters.Add("Lname", admin.Lname, DbType.String);
            parameters.Add("Email", admin.Email, DbType.String);
            var _password = salt.ComputeHash(admin.password, "SHA512", null);
            parameters.Add("password", _password, DbType.String);
            parameters.Add("phone", admin.phone, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                var id = await connection.QuerySingleAsync<int>(procedureName, parameters, commandType: CommandType.StoredProcedure);
                var createdAdmin = new Admin
                {
                    id = id,
                    Fname = admin.Fname,
                    Lname = admin.Lname,
                    Email = admin.Email,
                    phone = admin.phone
                };
                return createdAdmin;
            }
        }

        public async Task<Admin> LoginAdmin(string email, string password)
        {
            //using email to get student data
            var procedureName = "loginadmin";
            var parameters = new DynamicParameters();
            parameters.Add("Email", email, DbType.String, ParameterDirection.Input);
            using var connection = _context.CreateConnection();
            var admin = await connection.QuerySingleAsync(procedureName, parameters, commandType: CommandType.StoredProcedure);

            //Extracting id and password from the dapper row
            var Heading = ((IDictionary<string, object>)admin).Keys.ToArray();
            var details = ((IDictionary<string, object>)admin);
            var id = int.Parse(details[Heading[0]].ToString());
            var passworddb = details[Heading[1]].ToString();

            //verify password
            bool passkey = salt.VerifyHash(password, "SHA512", passworddb);

            //if verified return the student
            if (passkey == true)
            {
                var _procedureName = "AdminViewByID";
                var _parameters = new DynamicParameters();
                _parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
                var returnadmin = await connection.QuerySingleAsync<Admin>
                        (_procedureName, _parameters, commandType: CommandType.StoredProcedure);
                return returnadmin;
            }
            else
            {
                return null;
            }
        }

        public async Task<Admin> GetViewAdmin(int id)
        {
            var procedureName = "AdminViewByID";
            var parameters = new DynamicParameters();
            parameters.Add("id", id, DbType.Int32, ParameterDirection.Input);
            using (var connection = _context.CreateConnection())
            {
                var admin = await connection.QuerySingleAsync<Admin>
                    (procedureName, parameters, commandType: CommandType.StoredProcedure);
                return admin;
            }
        }

     

       
    }
}
