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
        StudentRepository studentRepository;
        public StudentModel GetStudentById(int id)
        {
            studentRepository = new StudentRepository();
            return studentRepository.GetbyId(id);
        }

        public bool AddStudent(StudentModel student)
        {
            studentRepository = new StudentRepository();


            return studentRepository.Add(student);

        }

    }
}
