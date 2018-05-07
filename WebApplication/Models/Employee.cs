using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        //Como esta propiedad no se esta mapeando con EF, es necesario agregar la entrada a la vista (inedx)
        [NotMapped]
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

        [Required(ErrorMessage = "You must enter a {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Salary       { get; set; }

        [DisplayFormat(DataFormatString = "{0:P2}", ApplyFormatInEditMode = false)]
        public float Bonus          { get; set; }
       
        [Display(Name = "Entry Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartTime   { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email         { get; set; }

        [DataType(DataType.Url)]
        public string URL           { get; set; }

        //Propiedad que hace referencia a la tabla relacionada, si se llama igual que el campo
        //No es necesario agregar data anotacion para especificar la relacion
        [Display(Name = "Document")]
        public int DocumentTypeId   { get; set; }

        //En el lado varios, se crea una propiedad virtual que referencia al lado 1 de la relacion
        public virtual DocumentType DocumentType { get; set; }
    }
}