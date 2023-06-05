namespace FACTORY.Models.ProductoFactory
{
    public class Ropa : Producto
    {
        public string Talla { get; set; }

        public override void MostrarDetalle()
        {
            Console.WriteLine($"Ropa: {Nombre} - Talla: {Talla} - Precio: {Precio}");
        }
    }
}
