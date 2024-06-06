
using GestionEscuela.Models;
using GestionEscuela.Services;
using Microsoft.AspNetCore.Mvc;


namespace GestionEscuela.Controllers
{
    public class CoursesController : ControllerBase
    {
        public readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        [Route("[Controller]")]
        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourses();
        }

        [HttpGet]
        [Route("[Controller]/{id}")]
        public Course GetIdCourse(int id)
        {
            return _courseRepository.GetIdCourse(id);
        }

        /*[HttpGet]
        [Route("[Controller]/{id}/Courses")]
        public IEnumerable<Teacher> GetAllTeacherCourse()
        {
            return _teacherRepository.GetAllTeacher();
        }*/

    }
}