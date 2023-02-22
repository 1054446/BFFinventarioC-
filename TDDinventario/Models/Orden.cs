namespace BFFinventario.Models
{
    public class Orden
    {
        public long ordenId { get; set; }
        public Cliente cliente { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public DateTime fecha { get; set; }
    }
}
