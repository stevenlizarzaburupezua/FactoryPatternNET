namespace FACTORY.Models.ProductoFactory
{
    public class Electronico : Producto
    {
        public string Marca { get; set; }

        public override void MostrarDetalle()
        {
            Console.WriteLine($"Electrónico: {Nombre} - Marca: {Marca} - Precio: {Precio}");
        }
    }
}
