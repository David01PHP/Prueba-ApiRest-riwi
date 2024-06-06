using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
        Course GetIdCourse(int id);
        void CreateCourse(Course course);
        void UpdateCourse(Course course);
    }
}