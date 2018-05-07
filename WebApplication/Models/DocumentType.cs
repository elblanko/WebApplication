using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class DocumentType
    {
        [Key]
        [Display(Name = "Document Type")]
        public int DocumentTypeId { get; set; }

        [Display(Name = "Document")]
        [Required(ErrorMessage = "You must enter a {0}")]
        public string Description { get; set; }

        /*
         * Propiedad que hace referencia con el lado N de la relacion
         * Ej. Un documento tiene n Empleados
         */
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}