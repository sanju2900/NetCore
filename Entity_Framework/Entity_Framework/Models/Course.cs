using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class Course
    {
        [Key]
        public int Course_id { get; set; }
        public string Couse_Name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
