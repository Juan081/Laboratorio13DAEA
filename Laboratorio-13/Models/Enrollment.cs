namespace Laboratorio_13.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public DateTime DateTime { get; set; }

        //Llaves foráneas
        public Course? Course { get; set; }
        public int? CourseID { get; set; }
        public Student? Student { get; set; }
        public int? StudentID { get; set; }

        public bool IsActive { get; set; }
    }
}
