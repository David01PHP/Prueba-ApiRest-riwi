using System.Text.Json.Serialization;

namespace GestionEscuela.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher {get; set;}
        public string? Schedule { get; set; }
        public string? Duration { get; set; }
        public string? Capacity { get; set; }
        public string? Status { get; set; }
        [JsonIgnore]
        public List<Enrollment>? Enrollment {get; set;}
    }
}