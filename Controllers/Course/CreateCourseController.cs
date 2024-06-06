using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Models;
using GestionEscuela.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GestionEscuela.Controllers
{

    public class CreateCourseController : Controller
    {
        public readonly ICourseRepository _courseRepository;

        public CreateCourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPost]
        [Route("Courses")]
        public IActionResult AddEnrollment([FromBody] Course course)
        {
            
            _courseRepository.CreateCourse(course);
            return Ok();
        }
    }
}