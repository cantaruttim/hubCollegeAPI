
namespace HubCollege.model
{
    public class Modules : Teachers
    {
        public int ModulesId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public string ModuleAbbreviation { get; set; }
        public int QuantityClasses { get; set; }
        public Teachers TeacherId { get; set; }

        public Modules() { }

        public Modules(
            string moduleName,
            string moduleDuration,
            string moduleAbbreviation,
            int quantityClasses,
            Teachers teacherId
        )
        {
            ModuleName = moduleName;
            ModuleDuration = moduleDuration;
            ModuleAbbreviation = moduleAbbreviation;
            QuantityClasses = quantityClasses;
            TeacherId = teacherId;
        }

    }
}