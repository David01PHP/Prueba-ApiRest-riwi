using GestionEscuela.Models;
using GestionEscuela.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionEscuela.Controllers
{
    
    public class EnrollmentsController : Controller
    {
        public readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentsController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpGet]
        [Route("[controller]/{id}")]
        public Enrollment GetEnrollment(int id){

            return _enrollmentRepository.GetIdEnrollment(id);
        }

        [HttpGet]
        [Route("[controller]/{date}/date")]
        public Enrollment GetEnrollmentDate( string date){

            return _enrollmentRepository.GetEnrollmentDate(date);
        }

        [HttpGet]
        [Route("[controller]")]
        public IEnumerable<Enrollment> GetEnrollments(){

            return _enrollmentRepository.GetAllEnrollmentl();
        }


    }
}