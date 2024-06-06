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
  
    public class CreateTeacherController : ControllerBase
    {
        public readonly ITeacherRepository _teacherRepository;

        public CreateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        [HttpPost]
        [Route("[Controller]")]
        public IActionResult CreateTeacher([FromBody]Teacher teacher)
        {
            _teacherRepository.CreateTeacher(teacher);
            return CreatedAtAction(nameof(CreateTeacher), new { id = teacher.Id }, teacher);
        }
    }
}