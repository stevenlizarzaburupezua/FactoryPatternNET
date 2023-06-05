using FACTORY.Models.ProductoFactory;
using Microsoft.AspNetCore.Mvc;

namespace FACTORY.Controllers
{
    public class ProductoController : Controller
    {
        private ProductoFactory factory;

        public ProductoController()
        {
            factory = new ProductoFactory();
        }

        public ActionResult DetalleProducto(string tipo)
        {
            Producto producto = factory.CrearProducto(tipo);

            producto.Nombre = "Ejemplo";
            producto.Precio = 10.99m;

            producto.MostrarDetalle();  

            return View();
        }
    }
}
