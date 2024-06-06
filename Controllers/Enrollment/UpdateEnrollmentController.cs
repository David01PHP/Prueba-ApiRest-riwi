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
    
    public class UpdateEnrollmentController : Controller
    {
         public readonly IEnrollmentRepository _enrollmentRepository;

        public UpdateEnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

       [HttpPut]
        [Route("Enrollment/{id}")]
        public IActionResult UpdateEnrollment(int id,[FromBody]Enrollment enrollment)
        {

            var EnrollmentExistente = _enrollmentRepository.GetIdEnrollment(id);

            if (EnrollmentExistente == null)
            {
                return BadRequest("Id NoEncontrado.");
            }

            EnrollmentExistente.Date = enrollment.Date;
            EnrollmentExistente.StudentId = enrollment.StudentId;
            EnrollmentExistente.CourseId = enrollment.CourseId;
            EnrollmentExistente.Status = enrollment.Status;


            try
            {
                _enrollmentRepository.UpdateEnrollment(EnrollmentExistente);
                return Ok();
            } catch(Exception ex){
                return BadRequest(ex.Message);
            }

        }
    }
}