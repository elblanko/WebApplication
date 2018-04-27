using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Products
    {
        [Key]
        [Display(Name ="Product")]
        public int ProductId        { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Description   { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price        { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/mm/dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastBuy     { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        public float Stock          { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Remarks       { get; set; }
    }
}