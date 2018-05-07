using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="Product")]
        public int ProductId        { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Description   { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price        { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastBuy     { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        public float Stock          { get; set; }


        [DataType(DataType.MultilineText)]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        public string Remarks       { get; set; }

        //Relaciones
        public virtual ICollection<SupplierProduct> SupplierProducts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}