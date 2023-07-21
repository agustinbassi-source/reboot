using Reboot.Data;
using Reboot.Models;
using Reboot.Repository;

namespace Reboot.Business
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository _repository;

        public ClienteBusiness(RebootContext context)
        {
             _repository = new ClienteRepository(context);
        }

        public int CrearCliente(Cliente algunCliente)
        {
            var idGeneradoDeCliente = 0;

            idGeneradoDeCliente =  _repository.CrearCliente(algunCliente);

            return idGeneradoDeCliente;
        }

        public List<Cliente> ObtenerClientes()
        {
            // 1 - Obtengo los cliente
            var clientes = _repository.ObtenerClientes();

            // 2 - Retorno los cliente 
            return clientes;
        }
    }
}
