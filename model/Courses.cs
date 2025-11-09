
namespace HubCollege.model
{
    public class Courses : Teachers
    {

        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDetail { get; set; }
        public string CourseDuration { get; set; } // one year, 6 months or 2 weeks
        public int QuantityModules { get; set; }
        public int TeacherId { get; set; }

    }
}