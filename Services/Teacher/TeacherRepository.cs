using GestionEscuela.Data;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public class TeacherRepository : ITeacherRepository
    {

        public readonly DataContext _context;

        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public IEnumerable<Teacher> GetAllTeacher()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherId(int id)
        {
            return _context.Teachers.Find(id);
        }



        public void UpdateTeacher(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
        }

    }
}