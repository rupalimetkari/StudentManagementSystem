using StudentManagementSystem.Entities;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Contracts
{
    public interface IAdminRepository
    {
        //Create a New Admin
        public Task<Admin> CreateAdmin(Admin admin);

        //Log in a Admin
        public Task<Admin> LoginAdmin(string email, string password);

        //Get a Single Admin
        public Task<Admin> GetViewAdmin(int id);
        
    }
}
