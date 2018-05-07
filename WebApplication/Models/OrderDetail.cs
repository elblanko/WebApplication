using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        public float Quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        [StringLength(30, ErrorMessage = "The field must be between {2} and {1} characters", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter a {0}")]
        public decimal Price { get; set; }

        //Relaciones
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}