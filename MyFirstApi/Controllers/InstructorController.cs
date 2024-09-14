using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpPost]
        public bool AddInstructor(InstructorModel instructor)
        {
            InstructorRepository repository = new InstructorRepository();
            return repository.Add(instructor);
        }
    }     
}
