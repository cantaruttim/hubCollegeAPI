using System.ComponentModel.DataAnnotations;

namespace HubCollege.model
{
    public class FormsActivity
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "registrationNumber is Required")]
        public string registrationNumber { get; set; }
        
        [Required(ErrorMessage = "Name is Required")]
        public string name { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        public string email { get; set; }

        [Required(ErrorMessage = "Question One is Required")]
        public string questionOne { get; set; }
        
        [Required(ErrorMessage = "Question Two is Required")]
        public string questionTwo { get; set; }


        public FormsActivity() { }

        public FormsActivity(
            string registrationNumber,
            string name,
            string email,
            string questionOne,
            string questionTwo
        )
        {
            this.registrationNumber = registrationNumber;
            this.name = name;
            this.email = email;
            this.questionOne = questionOne;
            this.questionTwo = questionTwo;
        }

        public int sumActivities()
        {
            // sumActivities method to calculate total activities by student
            return 0;
        }

        public int sumFinalGrade(int quantityOfActivities)
        {   
            // sum quantity of grades correctly responsed by an student
            quantityOfActivities = 0;
            int correctlyResponsed = 2;
            quantityOfActivities += correctlyResponsed;

            if (quantityOfActivities >= 7)
            {
                Console.WriteLine("Approved");
                return quantityOfActivities;
            }
            else
            {
                Console.WriteLine("Reproved");
                return quantityOfActivities;
            }
        }
        
        public int calculateFinalGrade(int quantityOfActivities, int secondGrade)
        {
            // calculate final grade by student
            int finalGrade = (quantityOfActivities) + secondGrade;
            
            if (finalGrade >= 7)
            {
                Console.WriteLine("Final Grade: " + finalGrade + " - Approved");
            }
            else
            {
                Console.WriteLine("Final Grade: " + finalGrade + " - Reproved");
            }
            
            return finalGrade;
        }



    }
}