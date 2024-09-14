using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
    public class SubjectsServices
    {
        SubjectsRepository subjectsRepository;

        public SubjectsModel GetSubjectsById(int id)
        {
            return subjectsRepository.GetbyId(id);
        }
        public bool AddSubject(SubjectsModel subject)
        {
            return subjectsRepository.Add(subject);
        }

        public bool UpdateSubject(SubjectsModel subject)
        {

            return subjectsRepository.Update(subject);
        }

        public  bool DeleteSubject(int id) 
        {
            return subjectsRepository.Delete(id);
        }

    }

}
