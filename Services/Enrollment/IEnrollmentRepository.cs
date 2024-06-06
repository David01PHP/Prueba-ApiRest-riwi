using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public interface IEnrollmentRepository
    {
        void AddEnrollment(Enrollment enrollment);
        Enrollment GetIdEnrollment(int id);
        Enrollment GetEnrollmentDate(string date);
        IEnumerable<Enrollment> GetAllEnrollmentl();
        void UpdateEnrollment(Enrollment enrollment);
    }
}