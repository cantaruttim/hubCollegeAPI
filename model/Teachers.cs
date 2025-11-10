namespace HubCollege.model
{
    public class Teachers
    {

        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherRegistrationNumber { get; set; }
        public string TeacherCourseAt { get; set; }
        public string TeacherModules { get; set; }

        public Teachers() { }

        public Teachers(
            string teacherName, 
            string teacherEmail, 
            string teacherRegistrationNumber, 
            string teacherCourseAt,
            string teacherModules
        )
        {
            TeacherName = teacherName;
            TeacherEmail = teacherEmail;
            TeacherRegistrationNumber = teacherRegistrationNumber;
            TeacherCourseAt = teacherCourseAt;
            TeacherModules = teacherModules;
        }
        
    }
        
}