using NuGet.Protocol.Core.Types;
using Reboot.Data;
using Reboot.Models;

namespace Reboot.Repository
{
    public class ClienteRepository
    {
        private readonly RebootContext _context;

        public ClienteRepository(RebootContext context)
        {
            _context = context;
        }

        public int CrearCliente(Cliente elCLiente)
        {
            _context.Cliente.Add(elCLiente);
       
            _context.SaveChanges();

            return elCLiente.Id;
        }

        public List<Cliente> ObtenerClientes() 
        {
            return _context.Cliente
                .Where(x=> x.Disable == null || x.Disable == false)
                .ToList();
        }
    }
}
