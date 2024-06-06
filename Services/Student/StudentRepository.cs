
using GestionEscuela.Data;
using GestionEscuela.Models;

namespace GestionEscuela.Services
{
    public class StudentRepository : IStudentRepository
    {

        public readonly DataContext _context;

        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public void CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentId(int id)
        {
            return _context.Students.Find(id);
        }

        public void UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}