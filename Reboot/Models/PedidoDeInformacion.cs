namespace Reboot.Models
{
    public class PedidoDeInformacion: MiClaseBase
    {
        public string TituloDelPedido { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public List<Postulante> Postulantes { get; set;}
    }
}
