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
            if (algunCliente == null)
            {
                throw new Exception("El cliente llego en null");
            }
 
            var clientesExistentes =  _repository.ObtenerClientes();

            foreach (var cliente in clientesExistentes)
            {
                if (cliente.CUIL ==  algunCliente.CUIL)
                {
                    throw new Exception("El cliente ya existe en el sistema");
                }
            }
  
            algunCliente.Validate();

            var idGeneradoDeCliente = _repository.CrearCliente(algunCliente);

            return idGeneradoDeCliente;
        }

        public int ActualizarCliente(Cliente algunCliente)
        {
            if (algunCliente == null)
            {
                throw new Exception("El cliente llego en null");
            }

            algunCliente.Validate();

          //  TODO actualiza cliente

            return 0;
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
