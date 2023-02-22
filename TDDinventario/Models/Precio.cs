namespace BFFinventario.Models
{
    public class Precio
    {
        public long precioId { get; set; }
        public string precio { get; set; }
        public Producto producto { get; set; }    
    }
}
