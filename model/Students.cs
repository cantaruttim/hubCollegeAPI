
namespace HubCollege.model
{
    public class Students : Interfaces.IGrades
    {

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentPhone { get; set; }
        public string StudentCourse { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        
    }
}