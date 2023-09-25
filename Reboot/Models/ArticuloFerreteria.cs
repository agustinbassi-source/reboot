using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class ArticuloFerreteria : MiClaseBase
    {
       
        public string? NombreDeArticulo { get; set; }
        public int? PrecioVenta { get; set; }
        public int? PrecioCosto { get; set; }
        public int? SubCategoriaId { get; set; }
        public int Stock { get; set; }

    }
}
