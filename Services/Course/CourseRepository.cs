using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Data;
using GestionEscuela.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionEscuela.Services
{
    public class CourseRepository : ICourseRepository
    {

        public readonly DataContext _context;

        public CourseRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.Include(u => u.Teacher).ToList();
        }

        public Course GetIdCourse(int id)
        {
            return _context.Courses.Include(u => u.Teacher).FirstOrDefault(u => u.Id == id);
        }

        public void UpdateCourse(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
    }
}