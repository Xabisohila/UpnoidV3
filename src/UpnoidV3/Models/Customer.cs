using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UpnoidV3.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [MinLength(1, ErrorMessage = "Last name cannot 1 be a character.")]
        public string FirstName { get; set; }
            
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        [MinLength(1, ErrorMessage = "First name cannot 1 be a character.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]  
        public DateTime? Birthdate { get; set; }

        [Display(Name = "Subscribed to Newsletter")]
        public bool IsSubcribedToNewsletter { get; set; }

    }
}
