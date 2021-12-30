﻿using StudentManagementSystem.Dto;
using StudentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Contracts
{
    public interface ITeacherRepository
    {
        //Create a New Teacher
        public Task<Teacher> CreateTeacher(TeacherForCreationDto teacher);

        //Get All Teacher
        public Task<IEnumerable<Teacher>> GetTeacher();

        //Get a Single Teacher
        public Task<IEnumerable<Teacher>> GetViewTeacher(int id);

        //Update a Teacher
        public Task<Teacher> UpdateTeacher(int id, TeacherForCreationDto teacher);

        //Delete a Teacher
        public Task DeleteTeacher(int id);
    }
}