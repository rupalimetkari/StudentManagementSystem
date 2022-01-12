using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Entities
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int course_no { get; set; }

        public string semester { get; set; }

        public int year { get; set; }

        public string description { get; set; }

        public int capacity { get; set; }

        public int active { get; set; }
    }
}
