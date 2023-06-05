namespace FACTORY.Models.ProductoFactory
{
    public class Libro : Producto
    {
        public string Autor { get; set; }

        public override void MostrarDetalle()
        {
            Console.WriteLine($"Libro: {Nombre} - Autor: {Autor} - Precio: {Precio}");
        }
    }
}
