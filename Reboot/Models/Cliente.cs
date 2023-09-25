using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class Cliente : MiClaseBase
    {
 
        public string? NombreCliente { get; set; }
        public string? CUIL { get; set; }

        public void Validate()
        {
            if (CUIL == null || CUIL == "" || CUIL.Length != 11)
            {
                throw new Exception("El CUIL esta vacio o tiene un formati incorrecto");
            }

            // otra forma mas linda de hacer lo de arriba seria esta:
            if (string.IsNullOrWhiteSpace(this.NombreCliente))
            {
                throw new Exception("El nombre del cliente llego en null");
            }

        }
    }
}
