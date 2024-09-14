using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {

        SubjectsServices subjectServices;

        [HttpPost]
        public bool AddSubject(SubjectsModel subject) 
        { 
            
            return subjectServices.AddSubject(subject);
        }

        [HttpPut]
        public bool UpdateSubject(SubjectsModel subject) 
        { 
            return subjectServices.UpdateSubject(subject);
        }


        [HttpDelete]
        public bool DeleteSubject(int id) 
        {
            
            return subjectServices.DeleteSubject(id);
        }
    }
}
