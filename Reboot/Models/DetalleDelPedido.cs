using System.ComponentModel.DataAnnotations.Schema;

namespace Reboot.Models
{
    public class DetalleDelPedido : MiClaseBase
    {
        public int ArticuloFerreteriaId { get; set; }

        [NotMapped]
        public ArticuloFerreteria ArticuloFerreteria { get; set; }

        public int Cantidad { get; set; }
        public string  Notas { get; set; }
        public int IdDelPedido { get; set; }

    }
}
