using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Data;
using GestionEscuela.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionEscuela.Services
{
    public class EnrollmentRepository : IEnrollmentRepository
    {

        public readonly DataContext _context;

        public EnrollmentRepository(DataContext context)
        {
            _context = context;
        }

        public void AddEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

        }

        public IEnumerable<Enrollment> GetAllEnrollmentl()
        {
            return _context.Enrollments.Include(u => u.Course).Include(u => u.Student).ToList();
        }

        public Enrollment GetIdEnrollment(int id)
        {
        return _context.Enrollments.Include(u => u.Course).Include(u => u.Student).FirstOrDefault(e => e.Id == id);
        }

        public Enrollment GetEnrollmentDate([FromBody]string date)
        {
            return _context.Enrollments.Find(date);
        }

        public void UpdateEnrollment(Enrollment enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
        }
    }
}