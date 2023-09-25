using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class MiClaseBase
    {
        [Key]
        public int Id { get; set; }
        public bool? Disable { get; set; }
    }
}
