
public enum PermissionLevel
{
    Adm,
    User,
    Teacher
}

namespace HubCollege.model.Perfil
{
    public class Permission
    {

        public int Id { get; set; }
        public string PermissionName { get; set; } // Adm, User or Teacher

        public PermissionLevel PermissionType { get; set; }

    }
}