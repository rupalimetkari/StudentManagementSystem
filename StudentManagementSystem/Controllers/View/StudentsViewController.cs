﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers.View
{
    public class StudentsViewController : Controller
    {
        [Route("students")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
