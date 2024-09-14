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
        [HttpPost]
        public bool AddSubject(SubjectsModel subject) 
        { 
            SubjectsServices subjectsServices = new SubjectsServices();
            return subjectsServices.AddSubject(subject);
        }
    }
}
