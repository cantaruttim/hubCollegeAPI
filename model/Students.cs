
using HubCollege.model.Perfil;

namespace HubCollege.model
{
    public class Students
    {

        public string StudentRegistration { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentCourse { get; set; }

        public Permission PermissionLevel { get; set; }

        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public Students() { }

        public Students(
            string studentRegistration,
            string studentName,
            string permissionLevel
        )
        {
            StudentRegistration = studentRegistration;
            StudentName = studentName;
            PermissionLevel = new Permission
            {
                PermissionName = permissionLevel
            };
        }


        public Students(
            string studentName,
            string studentPhone,
            string studentCourse,
            DateTime startAt,
            DateTime endAt
        )
        {
            StudentName = studentName;
            StudentPhone = studentPhone;
            StudentCourse = studentCourse;
            StartAt = startAt;
            EndAt = endAt;
        }
        
    }
}