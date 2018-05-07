using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); }} 

        [Required(ErrorMessage = "You must enter a {0}")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public string Addres { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public string Document { get; set; }

        //Relaciones
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}