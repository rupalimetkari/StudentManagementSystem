using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Contracts;
using StudentManagementSystem.Entities;
using System.Web;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers.Api
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly IAdminRepository _adminRepo;
        

        public AdminController(IAdminRepository adminRepo)
        {
            _adminRepo = adminRepo;
        }

        //Create a new Admin
        [HttpPost("createadmin")]
        public IActionResult CreateAdmin(Admin model)
        {

            try
            {
                _adminRepo.CreateAdmin(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            return Ok();
        }

        //Get a Single Admin
        [HttpGet("getadmin/{id}")]
        public async Task<IActionResult> GetAdmin(int id)
        {
            try
            {
                var admin = await _adminRepo.GetViewAdmin(id);
                if (admin == null)
                    return NotFound();
                return Ok(admin);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("loginadmin")]
        public async Task<IActionResult> LoginAdmin(string email, string password)
        {
            try
            {
                var admin = await _adminRepo.LoginAdmin(email, password);

                if (admin == null)
                {
                    return NotFound();
                }
                else
                {
                    HttpContext.Session.SetInt32("SessionKeyId", admin.id);
                    HttpContext.Session.SetInt32("SessionKeyActive", admin.active);
                    HttpContext.Session.SetInt32("SessionKeyUserType", admin.usertype);
                    HttpContext.Session.SetString("SessionKeyFname", admin.Fname);
                    HttpContext.Session.SetString("SessionKeyLname", admin.Lname);
                    HttpContext.Session.SetString("SessionKeyEmail", admin.Email);
                    HttpContext.Session.SetString("SessionKeyphone", admin.phone);
                    return Ok(admin);
                }

            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
