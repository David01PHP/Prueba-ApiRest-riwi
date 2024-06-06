using GestionEscuela.Models;
using GestionEscuela.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionEscuela.Controllers
{

    public class TeachersController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;

        public TeachersController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpGet]
        [Route("[Controller]")]
        public IEnumerable<Teacher> GetAll()
        {
            return _teacherRepository.GetAllTeacher();
        }

       
        [HttpGet]
        [Route("[Controller]/{id}")]
        public Teacher GetTeacherId(int id)
        {
            return _teacherRepository.GetTeacherId(id);
        }
    }
}