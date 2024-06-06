using GestionEscuela.Models;
using GestionEscuela.Services;
using Microsoft.AspNetCore.Mvc;

namespace GestionEscuela.Controllers
{

    public class CreateEnrollmentController : Controller
    {
       public readonly IEnrollmentRepository _enrollmentRepository;

        public CreateEnrollmentController(IEnrollmentRepository enrollmentRepository)
        {
            _enrollmentRepository = enrollmentRepository;
        }

        [HttpPost]
        [Route("Enrollment")]
        public IActionResult AddEnrollment([FromBody] Enrollment enrollment)
        {

            MailController Email = new MailController();
            Email.EnviarCorreo();
            
            _enrollmentRepository.AddEnrollment(enrollment);
            return Ok();
        }
    }
}