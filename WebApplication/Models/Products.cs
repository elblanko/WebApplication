using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Products
    {
        [Key]
        public int ProductId        { get; set; }
        public string Description   { get; set; }
        public decimal Price        { get; set; }
        public DateTime LastBuy     { get; set; }
        public float Stock          { get; set; }
        public string Remarks       { get; set; }
    }
}