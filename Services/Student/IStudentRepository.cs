using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetStudentId(int id);
        void CreateStudent(Student student);

        void UpdateStudent(Student student);

    }
}