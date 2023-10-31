using Microsoft.EntityFrameworkCore;
using Reboot.Data;
using Reboot.Models;
using System.Numerics;
using System.Security.Cryptography.Xml;

namespace Reboot.Repository
{
    public class PedidoDeInformacionRepository
    {

        private readonly RebootContext _context;

        public PedidoDeInformacionRepository(RebootContext context)
        {
            _context = context;
        }

        public PedidoDeInformacion Obtener(int id)
        {
            var pedido = _context
                .PedidoDeInformacion
                .Include(x => x.Empresa)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            pedido.Postulantes = _context
                .Postulante
                .Where(x => x.PedidoDeInformacionId == id)
                .ToList();


            return pedido;
        }


        public List<PedidoDeInformacion> ObtenerPedidosPendientes()
        {
            // opcion 1
            var pedidos = _context
                .PedidoDeInformacion
                .Include(x => x.Empresa)
                .Include(x => x.Postulantes)
                .ToList();

            // opcion 2
            var pedidos2 = _context
                .PedidoDeInformacion
                .ToList();

            // var empresas = _context.Empresa.ToList();

            var empresas = _context.Empresa
                .Where(x => pedidos2.Select(xx => xx.EmpresaId).Contains(x.Id))
                .ToList();

            foreach (var pedido in pedidos2)
            {
                pedido.Empresa = empresas
                    .Where(x => x.Id == pedido.EmpresaId)
                    .FirstOrDefault();

                pedido.Postulantes = _context
                    .Postulante
                    .Where(x => x.PedidoDeInformacionId == pedido.Id)
                    .ToList();
            }


            return pedidos;
        }

        //var otroPedido = _context
        //   .PedidoDeInformacion
        //   .Where(x => x.TituloDelPedido == "hola")
        //   .FirstOrDefault();

        //var misPedidos = _context
        //    .PedidoDeInformacion
        //    .Where(ert => ert.EmpresaId == 44 && ert.Disable == false) // 44 es COTO 
        //    .OrderByDescending(x => x.Id)
        //    .ToList();

        //PedidoDeInformacion pedidoRaw = _context
        //    .PedidoDeInformacion
        //    .FromSqlRaw("select * from pedideinformacion")
        //    .FirstOrDefault();
    }
}

