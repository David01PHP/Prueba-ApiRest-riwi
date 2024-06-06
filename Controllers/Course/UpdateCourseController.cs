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
 
    public class UpdateCourseController : Controller
    {
        public readonly ICourseRepository _courseRepository;

        public UpdateCourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpPut]
        [Route("Course/{id}")]
        public IActionResult Coursecourse(int id,[FromBody]Course course)
        {

            var CourseExistente = _courseRepository.GetIdCourse(id);

            if (CourseExistente == null)
            {
                return BadRequest("Id NoEncontrado.");
            }

            CourseExistente.Name = course.Name;
            CourseExistente.Description = course.Description;
            CourseExistente.TeacherId = course.TeacherId;
            CourseExistente.Schedule = course.Schedule;
            CourseExistente.Duration = course.Duration;
            CourseExistente.Capacity = course.Capacity;
            CourseExistente.Status = course.Status;


            try
            {
                _courseRepository.UpdateCourse(CourseExistente);
                return Ok();
            } catch(Exception ex){
                return BadRequest(ex.Message);
            }

        }


    }
}