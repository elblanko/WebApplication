using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Supplier
    {
        [Key]
        [Display(Name="Supplier")]
        public int SupplierId          { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public string Name             { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [Display(Name ="First Name")]
        public string ContactFirstName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [Display(Name = "Last Name")]
        public string ContactLastName  { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [DataType(DataType.PhoneNumber)]
        public string Phone            { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public string Addres           { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email            { get; set; }

        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }    
    }
}