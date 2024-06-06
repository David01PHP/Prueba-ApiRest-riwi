using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeacher();
        Teacher GetTeacherId(int id);
        void CreateTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
    }
}