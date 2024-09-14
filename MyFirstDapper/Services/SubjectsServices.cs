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
            subjectsRepository = new SubjectsRepository();
            return subjectsRepository.GetbyId(id);
        }
        public bool AddSubject(SubjectsModel subject)
        {
            subjectsRepository = new SubjectsRepository();
            return subjectsRepository.Add(subject);
        }
    }
        
}
