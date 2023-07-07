using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class ArticuloFerreteria
    {
        [Key]
        public int Id { get; set; }
        public string NombreDeArticulo { get; set; }
        public int Precio { get; set; }
    }
}
