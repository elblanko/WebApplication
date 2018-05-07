using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class ProductOrder : Product
    {
        [Required(ErrorMessage = "You must enter a {0}")]
        public float Quantity { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Value { get { return Price * (Decimal)Quantity; } }
    }
}