using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class Cliente : MiClaseBase
    {

        public string? NombreCliente { get; set; }

        public void Validate()
        {
            //if (this.NombreCliente == null || this.NombreCliente == "")
            //{
            //    throw new Exception("El nombre del cliente llego en null");
            //}

            // otra forma mas linda de hacer lo de arriba seria esta:
            if (string.IsNullOrWhiteSpace(this.NombreCliente))
            {
                throw new Exception("El nombre del cliente llego en null");
            }

        }
    }
}
