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

    public class UpdateStudentController : ControllerBase
    {
        public readonly IStudentRepository _studentRepository;

        public UpdateStudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpPut]
        [Route("Students/{id}")]
        public IActionResult UpdateStudent(int id,[FromBody]Student student)
        {

            var studentExistente = _studentRepository.GetStudentId(id);

            if (studentExistente == null)
            {
                return BadRequest("Id NoEncontrado.");
            }

            studentExistente.Names = student.Names;
            studentExistente.BirthDate = student.BirthDate;
            studentExistente.Address = student.Address;
            studentExistente.Email = student.Email;


            try
            {
                _studentRepository.CreateStudent(studentExistente);
                return Ok();
            } catch(Exception ex){
                return BadRequest(ex.Message);
            }

        }

    }
}