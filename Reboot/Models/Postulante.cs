namespace Reboot.Models
{
    public class Postulante : MiClaseBase
    {
        public string NombreApellido { get; set; }
        public string DNI { get; set; }
        public int PedidoDeInformacionId { get; set; }
        public PedidoDeInformacion PedidoDeInformacion { get; set; }
    }
}
