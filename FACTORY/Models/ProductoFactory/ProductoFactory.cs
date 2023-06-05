namespace FACTORY.Models.ProductoFactory
{
    public class ProductoFactory
    {
        public Producto CrearProducto(string tipo)
        {
            switch (tipo)
            {
                case "Libro":
                    return new Libro();
                case "Electronico":
                    return new Electronico();
                case "Ropa":
                    return new Ropa();
                default:
                    throw new ArgumentException($"Tipo de producto inválido: {tipo}");
            }
        }
    }
}
