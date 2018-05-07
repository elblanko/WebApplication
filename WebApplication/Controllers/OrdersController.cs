using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    public class OrdersController : Controller
    {
        private WebApplicationContext db = new WebApplicationContext();
        // GET: Orders
        public ActionResult NewOrder()
        {
            var orderView = new OrderView();
            orderView.Customer = new Customer();
            orderView.Products = new List<ProductOrder>();
            
            //Graba en el objeto de Session el nuevo producto de la lista product order
            Session["OrderView"] = orderView;

            var customerList = db.Customers.ToList();           
            customerList.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(customerList, "CustomerId", "FullName");

            return View(orderView);
        }


        [HttpPost]
        public ActionResult NewOrder(OrderView orderView)
        {
            var customerList = db.Customers.ToList();
            customerList.OrderBy(c => c.FullName).ToList();
            ViewBag.CustomerId = new SelectList(customerList, "CustomerId", "FullName");

            return View(orderView);
        }


        public ActionResult AddProduct()
        {
            var productList = db.Products.ToList();
            productList.OrderBy(p => p.Description).ToList();
            ViewBag.ProductId = new SelectList(productList, "ProductId", "Description");
            return View();
        }


        [HttpPost]
        public ActionResult AddProduct(ProductOrder productOrder)
        {
            var productList = db.Products.ToList();
            productList.OrderBy(p => p.Description).ToList();
            ViewBag.ProductId = new SelectList(productList, "ProductId", "Description");           

            //Recupera el producto que se guardo
            var orderView = Session["orderView"] as OrderView;
            var productId = int.Parse(Request["ProductId"]);
            //Valida que el producto sea valido                        
            //if(productId == 0)
            //{
            //    ViewBag.Error = "Not product selected";
            //    return View(productOrder);
            //}
            var product = db.Products.Find(productId);
            if(product == null)
            {
                ViewBag.Error = "Product doesnt Exist";
                return View(productOrder);
            }
            else
            {
                //si no existe el producto lo creoa y lo agrega a la orden
                productOrder = orderView.Products.Find(p => p.ProductId == productId);
                if (productOrder == null)
                {
                    productOrder = new ProductOrder
                    {
                        Description = product.Description,
                        Price = product.Price,
                        ProductId = product.ProductId,
                        Quantity = float.Parse(Request["Quantity"])
                    };
                    //Agrega la orden
                    orderView.Products.Add(productOrder);
                }
                else
                {
                    //Si el producto existe, solo suma las cantidades
                    productOrder.Quantity += float.Parse(Request["Quantity"]);
                }                              

                //Manda el viewbag de customer a la vista NewOrder
                var customerList = db.Customers.ToList();
                customerList.OrderBy(c => c.FullName).ToList();
                ViewBag.CustomerId = new SelectList(customerList, "CustomerId", "FullName");

                return View("NewOrder", orderView);
            }                        
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}