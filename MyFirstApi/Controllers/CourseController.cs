using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpPost]
        public bool AddCourse(CourseModel course)
        {
            CourseServices courseServices = new CourseServices();
            return courseServices.AddCourse(course);
        }
    }
}
