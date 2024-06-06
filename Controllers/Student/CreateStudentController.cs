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
    
    public class CreateStudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;

        public CreateStudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpPost]
        [Route("Students")]
        public IActionResult CreateStudent([FromBody]Student student)
        {
            _studentRepository.CreateStudent(student);
            return CreatedAtAction(nameof(CreateStudent), new { id = student.Id }, student);
        }

    }
}