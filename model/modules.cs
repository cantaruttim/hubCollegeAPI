
namespace HubCollege.model
{
    public class Modules 
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public string ModuleAbbreviation { get; set; }
        public int ClassesQuantity { get; set; }
        public Teachers TeacherId { get; set; }

        public Modules() { }

        public Modules(
            string moduleName,
            string moduleDuration,
            string moduleAbbreviation,
            int classesQuantity,
            Teachers teacherId
        )
        {
            ModuleName = moduleName;
            ModuleDuration = moduleDuration;
            ModuleAbbreviation = moduleAbbreviation;
            ClassesQuantity = classesQuantity;
            TeacherId = teacherId;
        }

    }
}