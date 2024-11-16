namespace C__Cumulative_1.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Subject { get; set; }
        public DateTime HireDate { get; set; }
    }
}


