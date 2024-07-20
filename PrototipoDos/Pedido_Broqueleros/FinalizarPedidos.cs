using PrototipoDos.Models;
using PrototipoDos.Pedido_Broqueleros.ClasesPedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoDos.Pedido_Broqueleros
{
    public partial class FinalizarPedidos : Form
    {
        private readonly TallerDbContext _context;
        private readonly DB_PedidosBroqueleros _dB_PedidosBroqueleros;
        private readonly DataAccessLeyer _dataAccessLeyer;
        private readonly DB_FinalizarPedidos _FinalizarPedidos;


        public FinalizarPedidos(TallerDbContext context)
        {
            InitializeComponent();
            _context = context;
            _dB_PedidosBroqueleros = new DB_PedidosBroqueleros(_context);
            _dataAccessLeyer = new DataAccessLeyer(_context);
            _FinalizarPedidos = new DB_FinalizarPedidos(_context);

            txtEmpleado.ReadOnly = true;
            txtEmpleadoID.ReadOnly = true;
            txtPedidoID.ReadOnly = true;
            txtProducto.ReadOnly = true;
            txtKilataje.ReadOnly = true;
            txtPagoPorTrabajo.ReadOnly = true;

            GridVerPedidos.DefaultCellStyle.Font = new Font("Arial", 16);
            GridVerPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            GridVerPedidosDetalles.DefaultCellStyle.Font = new Font("Arial", 16);
            GridVerPedidosDetalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            txtTotalPares.TextChanged += txtTotalPares_TextChanged;


            txtPedidoDetalle.KeyPress += txtPedidoDetalleID_KeyPress;
            txtTotalPares.KeyPress += txtTotalPares_KeyPress;
            txtPesoFinal.KeyPress += txtPesoFinal_KeyPress;
            txtSobranteDeTuerca.KeyPress += txtSobranteDeTuerca_KeyPress;
            txtPesoMalo.KeyPress += txtPesoMalo_KeyPress;
            txtMerma.KeyPress += txtMerma_KeyPress;
            txtBuscar.KeyPress += txtBuscar_KeyPress;

            // GridVerPedidosDetalles.CellFormatting += dataGridView1_CellFormatting;

        }

        private void FinalizarPedidos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
            cargarPedidoDetalle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String BuscarText = txtBuscar.Text;

            if (string.IsNullOrEmpty(BuscarText))
            {

                CargarPedidos();
                cargarPedidoDetalle();
                MessageBox.Show("Hay que ingresar el numero del pedidoID a buscar. ");

            }
            else
            {
                Buscarpedidos(BuscarText);



                /*
                var BuscarPedido = _dB_PedidosBroqueleros.GetBuscarPedidoDetalle(BuscarText);
                if (BuscarPedido != null)
                {
                    CargarDatos(BuscarPedido);
                }
                else
                {
                    MessageBox.Show("NO se encontro el pedido.");
                }*/
            }
        }


        private void Buscarpedidos(string BuscarText)
        {
            var PedidoEncontrado = _FinalizarPedidos.BuscarPedido(BuscarText);
            //var CargarDatosPedido = _FinalizarPedidos.CargarDatosPedido(BuscarText);
            if (PedidoEncontrado != null)
            {
                MostrarPedidos(PedidoEncontrado);
                //CargarDatosPedidos(CargarDatosPedido);

                var PedidoDetalleEncontrado = _FinalizarPedidos.BuscarPedidoDetalle(BuscarText);
                MostrarPedidoDetalle(PedidoDetalleEncontrado);

                var CargarDatosPedidoDetalle = _FinalizarPedidos.CargarDatosPedidoDetalle(BuscarText);
                if (CargarDatosPedidoDetalle != null)
                {

                    CargarDatosPedidosDetalles(CargarDatosPedidoDetalle);
                }
                else
                {
                    MessageBox.Show("Fallo el proceso de carga de datos");
                }

            }
            else
            {
                MessageBox.Show("No se encontro el empleado.");
            }


            txtBuscar.Text = string.Empty;
        }


        #region Cargar pedidos

        private void CargarPedidos()
        {

            var VerPedidos = _FinalizarPedidos.VerPedidos();
            MostrarPedidos(VerPedidos);
        }

        public void MostrarPedidos<T>(List<T> datos)
        {
            GridVerPedidos.DataSource = datos;
        }

        private void CargarDatosPedidosDetalles(PedidosBroquelerosSalidum Pedidos)
        {

            txtEmpleadoID.Text = Pedidos.EmpleadoId.ToString();
            txtEmpleado.Text = Pedidos.Empleado.ToString();
            txtPedidoID.Text = Pedidos.PedidoId.ToString();
            txtPedidoDetalle.Text = Pedidos.PedidoDetalleId.ToString();
            txtKilataje.Text = Pedidos.Kilate.ToString();
            txtProducto.Text = Pedidos.Producto.ToString();
        }


        private void cargarPedidoDetalle()
        {
            var VerPedidoDetalle = _FinalizarPedidos.VerPedidoDetalle();
            MostrarPedidoDetalle(VerPedidoDetalle);
        }

        private void MostrarPedidoDetalle<T>(List<T> Datos)
        {
            GridVerPedidosDetalles.DataSource = Datos;
        }


        #endregion

        #region 



        private void txtTotalPares_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InvProducto inv = new InvProducto();

                if (string.IsNullOrEmpty(txtTotalPares.Text) || string.IsNullOrEmpty(txtProducto.Text) || string.IsNullOrEmpty(txtKilataje.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos necesarios.");

                    txtPagoPorTrabajo.Text = "0";
                    return;
                }

                string BuscarProducto = txtProducto.Text.Trim();
                string BuscarKilate = txtKilataje.Text.Trim();

                var productoEncontrado = _FinalizarPedidos.EncontarProducto(BuscarProducto, BuscarKilate);
                if (productoEncontrado == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    txtPagoPorTrabajo.Text = "0";
                    return;
                }

                if (!decimal.TryParse(txtTotalPares.Text, out decimal totalPares) || totalPares <= 0)
                {
                    MessageBox.Show("Número de pares inválido. Asegúrate de ingresar un número mayor que cero.");
                    txtPagoPorTrabajo.Text = "0";
                    return;
                }

                decimal totalCosto = totalPares * (productoEncontrado.PrecioPorPar ?? 0);
                txtPagoPorTrabajo.Text = totalCosto.ToString("C2");



                //if (!string.IsNullOrEmpty(txtTotalPares.Text) &&
                //    !string.IsNullOrEmpty(txtProducto.Text) &&
                //    !string.IsNullOrEmpty(txtKilataje.Text))
                //{
                //    string BuscarProducto = txtProducto.Text.Trim();
                //    string BuscarKilate = txtKilataje.Text.Trim();

                //    var productoEncontrado = _FinalizarPedidos.EncontarProducto(BuscarProducto, BuscarKilate);


                //    if (productoEncontrado != null && decimal.TryParse(txtTotalPares.Text, out decimal totalPares) && totalPares > 0)
                //    {



                //        decimal totalCosto = totalPares * (productoEncontrado.PrecioPorPar ?? 0);

                //        // Mostrando el costo total
                //        txtPagoPorTrabajo.Text = totalCosto.ToString("C2");

                //    }
                //    else
                //    {
                //        MessageBox.Show("Producto no encontrado o número de pares inválido.");


                //        txtPagoPorTrabajo.Text = "0";
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex.Message);
            }
        }

        #endregion



        public void CargarDatos(PedidosBroquelerosSalidum pedido)
        {
            txtEmpleadoID.Text = pedido.EmpleadoId.ToString();
            txtEmpleado.Text = pedido.Empleado.ToString();
            txtPedidoID.Text = pedido.PedidoId.ToString();
            txtPedidoDetalle.Text = pedido.PedidoDetalleId.ToString();
            txtKilataje.Text = pedido.Kilate.ToString();
            txtProducto.Text = pedido.Producto.ToString();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPedidoDetalle_Click(object sender, EventArgs e)
        {
            string BuscarPedidoText = txtPedidoID.Text;
            string BuscarPedidoDetalleText = txtPedidoDetalle.Text;

            try
            {
                if (string.IsNullOrEmpty(txtPedidoDetalle.Text))
                {

                    MessageBox.Show("Hay que seleccionar el pedido detalle a finalizar");
                    //MessageBox.Show("Hay que ingresar el numero del pedidoID a buscar. ");


                }
                else
                {
                    var BuscarPedidoDetalleDos = _FinalizarPedidos.BuscarPedidoDetalleDos(BuscarPedidoText, BuscarPedidoDetalleText);

                    if (BuscarPedidoDetalleDos != null)
                    {
                        CargarDatosPedidosDetalles(BuscarPedidoDetalleDos);
                    }
                    else {
                        MessageBox.Show("No se encontro ningun PedidoDetalleID relacionado con el pedido." + txtPedidoID.Text);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);

                throw;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            CargarDatosFinalizar();
        }

        private void CargarDatosFinalizar()
        {
            string BuscarText = txtPedidoID.Text;

            // Inicializamos variables para almacenar los valores convertidos
            int EmpleadoId, PedidoId, PedidoDetalleId;
            decimal TotalPares, PesoFinal, SobranteTuerca, PesoMalo, PesoMerma, PagoPorTrabajo;

            // Validación de campos
            if (!int.TryParse(txtEmpleadoID.Text, out EmpleadoId))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'EmpleadoID' contiene un valor entero válido.");
                return;
            }
            if (!int.TryParse(txtPedidoID.Text, out PedidoId))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'PedidoID' contiene un valor entero válido.");
                return;
            }
            if (!int.TryParse(txtPedidoDetalle.Text, out PedidoDetalleId))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'PedidoDetalle' contiene un valor entero válido.");
                return;
            }
            if (!decimal.TryParse(txtTotalPares.Text, out TotalPares))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'TotalPares' contiene un valor decimal válido.");
                return;
            }
            if (!decimal.TryParse(txtPesoFinal.Text, out PesoFinal))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'PesoFinal' contiene un valor decimal válido.");
                return;
            }
            if (!decimal.TryParse(txtSobranteDeTuerca.Text, out SobranteTuerca))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'SobranteDeTuerca' contiene un valor decimal válido.");
                return;
            }
            if (!decimal.TryParse(txtPesoMalo.Text, out PesoMalo))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'PesoMalo' contiene un valor decimal válido.");
                return;
            }
            if (!decimal.TryParse(txtMerma.Text, out PesoMerma))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'Merma' contiene un valor decimal válido.");
                return;
            }

            // Remover el formato de moneda antes de intentar la conversión
            string pagoPorTrabajoTexto = txtPagoPorTrabajo.Text.Replace("$", "").Replace(",", "").Trim();
            
            if (!decimal.TryParse(pagoPorTrabajoTexto, out PagoPorTrabajo))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo 'PagoPorTrabajo' contiene un valor decimal válido." );
                return;
            }

            
            // Crear el objeto FinalizarPedido con los valores validados
            PedidosBroquelerosEntrada FinalizarPedido = new PedidosBroquelerosEntrada
            {
                EmpleadoId = EmpleadoId,
                Empleado = txtEmpleado.Text,
                PedidoId = PedidoId,
                PedidoDetalleId = PedidoDetalleId,
                Kilate = txtKilataje.Text,
                Producto = txtProducto.Text,
                ParesBroqueles = TotalPares,
                Peso = PesoFinal,
                Tuerca = SobranteTuerca,
                Malo = PesoMalo,
                MermaG = PesoMerma,
                TotalPagar = PagoPorTrabajo
            };

            // Llamada al método Operador de _FinalizarPedidos
            _FinalizarPedidos.Operador(FinalizarPedido);
            Buscarpedidos(BuscarText);

            var borador = _FinalizarPedidos.StatusPedido(BuscarText);

            if ( borador != null && borador.StatusId == 4)
            {
                txtEmpleadoID.Text = string.Empty;
                txtEmpleado.Text = string.Empty;
            }


        }



        #region validaciones

        private void txtPedidoDetalleID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e, 6);
        }


        private void txtTotalPares_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 6);
        }
        private void txtPesoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 6);
        }

        private void txtSobranteDeTuerca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender,e,6);

        }

        private void txtPesoMalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 6);
        }
        private void txtMerma_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 6);
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e, 10);
        }


        private void SoloNumeros(object sender, KeyPressEventArgs e, int Longitud)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }


            if (textBox.TextLength >= Longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }


        }


        private void ValidalcionDeNumerosYLongitud(object sender, KeyPressEventArgs e, int Longitud)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            bool hasDecimalPoint = (sender as TextBox).Text.Contains('.');

            if (e.KeyChar == '.')
            {
                if (hasDecimalPoint || string.IsNullOrEmpty((sender as TextBox).Text))
                {
                    e.Handled = true;
                }
            }

            if (textBox.TextLength >= Longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }


        }


        //private void Largo(object sender, KeyPressEventArgs e, int longitud)
        //{
        //    TextBox textBox = (TextBox)sender;


        //    if(textBox.TextLength >= longitud && e.KeyChar != (char)Keys.Back)
        //    {
        //        e.Handled = true;
        //    }


        //    //// Verificar si el carácter ingresado es una letra o un número
        //    //if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        //    //{
        //    //    e.Handled = true;
        //    //}

        //}


        #endregion




        /*
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)  // Asegúrate de que los índices de fila y columna sean válidos
                {
                    DataGridViewRow row = GridVerPedidosDetalles.Rows[e.RowIndex];

                    // Verificar que estás accediendo a la columna correcta por nombre
                    if (GridVerPedidosDetalles.Columns[e.ColumnIndex].Name == "KilateId")
                    {
                        string cellValue = row.Cells["KilateId"].Value?.ToString();

                        // Aplicar formato basado en el valor de la celda
                        if (cellValue == "27")
                        {
                            row.Cells["KilateId"].Style.ForeColor = Color.Red;
                        }
                        else if (cellValue == "28")
                        {
                            row.Cells["KilateId"].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            row.Cells["KilateId"].Style.ForeColor = Color.Black;  // Color predeterminado
                        }
                    }
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Manejar la excepción o agregar lógica para depurar y encontrar la causa raíz
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        */


    }
}
