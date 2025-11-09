
namespace HubCollege.model
{
    public class Modules : Teachers
    {
        public int Id { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDuration { get; set; }
        public string ModuleAbbreviation { get; set; }
        public int QuantityClasses { get; set; }
        public int TeacherId { get; set; }
    }
}