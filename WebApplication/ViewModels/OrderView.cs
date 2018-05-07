using System.Collections.Generic;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class OrderView
    {
        public Customer Customer { get; set; }
        public ProductOrder ProductOrder { get; set; }
        public List<ProductOrder> Products { get; set; }
    }
}
