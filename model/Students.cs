using System.Reflection;
using HubCollege.model.Perfil;

namespace HubCollege.model
{
    public class Students
    {
        public int Id { get; set; }
        public string StudentRegistration { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentCourse { get; set; }
        public Modules ModuleName { get; set; }
        public Permission PermissionLevel { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

        public Students() { }

        public Students(
            string studentRegistration,
            string studentName,
            string studentPhone,
            string studentCourse,
            string permissionLevel,
            Modules moduleName,
            DateTime startAt,
            DateTime endAt
        )
        {
            StudentRegistration = studentRegistration;
            StudentName = studentName;
            StudentPhone = studentPhone;
            StudentCourse = studentCourse;
            ModuleName = moduleName;
            PermissionLevel = new Permission
            {
                PermissionName = permissionLevel
            };
            StartAt = startAt;
            EndAt = endAt;
        }


        public Students(
            string studentRegistration,
            string studentName,
            string studentPhone,
            string studentCourse,
            string permissionLevel,
            DateTime startAt,
            DateTime endAt
        )
        {
            StudentRegistration = studentRegistration;
            StudentName = studentName;
            StudentPhone = studentPhone;
            StudentCourse = studentCourse;
            PermissionLevel = new Permission
            {
                PermissionName = permissionLevel
            };
            StartAt = startAt;
            EndAt = endAt;
        }

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

            StudentPhone = string.Empty;
            StudentCourse = string.Empty;
            StartAt = DateTime.MinValue;
            EndAt = DateTime.MinValue;
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

            StudentRegistration = string.Empty;
            PermissionLevel = new Permission();
        }
    }
}
