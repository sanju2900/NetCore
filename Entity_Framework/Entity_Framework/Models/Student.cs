using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entity_Framework.Models
{
    public class Student
    {
        [Key]
        public int student_Id { get; set; }

        public string student_Name { get; set; }
        public DateTime student_dob { get; set; }


    }
}
