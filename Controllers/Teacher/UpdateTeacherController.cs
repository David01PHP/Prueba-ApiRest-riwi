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

    public class UpdateTeacherController : ControllerBase
    {
        
        public readonly ITeacherRepository _teacherRepository;

        public UpdateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

       [HttpPut]
        [Route("Teacher/{id}")]
        public IActionResult UpdateTeacher(int id,[FromBody]Teacher teacher)
        {

            var TeacherExistente = _teacherRepository.GetTeacherId(id);

            if (TeacherExistente == null)
            {
                return BadRequest("Id NoEncontrado.");
            }

            TeacherExistente.Names = teacher.Names;
            TeacherExistente.Specialty = teacher.Specialty;
            TeacherExistente.Phone = teacher.Phone;
            TeacherExistente.Email = teacher.Email;
            TeacherExistente.YearsExperience = teacher.YearsExperience;


            try
            {
                _teacherRepository.UpdateTeacher(TeacherExistente);
                return Ok();
            } catch(Exception ex){
                return BadRequest(ex.Message);
            }

        }
    }
}