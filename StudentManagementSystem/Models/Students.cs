using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace StudentManagementSystem.Entities
{
    public class Students
    {
     
        public int id { get; set; }


        public string Fname { get; set; }


        public string Lname { get; set; }


        public string Email { get; set; }


        public string password { get; set; }


        public string phone { get; set; }


        public int active { get; set; }

        public int usertype { get; set; }
    }


}
