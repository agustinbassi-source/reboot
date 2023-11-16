using Reboot.Models;

namespace Reboot.Business.Interface
{
    public interface IClienteBusiness
    {
        int CrearCliente(Cliente algunCliente);
        void EliminarCliente(int id);
    }
}
