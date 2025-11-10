
namespace HubCollege.model
{
    public class Courses
    {

        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDetail { get; set; }
        public string CourseDuration { get; set; } // one year, 6 months or 2 weeks
        public int QuantityModules { get; set; }
        public Teachers TeacherName { get; set; }
        public Students StudentName { get; set; }
        public Modules ModuleName { get; set; }

    }
}