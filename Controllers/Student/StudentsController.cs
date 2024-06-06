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

    public class StudentsController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("[Controller]")]
        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        [HttpGet]
        [Route("[Controller]/{id}")]
        public Student GetIdStudent(int id)
        {
            return _studentRepository.GetStudentId(id);
        }
    }
}