using System.ComponentModel.DataAnnotations;

namespace Entity_Framework.Models
{
    public class Club
    {
        [Key]
        public string Club_id { get; set; }
        public string club_name { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
