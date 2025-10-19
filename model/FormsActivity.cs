using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        public string questionOne { get; set; }

        public string questionTwo { get; set; }

    }
}