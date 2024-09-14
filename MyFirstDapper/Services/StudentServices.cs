using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
    public class StudentServices
    {
        StudentRepository? studentRepository;
        public StudentModel GetStudentById(int id)
        {
            return studentRepository.GetbyId(id);
        }

        public bool AddStudent(StudentModel student)
        { 
            return studentRepository.Add(student);

        }

        public bool DeleteStudent(int id)
        {
            return studentRepository.Delete(id);
        }

        public bool UpdateStudent(StudentModel student) 
        { 
            return studentRepository.Update( student);
        }


    }
}
