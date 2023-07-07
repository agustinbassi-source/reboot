using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string NombreCliente { get; set; }
    }
}
