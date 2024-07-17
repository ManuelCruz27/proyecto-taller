using Microsoft.EntityFrameworkCore;
using PrototipoDos.Empleados;
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

namespace PrototipoDos
{
    public partial class VerEmpleados : Form
    {
        private readonly TallerDbContext _context;
        private readonly DataAccessLeyer _dataAccessLeyer;
        private AgregarEmpleado AgregarEmpleadoForm;



        public VerEmpleados()
        {
            InitializeComponent();

            _context = new TallerDbContext();
            _dataAccessLeyer = new DataAccessLeyer(_context);
            AgregarEmpleadoForm = new AgregarEmpleado(_context);


            AgregarEmpleadoForm = new AgregarEmpleado(_context);
            AgregarEmpleadoForm.EmpleadoAgregado += AgregarEmpleadoForm_EmpleadoAgregado;
            // AgregarEmpleadoForm.EmpleadoAgregado += AgregarEmpleadoForm_FormClosed;
            CargarDatosEmpleado();

            GridEmpleados.DefaultCellStyle.Font = new Font("Arial", 16);
            // Ajustar automáticamente el ancho de las columnas según el contenido
            GridEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void AgregarEmpleadoForm_EmpleadoAgregado(object sender, EventArgs e)
        {
            CargarDatosEmpleado(); // Volver a cargar los datos en la DataGridView
        }

        private void AgregarEmpleadoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CargarDatosEmpleado(); // Actualizar la DataGridView al cerrar el formulario AgregarEmpleado
        }

        private void VerEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatosEmpleado();

        

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string BuscarEmpleado = txtBuscar.Text.Trim();

            if (String.IsNullOrEmpty(BuscarEmpleado))
            {
                CargarDatosEmpleado();
            }
            else
            {
                var empleadoEncontrado = _dataAccessLeyer.BuscarEmpleado(BuscarEmpleado);
                MostrarDatosEmpleados(empleadoEncontrado);
                txtBuscar.Text = string.Empty;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleadoForm = new AgregarEmpleado(_context);
            agregarEmpleadoForm.ShowDialog();



        }


        #region Metodos para mostrar empleados
        public void MostrarDatosEmpleados<T>(List<T> datos)
        {

            GridEmpleados.DataSource = datos;
        }

        private void CargarDatosEmpleado()
        {
            var GestionPersonalEmpleado = _dataAccessLeyer.ObtenerGestionPersonalEmpleado();

            MostrarDatosEmpleados(GestionPersonalEmpleado);
        }

        #endregion


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void GridEmpleados_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Validar que los índices son válidos
                {
                    var cell = GridEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewLinkCell;
                    if (cell != null && cell.Value != null)
                    {
                        if (cell.Value.ToString() == "DarBaja")
                        {
                            // Verificar que el valor no sea nulo y sea un entero válido
                            if (int.TryParse(GridEmpleados.Rows[e.RowIndex].Cells[1].Value?.ToString(), out int empleadoId))
                            {
                                GestionPersonalEmpleado _Empleado = new GestionPersonalEmpleado();

                                int EmpleadoId = empleadoId;
                                _Empleado.EmpleadoId = EmpleadoId;


                                DialogResult resultado = MessageBox.Show(
                                    $"¿Estás seguro de dar de baja al empleado {EmpleadoId}?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question
                                );

                                if (resultado == DialogResult.Yes)
                                {

                                    _dataAccessLeyer.DeleteEmpleado(_Empleado);
                                    // Llama a tu método de baja y actualización de empleados
                                    //BajaEmpleados();
                                    //VerEmpleados();
                                    CargarDatosEmpleado();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El ID del empleado no está en un formato correcto.");
                            }
                        }
                    }
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Error de formato: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error TuT: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
        }
    }
}
