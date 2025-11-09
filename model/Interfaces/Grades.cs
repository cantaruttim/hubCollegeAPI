
namespace HubCollege.model.Interfaces
{
    public interface Grades
    {
        public int somaAtividades()
        {
            /* 
                sum activities by student
                total = 10
            */
            return 0;
        }

        public int somaProva()
        {
            /* 
                sum tests by student
                total = 3
            */
            return 0;
        }

        public int somaRecuperacao()
        {
            // sum recovery test by student
            return 0;
        }
        
        public int calcularMedia()
        {
            /*
                calculate average grade by student
                average = (sum activities + sum tests)

                if average >= 7
                    return "Approved"
                else
                    return "Reproved" 
            */
            return 0;
        }
    }
}