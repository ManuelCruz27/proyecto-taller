using PrototipoDos.Models;
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
    public partial class CrearPedidoBroqueleros : Form
    {

        private readonly TallerDbContext _context;
        private readonly DB_PedidosBroqueleros _dB_PedidosBroqueleros;
        private readonly DataAccessLeyer _dataAccessLeyer;
        public CrearPedidoBroqueleros(TallerDbContext context)
        {
            InitializeComponent();
            _context = context;
            _dB_PedidosBroqueleros = new DB_PedidosBroqueleros(_context);
            _dataAccessLeyer = new DataAccessLeyer(_context);
            CargarDatosComboBox();

            cmbKilataje.SelectedIndexChanged += cmbKilataje_SelectedIndexChanged;

            txtPedidoNuevo.ReadOnly = true;
            txtEmpleadoID.ReadOnly = true;
            txtNombre.ReadOnly = true;

            txtCientoCasquilla.KeyPress += txtCientoCasquilla_KeyPress;
            txtGramosDeCasquilla.KeyPress += txtGramosDeCasquilla_KeyPress;
            txtParesDeCasquilla.ReadOnly = true;

            txtCientoDePernos.KeyPress += txtCientoDePernos_KeyPress;
            txtGramosDePernos.KeyPress += txtGramosDePernos_KeyPress;
            txtParesDePernos.ReadOnly = true;

            txtCientoDeTuerca.KeyPress += txtCientoDeTuerca_KeyPress;
            txtGramosDeTuerca.KeyPress += txtGramosDeTuerca_KeyPress;
            txtParesDeTuerca.ReadOnly = true;

            txtGramosDeSoldadura.KeyPress += txtGramosDeSoldadura_KeyPress;


            txtGramosDeCasquilla.TextChanged += txtParesCasquilla_TextChanged;
            txtGramosDePernos.TextChanged += txtParesPernos_TextChanged;
            txtGramosDeTuerca.TextChanged += txtParesTuerca_TextChanged;

            GridVerPedidos.DefaultCellStyle.Font = new Font("Arial", 16);
            // Ajustar automáticamente el ancho de las columnas según el contenido
            GridVerPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            GridVerPedidos.CellFormatting += dataGridView1_CellFormatting;

            txtBuscarEmpleado.KeyPress += txtBuscar_KeyPress;

        }

        #region Cargar datos en comboBox

        private void CargarDatosComboBox()
        {
            DB_PedidosBroqueleros dB_Pedidos =
                new DB_PedidosBroqueleros(new TallerDbContext());

            List<string> metal = dB_Pedidos.GetMetales();
            cmbKilataje.Items.Clear();

            foreach (var metales in metal)
            {
                cmbKilataje.Items.Add(metales);
            }


        }


        private void cmbKilataje_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbKilataje.SelectedItem == null)
            {
                return;
            }

            string seleccionKilate = cmbKilataje.SelectedItem.ToString().Trim();


            CargarDatosProducto(seleccionKilate);


        }


        private void CargarDatosProducto(string Buscar)
        {
            DB_PedidosBroqueleros dB_Pedidos =
                new DB_PedidosBroqueleros(new TallerDbContext());


            List<string> productos = dB_Pedidos.GetProductos(Buscar);
            cmbProducto.Items.Clear();

            foreach (var producto in productos)
            {
                cmbProducto.Items.Add(producto);
            }

        }



        #endregion

        #region ComboBox

        private void txtCientoCasquilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }

        private void txtGramosDeCasquilla_KeyPress(object sender, KeyPressEventArgs e)
        {

            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }

        private void txtCientoDePernos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }

        private void txtGramosDePernos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }

        private void txtCientoDeTuerca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }
        //txtGramosDeTuerca_KeyPress

        private void txtGramosDeTuerca_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
        }


        private void txtGramosDeSoldadura_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidalcionDeNumerosYLongitud(sender, e, 10);
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



        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;


            if (textBox.TextLength >= 35 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }


            //// Verificar si el carácter ingresado es una letra o un número
            //if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            //{
            //    e.Handled = true;
            //}
        }

        #endregion

        #region CalculoPares
        private void txtParesCasquilla_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PedidosBroquelerosSalidum pedidos = new PedidosBroquelerosSalidum();
                if (!string.IsNullOrEmpty(txtCientoCasquilla.Text) &&
                    !string.IsNullOrEmpty(txtGramosDeCasquilla.Text))
                {
                    if (decimal.TryParse(txtCientoCasquilla.Text, out decimal cientoCasquilla) &&
                        decimal.TryParse(txtGramosDeCasquilla.Text, out decimal gramosCasquilla))
                    {
                        pedidos.CientoCasquilla = cientoCasquilla;
                        pedidos.GramosCasquilla = gramosCasquilla;

                        // Asegúrate de que los valores no sean nulos antes de realizar la división
                        if (pedidos.GramosCasquilla.HasValue && pedidos.CientoCasquilla.HasValue && pedidos.CientoCasquilla.Value != 0)
                        {
                            pedidos.ParesCasquilla = pedidos.GramosCasquilla.Value / pedidos.CientoCasquilla.Value;
                            txtParesDeCasquilla.Text = pedidos.ParesCasquilla.Value.ToString("N3");
                        }
                        else
                        {
                            txtParesDeCasquilla.Text = "0";
                        }
                    }
                }
                else
                {
                    txtParesDeCasquilla.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtParesPernos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PedidosBroquelerosSalidum pedidos = new PedidosBroquelerosSalidum();
                if (!string.IsNullOrEmpty(txtCientoDePernos.Text) &&
                    !string.IsNullOrEmpty(txtGramosDePernos.Text))
                {
                    if (decimal.TryParse(txtCientoDePernos.Text, out decimal cientoPernos) &&
                        decimal.TryParse(txtGramosDePernos.Text, out decimal gramosPernos))
                    {
                        pedidos.CientoPernos = cientoPernos;
                        pedidos.GramosPernos = gramosPernos;

                        // Asegúrate de que los valores no sean nulos antes de realizar la división
                        if (pedidos.GramosPernos.HasValue && pedidos.CientoPernos.HasValue && pedidos.CientoPernos.Value != 0)
                        {
                            pedidos.ParesPernos = pedidos.GramosPernos.Value / pedidos.CientoPernos.Value;
                            txtParesDePernos.Text = pedidos.ParesPernos.Value.ToString("N3");
                        }
                        else
                        {
                            txtParesDePernos.Text = "0";
                        }
                    }
                }
                else
                {
                    txtParesDePernos.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtParesTuerca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PedidosBroquelerosSalidum pedidos = new PedidosBroquelerosSalidum();
                if (!string.IsNullOrEmpty(txtCientoDeTuerca.Text) &&
                   !string.IsNullOrEmpty(txtGramosDeTuerca.Text))
                {
                    if (decimal.TryParse(txtCientoDeTuerca.Text, out decimal cientoTuerca) &&
                        decimal.TryParse(txtGramosDeTuerca.Text, out decimal gramosTuerca))
                    {
                        pedidos.CientoTuerca = cientoTuerca;
                        pedidos.GramosTuerca = gramosTuerca;

                        if (pedidos.GramosTuerca.HasValue && pedidos.CientoTuerca.HasValue && pedidos.CientoPernos != 0)
                        {
                            pedidos.ParesTuerca = pedidos.GramosTuerca / pedidos.CientoTuerca;
                            txtParesDeTuerca.Text = pedidos.ParesTuerca.Value.ToString("N3");

                        }
                        else
                        {
                            txtParesDeTuerca.Text = "0";
                        }
                    }
                }
                else
                {
                    txtParesDeTuerca.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Asegúrate de que estás en la columna correcta
            if (GridVerPedidos.Columns[e.ColumnIndex].Name == "KilateId")
            {
                string cellValue = e.Value?.ToString() ?? "";

                // Cambia el color de la letra según el ID del kilate
                if (cellValue == "27")  // Suponiendo que '27' es el ID para 'Oro 10 K'
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (cellValue == "28")  // Suponiendo que '28' es el ID para 'Oro 14 K'
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Black;  // Color predeterminado
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String BuscarEmpelado = txtBuscarEmpleado.Text;

            if (string.IsNullOrEmpty(BuscarEmpelado))
            {
                MessageBox.Show("Ingrese El empleado a buscar. \n" +
                    "para buscar algun empleado lo puedes hacer con el EmpleadoID ó con el nombre compreto.");
            }
            else
            {
                //MessageBox.Show("1 " + BuscarEmpelado);
                var empleado = _dB_PedidosBroqueleros.BuscarEmpleado(BuscarEmpelado);

                // var empleado = _dataAccessLeyer.BuscarEmpleadoDos(BuscarEmpelado);
                if (empleado != null)
                {
                    CargarDatosEmpleado(empleado);
                }
                else
                {
                    MessageBox.Show("No se encontro el empleado.");
                }
            }
        }

        private void CargarDatosEmpleado(GestionPersonalEmpleado empleado)
        {
            txtEmpleadoID.Text = empleado.EmpleadoId.ToString();
            txtNombre.Text = empleado.NombreCompleto.ToString();

        }

        private void CrearPedidoBroqueleros_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            CargarDaos();

        }

        private void CargarDaos()
        {

            if (!int.TryParse(txtPedidoNuevo.Text, out int pedidoId) ||
          !int.TryParse(txtEmpleadoID.Text, out int empleadoId) ||
          !decimal.TryParse(txtCientoCasquilla.Text, out decimal cientoCasquilla) ||
          !decimal.TryParse(txtGramosDeCasquilla.Text, out decimal gramosCasquilla) ||
          !decimal.TryParse(txtParesDeCasquilla.Text, out decimal paresCasquilla) ||
          !decimal.TryParse(txtCientoDePernos.Text, out decimal cientoPernos) ||
          !decimal.TryParse(txtGramosDePernos.Text, out decimal gramosPernos) ||
          !decimal.TryParse(txtParesDePernos.Text, out decimal paresPernos) ||
          !decimal.TryParse(txtCientoDeTuerca.Text, out decimal cientoTuerca) ||
          !decimal.TryParse(txtGramosDeTuerca.Text, out decimal gramosTuerca) ||
          !decimal.TryParse(txtParesDeTuerca.Text, out decimal paresTuerca) ||
          !decimal.TryParse(txtGramosDeSoldadura.Text, out decimal gramosSoldadura))
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos están llenos y tienen el formato correcto.");
                return;
            }

            decimal resultado = Math.Min(paresCasquilla, Math.Min(paresPernos, paresTuerca));


        

            PedidosBroquelerosSalidum pedido = new PedidosBroquelerosSalidum
            {
                PedidoId = pedidoId,
                EmpleadoId = empleadoId,
                Empleado = txtNombre.Text,
                Kilate = cmbKilataje.Text,
                Producto = cmbProducto.Text,
                CientoCasquilla = cientoCasquilla,
                GramosCasquilla = gramosCasquilla,
                ParesCasquilla = paresCasquilla,
                CientoPernos = cientoPernos,
                GramosPernos = gramosPernos,
                ParesPernos = paresPernos,
                CientoTuerca = cientoTuerca,
                GramosTuerca = gramosTuerca,
                ParesTuerca = paresTuerca,
                GramosSoldadura = gramosSoldadura,
                ParesEstimados = resultado
            };

            if (pedido.PedidoId == 0)
            {
                _dB_PedidosBroqueleros.CrearPedido(pedido);
                _dB_PedidosBroqueleros.BuscarPedidoID_textBox(txtPedidoNuevo);
                VerPedido();

            }
            else
            {
                _dB_PedidosBroqueleros.InsertPedidoDetalle(pedido);
                VerPedido();
            }




        }


        private void CalculoDePares()
        {
            if (decimal.TryParse(txtParesDeCasquilla.Text, out decimal casquillaDis) &&
                decimal.TryParse(txtParesDePernos.Text, out decimal pernosDis) &&
                decimal.TryParse(txtParesDeTuerca.Text, out decimal tuercaDis))
            {
                decimal resultado = Math.Min(casquillaDis, Math.Min(pernosDis, tuercaDis));


            }

        }


        private void VerPedido()
        {
            var PedidosBroquelerosSalidum = _dB_PedidosBroqueleros.GetPedidoDetalle();
            MostrarPedidoDetalle(PedidosBroquelerosSalidum);
            //List<PedidosBroquelerosSalidum> pedido = _dB_PedidosBroqueleros.GetPedidoDetalle();
            //GridVerPedidos.DataSource = pedido;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGramosDePernos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCientoCasquilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostrarPedidoDetalle<T>(List<T> datos)
        {
            GridVerPedidos.DataSource = datos;
            GridVerPedidos.Invalidate();  // Forzar la actualización del DataGridView
        }




    }
}
