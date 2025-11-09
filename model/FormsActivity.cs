using System.ComponentModel.DataAnnotations;

namespace HubCollege.model
{
    public class FormsActivity
    {
        [Key]
        public int FormsActivityId { get; set; }
        
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

    }
}