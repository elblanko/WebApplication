using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must enter a {0}")]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public OrderStatus OrderStatus { get; set; }

        //Relaciones
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}