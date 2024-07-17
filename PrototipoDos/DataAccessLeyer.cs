using PrototipoDos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrototipoDos
{
    internal class DataAccessLeyer
    {
        private readonly TallerDbContext _context;

        public DataAccessLeyer(TallerDbContext context)
        {
            _context = context;
        }


        public List<Administradore> ObteneAadministradores() {

            return _context.Administradores.ToList();

        }

        public List<GestionPersonalEmpleado> ObtenerGestionPersonalEmpleado()
        {



            var verEmpleados = _context.GestionPersonalEmpleado.Where(e => e.StatusId  == 1);

            return verEmpleados.ToList();
        }

        public List<GestionPersonalEmpleado> BuscarEmpleado(string BuscarEmpleado) {

            int idEmpleado;
            bool esNumero = int.TryParse(BuscarEmpleado, out idEmpleado);


            var empleadoEncontrado = esNumero ?
                _context.GestionPersonalEmpleado.Where(e => e.EmpleadoId == idEmpleado && e.StatusId == 1) :
                _context.GestionPersonalEmpleado.Where(e => e.Nombre.Contains(BuscarEmpleado) ||
                                                            e.ApellidoPaterno.Contains(BuscarEmpleado) ||
                                                            e.ApellidoMaterno.Contains(BuscarEmpleado) ||
                                                            e.NombreCompleto.Contains(BuscarEmpleado) &&
                                                            e.StatusId == 1);


             return empleadoEncontrado.ToList();
        
        }


        public GestionPersonalEmpleado BuscarEmpleadoDos (string BuscarEmpleado)
        {
            int idEmpleado;
            bool esNumero = int.TryParse(BuscarEmpleado, out idEmpleado);

            var ConsultaEmpleado = esNumero ?
                _context.GestionPersonalEmpleado.Where(e => e.EmpleadoId == idEmpleado && e.StatusId == 1)
                            .Select(e => new GestionPersonalEmpleado
                            {
                                EmpleadoId = e.EmpleadoId,
                                Nombre = e.Nombre,
                                ApellidoPaterno = e.ApellidoPaterno,
                                ApellidoMaterno = e.ApellidoMaterno,
                                Sexo = e.Sexo,
                                CorreoEletronico = e.CorreoEletronico,
                                NumeroCelular = e.NumeroCelular,
                                NombreCompleto = e.NombreCompleto,
                                StatusId = e.StatusId
                            })
                 .FirstOrDefault() :
                _context.GestionPersonalEmpleado
                    .Where(e => (e.Nombre.Contains(BuscarEmpleado) ||
                                 e.ApellidoPaterno.Contains(BuscarEmpleado) ||
                                 e.ApellidoMaterno.Contains(BuscarEmpleado) ||
                                 e.NombreCompleto.Contains(BuscarEmpleado)) &&
                                e.StatusId == 1)
                    .Select(e => new GestionPersonalEmpleado
                    {
                        EmpleadoId = e.EmpleadoId,
                        Nombre = e.Nombre,
                        ApellidoPaterno = e.ApellidoPaterno,
                        ApellidoMaterno = e.ApellidoMaterno,
                        Sexo = e.Sexo,
                        CorreoEletronico = e.CorreoEletronico,
                        NumeroCelular = e.NumeroCelular,
                        NombreCompleto = e.NombreCompleto,
                        StatusId = e.StatusId
                    })
                    .FirstOrDefault();

            return ConsultaEmpleado;

        }


        public void AgregarEmpleado(GestionPersonalEmpleado empleado)
        {
            try
            {
               
                string NombreCompleto = $"{empleado.Nombre.Trim()} {empleado.ApellidoPaterno.Trim()} {empleado.ApellidoMaterno.Trim()}";
                empleado.NombreCompleto = NombreCompleto; 

                bool existeNombreCompletro = _context.GestionPersonalEmpleado
                                .Any(e => e.NombreCompleto == NombreCompleto);

                if (!existeNombreCompletro){
                   empleado.StatusId = 1;
                   _context.GestionPersonalEmpleado.Add(empleado);
                   _context.SaveChanges();
                    MessageBox.Show("Se agrego correctamente el empleado.");
                }
                else
                {
                    MessageBox.Show("El empleado ya existe.");

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el método AgregarEmpleado en DataAccessLayer. \n" + e.Message);
                throw;
            }
        }



        public void ActualizarDatosEmpleado(GestionPersonalEmpleado empleado)
        {
            var empleadoEncontrado = _context.GestionPersonalEmpleado.FirstOrDefault(e => e.EmpleadoId == empleado.EmpleadoId);

            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.Nombre = empleado.Nombre;
                empleadoEncontrado.ApellidoPaterno = empleado.ApellidoPaterno;
                empleadoEncontrado.ApellidoMaterno = empleado.ApellidoMaterno;
                empleadoEncontrado.Sexo = empleado.Sexo;
                empleadoEncontrado.CorreoEletronico = empleado.CorreoEletronico;
                empleadoEncontrado.NumeroCelular = empleado.NumeroCelular;
                _context.SaveChanges();

                MessageBox.Show("Los datos se actualizaron correctamente. ");

            }
            else{

                MessageBox.Show("No se encontro al empleado. ");

            }



        }

        public void DeleteEmpleado(GestionPersonalEmpleado empleado) {

            var EmpleadoEncontrado = _context.GestionPersonalEmpleado.FirstOrDefault(e => e.EmpleadoId == empleado.EmpleadoId);

            if (EmpleadoEncontrado != null) {

                EmpleadoEncontrado.StatusId = 0;
                _context.SaveChanges();
            }

        }


        public void AgregarProducto(InvProducto producto)
        {
            try
            {
                string Metal = producto.TipoMetal;
                string kilate = producto.Kilataje;


                int? MetalID = _context.InvMetales.Where(e => e.NombreMetal == Metal && e.Kilataje == kilate && e.StatusId == 1)
                    .Select( e => e.MetalId )
                    .SingleOrDefault();

                if (MetalID.HasValue)// Si se encontró un MetalId, proceder.
                {
                    string NombreCompretoProducto = producto.NombreProducto + " #"
                    + producto.ModeloONumero + " " +
                    producto.TipoMetal + (Metal == "Oro" || Metal == "Oro blanco " ? " " + kilate + " K" : kilate);

                    bool existeNombreCompletro = _context.InvProductos.Any(e => e.NombreCompletoProducto == NombreCompretoProducto);

                    if (!existeNombreCompletro)
                    {
                        producto.StatusProductoId = 1;
                        producto.Fecha = DateTime.Now;
                        producto.NombreCompletoProducto = NombreCompretoProducto;
                        producto.NombreProducto = producto.NombreProducto + " #" + producto.ModeloONumero;
                        producto.MetalID = MetalID.Value;

                        //MessageBox.Show(NombreCompretoProducto);

                        _context.InvProductos.Add(producto);
                        _context.SaveChanges();

                        MessageBox.Show("Se agrego correctamente el producto.");

                    }
                    else
                    {

                        MessageBox.Show("El metal ya exite en Base de datos.");
                    }


                }
                else
                {
                    MessageBox.Show("No se encontró el metal especificado en la base de datos.");
                }





            }
            catch (Exception)
            {

                throw;
            }
            
            
        }





        #region consultas de metal
        public void AgregarMaterial(InvMetale invMetale)
        {
            try
            {
                string nombretemp = invMetale.NombreMetal;

                // Construye el nombre completo de antemano para usarlo en ambos casos
                string nombreCompleto = invMetale.NombreMetal + " " + invMetale.Kilataje + (nombretemp == "Oro" || nombretemp == "Oro blanco" ? " K" : "");

                // Verifica si el nombre completo ya existe
                bool existeNombreCompleto = _context.InvMetales.Any(im => im.NombreCompleto == nombreCompleto);

                if (!existeNombreCompleto)
                {
                    invMetale.StatusId = 1;
                    invMetale.FechaRegistro = DateOnly.FromDateTime(DateTime.Now);
                    invMetale.NombreCompleto = nombreCompleto;

                    _context.InvMetales.Add(invMetale);
                    _context.SaveChanges();

                    MessageBox.Show("Se agrego correctamente el metal.");
                }
                else
                {
                    // Maneja el caso cuando el nombre completo ya existe
                    MessageBox.Show("El metal ya exite en Base de datos.");

                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo AgregarMaterial" + e);

                throw;
            }

        }

        public List<string> GetMetales()
        {
            try
            {
                var metales = _context.InvMetales
                    .Where( e => e.StatusId ==1)
                    .Select( e => e.NombreMetal )
                    .Distinct() // Asegura que cada nombre de metal sea único en la lista
                    .ToList();

                return metales;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo GetMetales. \n" + e );
                return new List<string>();

            }
        }



        public List<string> GetKilataje(string BuscarK)
        {
            try
            {

                var kilataje = _context.InvMetales
                    .Where ( e => e.NombreMetal == BuscarK && e.StatusId ==1 )
                    .Select ( e => e.Kilataje)
                    .Distinct()
                    .ToList();
                return kilataje;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error en el metodo GetKilataje. \n" + e);
                return new List<string>();
            }
        }

        #endregion

        public List<PedidosBroquelerosEntrada> ObtenerPedidosEntrada()
        {
            var VerPedidos = _context.PedidosBroquelerosEntradas;
            return VerPedidos.ToList();
        }


    }
}

