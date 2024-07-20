using Microsoft.Data.SqlClient;
using PrototipoDos.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoDos.Pedido_Broqueleros
{
    internal class DB_PedidosBroqueleros
    {
        private readonly TallerDbContext _context;
        
        public DB_PedidosBroqueleros(TallerDbContext context)
        {
            _context = context;
        }


        public GestionPersonalEmpleado BuscarEmpleado(string BuscarEmpleado)
        {
            //MessageBox.Show("2 " + BuscarEmpleado);
            int idEmpleado;
            bool esNumero = int.TryParse(BuscarEmpleado, out idEmpleado);

            var ConsultaEmpleado = esNumero ?
                 _context.GestionPersonalEmpleado.Where(e => e.EmpleadoId == idEmpleado && e.StatusId == 1)
                            .Select(e => new GestionPersonalEmpleado
                            {
                                EmpleadoId = e.EmpleadoId,
                                NombreCompleto = e.NombreCompleto
                            })
                        .FirstOrDefault() :
                _context.GestionPersonalEmpleado
                    .Where(e => (e.NombreCompleto.Contains(BuscarEmpleado)) &&
                                e.StatusId == 1)
                    .Select(e => new GestionPersonalEmpleado
                    {
                        EmpleadoId = e.EmpleadoId,
                        NombreCompleto = e.NombreCompleto
                    })
                    .FirstOrDefault();

            return ConsultaEmpleado;
        }

        public List<string> GetMetales()
        {
            try
            {
                var metales = _context.InvMetales
                    .Where(e => e.StatusId ==1)
                    .Select( e => e.NombreCompleto)
                    .Distinct()
                    .ToList();
                return metales;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo GetMetales en DB_PedidosBroqueleros. \n" + e);
                return new List<string>();
            }

        }


        public List<string> GetProductos(string Buscar)
        {
            try
            {
                
                int? MetalID = _context.InvMetales.Where(e => e.NombreCompleto == Buscar && e.StatusId == 1)
                                                  .Select(e => e.MetalId)
                                                  .SingleOrDefault();

                

                if (!MetalID.HasValue)
                {
                    // Lanzar una excepción si no se encuentra el metalID
                    throw new KeyNotFoundException("No se encontró ningún MetalID con ese kilate.");

                }

                // Aquí se obtienen los nombres de los productos relacionados con el MetalID encontrado
                List<string> nombresProductos = _context.InvProductos
                                                        .Where(e => e.MetalID == MetalID.Value && e.StatusProductoId == 1)
                                                        .Select(e => e.NombreProducto)
                                                        .Distinct()  // Si se desea evitar nombres duplicados
                                                        .ToList();

                return nombresProductos;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el método GetProductosPorNombre. \n" + e);
                return new List<string>(); 

            }
            
        }



        public void     CrearPedido(PedidosBroquelerosSalidum pedido)
        {
            try
            {

                NuevoPedido(pedido);
              
                int? pedidoDesc = _context.InvPedidosBroqueleros
                                    .OrderByDescending(e => e.PedidoId)
                                    .Select(e => e.PedidoId)
                                    .FirstOrDefault();

                if (pedidoDesc.HasValue)
                {
                    PedidoDetalle(pedido);

                }
                else
                {
                    MessageBox.Show("Algo salio mal. ");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Fallo el metodo CrearPedido. \n " + e.Message);
                throw;
            }

        }
        

        private void NuevoPedido(PedidosBroquelerosSalidum pedido)
        {

            InvPedidosBroquelero nuevoPedido = new InvPedidosBroquelero();
            nuevoPedido.StatusId = 1;
            nuevoPedido.Fecha = DateTime.Now;
            nuevoPedido.EmpleadoId = pedido.EmpleadoId;

            _context.InvPedidosBroqueleros.Add(nuevoPedido);
            _context.SaveChanges();


        }

        private void PedidoDetalle(PedidosBroquelerosSalidum pedido)
        {
            try
            {
                pedido.StatusPedidoDetalleId = 1;
                pedido.FechaSalida = DateTime.Now;

                pedido.GramosTotal = pedido.GramosCasquilla + pedido.GramosPernos + pedido.GramosTuerca + pedido.GramosSoldadura;


                int? pedidoID = _context.InvPedidosBroqueleros
                                    .OrderByDescending(e => e.PedidoId)
                                    .Select(e => e.PedidoId)
                                    .FirstOrDefault();

                if (pedidoID.HasValue)
                {
                    int? metataID = _context.InvMetales.Where(m => m.NombreCompleto == pedido.Kilate)
                              .Select(m => m.MetalId)
                              .FirstOrDefault();

                    if (metataID.HasValue)
                    {
                        MessageBox.Show("metalID: " + metataID.ToString());

                        int? productoID = _context.InvProductos.Where(n => n.NombreProducto == pedido.Producto && n.MetalID == metataID)
                                         .Select(n => n.ProductoId)
                                         .FirstOrDefault();

                        if (productoID.HasValue)
                        {

                            MessageBox.Show("productoID: " + productoID.ToString());

                            pedido.PedidoId = pedidoID;
                            pedido.KilateId = metataID;
                            pedido.ProductoId = productoID;

                            _context.PedidosBroquelerosSalida.Add(pedido);
                            _context.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("No se encontro el ProductoID. ");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se encontro el metalkID. ");
                    }



                }
                else
                {
                    MessageBox.Show("Algo salio mal. ");
                }

               


             
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo PedidoDetalle \n" + e);
                throw;
            }
            
        }

        public List<PedidosBroquelerosSalidum> GetPedidoDetalle()
        {
           
            try
            {
                int? pedidoId = _context.InvPedidosBroqueleros.OrderByDescending(x => x.PedidoId)
                                                              .Select(x => x.PedidoId)
                                                              .FirstOrDefault();
                if (!pedidoId.HasValue)
                {
                  

                }
                var pedido = _context.PedidosBroquelerosSalida.Where(e => e.PedidoId == pedidoId)
                                                .OrderBy(e => e.PedidoDetalleId)
                                                .ToList();

                return pedido.ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo GetPedidoDetalle. \n" + e.Message);
                throw;
            }
        }


        public void BuscarPedidoID_textBox(System.Windows.Forms.TextBox textBox)
        {
            try
            {
             //   InvPedidosBroquelero pedido = new InvPedidosBroquelero();

             var pedido =   _context.InvPedidosBroqueleros.OrderByDescending(e => e.PedidoId)
                                             .FirstOrDefault();


                if (pedido != null)
                {
                    textBox.Text = pedido.PedidoId.ToString(); // Asumiendo que PedidoId es el campo que quieres mostrar
                }
                else
                {
                    textBox.Text = "No se encontraron registros.";
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        public void InsertPedidoDetalle(PedidosBroquelerosSalidum pedido)
        {
            pedido.StatusPedidoDetalleId = 1;
            pedido.FechaSalida = DateTime.Now;
            pedido.GramosTotal = pedido.GramosCasquilla + pedido.GramosPernos + pedido.GramosTuerca + pedido.GramosSoldadura;

            int? metataID = _context.InvMetales.Where(m => m.NombreCompleto == pedido.Kilate)
                              .Select(m => m.MetalId)
                              .FirstOrDefault();

            if (metataID.HasValue)
            {
                MessageBox.Show("metalID: " + metataID.ToString());

                int? productoID = _context.InvProductos.Where(n => n.NombreProducto == pedido.Producto && n.MetalID == metataID)
                                 .Select(n => n.ProductoId)
                                 .FirstOrDefault();

                if (productoID.HasValue)
                {

                    MessageBox.Show("productoID: " + productoID.ToString());

                   // pedido.PedidoId = pedidoID;
                    pedido.KilateId = metataID;
                    pedido.ProductoId = productoID;

                    _context.PedidosBroquelerosSalida.Add(pedido);
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("No se encontro el ProductoID. ");
                }

            }
            else
            {
                MessageBox.Show("No se encontro el metalkID. ");
            }


        }

        public PedidosBroquelerosSalidum GetBuscarPedidoDetalle (string BuscarText)
        {
            try
            {
                // Intentar convertir el texto de búsqueda a un número entero.
                if (int.TryParse(BuscarText, out int id))
                {
                    // Realizar la consulta condicional basada en el ID y el estado del pedido.
                    var sqlPedidoDetalle = _context.PedidosBroquelerosSalida
                        .Where(e => e.PedidoId == id && e.StatusPedidoDetalleId == 1)
                        .Select(e => new PedidosBroquelerosSalidum
                        {
                            EmpleadoId = e.EmpleadoId,
                            Empleado = e.Empleado,
                            PedidoId = e.PedidoId,
                            PedidoDetalleId = e.PedidoDetalleId,
                            Kilate = e.Kilate,
                            Producto = e.Producto
                        })
                        .FirstOrDefault();

                    return sqlPedidoDetalle;
                }
                // Retornar null si el texto no se pudo convertir a un número.
                return null;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo GetBuscarPedidoDetalle. \n" + e);
                throw;
            }
        }



    }
}
