using Microsoft.IdentityModel.Tokens;
using PrototipoDos.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoDos.Pedido_Broqueleros.ClasesPedidos
{
    internal class DB_FinalizarPedidos
    {
        private readonly TallerDbContext _context;

        public DB_FinalizarPedidos(TallerDbContext context)
        {
            _context = context;
        }

        public List<InvPedidosBroquelero> VerPedidos()
        {
            var VerPediso = _context.InvPedidosBroqueleros.Where(e => e.StatusId == 1);
            return VerPediso.ToList();
        }

        public List<PedidosBroquelerosSalidum> VerPedidoDetalle()
        {
            var VerPedidoDetalle = _context.PedidosBroquelerosSalida.Where(e => e.StatusPedidoDetalleId == 1);
            return VerPedidoDetalle.ToList();
        }

        public List<InvPedidosBroquelero> BuscarPedido(string BuscarText)
        {
            int.TryParse(BuscarText, out int idPedido);

            var PedidoEncontrado = _context.InvPedidosBroqueleros.Where(e => e.PedidoId == idPedido && e.StatusId == 1);
                
            
            return PedidoEncontrado.ToList();
        
        }

        public InvPedidosBroquelero CargarDatosPedido(string BuscarText)
        {
           
            int.TryParse(BuscarText, out int idPedido);

            var CargarDatosPedido = _context.InvPedidosBroqueleros.Where(e => e.PedidoId == idPedido && e.StatusId == 1)
                                    .Select(e => new InvPedidosBroquelero{
                                    PedidoId = e.PedidoId,
                                    EmpleadoId = e.EmpleadoId
                                    })
                                    .FirstOrDefault();



            return CargarDatosPedido;

        }


        public List<PedidosBroquelerosSalidum> BuscarPedidoDetalle(string BuscarText)
        {
            int.TryParse(BuscarText, out int idpedido);

            var PedidoDetalleEncontrado = _context.PedidosBroquelerosSalida.Where(e => e.PedidoId == idpedido && e.StatusPedidoDetalleId == 1);

            return PedidoDetalleEncontrado.ToList();

        }

        public PedidosBroquelerosSalidum CargarDatosPedidoDetalle(string BuscarText)
        {
            int.TryParse(BuscarText, out int idPedido);

            var CargarDatosPedidoDetalle = _context.PedidosBroquelerosSalida.Where(e => e.PedidoId == idPedido && e.StatusPedidoDetalleId == 1)
                .Select( e => new PedidosBroquelerosSalidum
                {
                    EmpleadoId = e.EmpleadoId,
                    Empleado = e.Empleado,
                    PedidoId = e.PedidoId,
                    PedidoDetalleId = e.PedidoDetalleId,    
                    KilateId = e.KilateId,
                    Kilate = e.Kilate,
                    ProductoId = e.ProductoId,
                    Producto = e.Producto

                })
                .FirstOrDefault();

            return CargarDatosPedidoDetalle;
        }

        public PedidosBroquelerosSalidum BuscarPedidoDetalleDos(string BuscarPedidoText, string BuscarPedidoDetalleText)
        {
            int.TryParse(BuscarPedidoText, out int idPedido);
            int.TryParse(BuscarPedidoDetalleText, out int idPedidoDetalle);

            var BuscarPedidoDetalle = _context.PedidosBroquelerosSalida.Where(e => e.PedidoId == idPedido &&
                                                                              e.PedidoDetalleId == idPedidoDetalle &&
                                                                              e.StatusPedidoDetalleId == 1)
                                                                        .Select(e => new PedidosBroquelerosSalidum
                                                                        {
                                                                            EmpleadoId = e.EmpleadoId,
                                                                            Empleado = e.Empleado,
                                                                            PedidoId = e.PedidoId,
                                                                            PedidoDetalleId = e.PedidoDetalleId,
                                                                            KilateId = e.KilateId,
                                                                            Kilate = e.Kilate,
                                                                            ProductoId = e.ProductoId,
                                                                            Producto = e.Producto

                                                                        }).FirstOrDefault();
            return BuscarPedidoDetalle;



    }


        public  InvProducto EncontarProducto(string BuscarProducto, string BuscarKilate)
        {
            InvProducto invProducto = new InvProducto();

            string NombreCompleto = $"{BuscarProducto.Trim()} {BuscarKilate}";
            invProducto.NombreCompletoProducto = NombreCompleto;


            var BuscarProducto1 = _context.InvProductos.Where(e => e.NombreCompletoProducto == NombreCompleto && e.StatusProductoId == 1)
                                                        .Select(e => new InvProducto {
                                                                ProductoId = e.ProductoId,
                                                                PrecioPorPar = e.PrecioPorPar
                                                                
                                                        }).FirstOrDefault();

            return BuscarProducto1;
          
        }


        public void Operador(PedidosBroquelerosEntrada FinalizarPedido)
        {
            StatusDetalleOperador(FinalizarPedido);
               

        }

        private void StatusDetalleOperador(PedidosBroquelerosEntrada FinalizarPedido)
        {
            var status = _context.PedidosBroquelerosSalida.Where( e => e.StatusPedidoDetalleId == 1 && e.PedidoDetalleId == FinalizarPedido.PedidoDetalleId)
                                                          .Select(e => new PedidosBroquelerosSalidum
                                                          {
                                                              StatusPedidoDetalleId = e.StatusPedidoDetalleId

                                                          })
                                                            .FirstOrDefault();
            
            MessageBox.Show(status.StatusPedidoDetalleId.ToString());


        }


    }

    


}
