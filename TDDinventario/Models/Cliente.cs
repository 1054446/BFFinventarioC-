namespace BFFinventario.Models
{
    public class Cliente
    {
        public long clienteId { get; set; }
        public string nombres { get; set;}
        public string apellidos { get; set;}
        public string telefono { get; set;}
        public Boolean frecuente { get; set;}
    }
}
