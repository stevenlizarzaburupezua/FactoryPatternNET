namespace FACTORY.Models.ProductoFactory
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public abstract void MostrarDetalle();
    }
}
