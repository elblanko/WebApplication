using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    /*
     * Clase que representa una relacion (n:1:m) "muchos a muchos"con Supplier y Product
     * Supplier -n---1- SupplierProduct -1---n- Product
     * */
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductId     { get; set; }

        //Propíedades que identifican la relacion con Supplier y Product
        public int SupplierId            { get; set; }
        public int ProductId             { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Product  Products { get; set; }
    }
}