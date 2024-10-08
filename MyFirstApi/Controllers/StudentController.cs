﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public bool AddStudent(StudentModel student)
        {
            StudentServices studentServices = new StudentServices();
            return  studentServices.AddStudent(student);
            
        }

        [HttpPut]
        public bool UpdateStudent( StudentModel student) 
        {
            StudentServices studentServices = new StudentServices();
            return studentServices.UpdateStudent( student);
        }

        [HttpDelete]


        public bool DeleteStudent(int id) 
        {
            StudentServices studentServices = new StudentServices();
            return studentServices.DeleteStudent(id);
        }

        
    }
}
