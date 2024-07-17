using PrototipoDos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoDos.Empleados
{
    public partial class AgregarEmpleado : Form
    {
        private DataAccessLeyer _dataAccessLeyer;
        public event EventHandler EmpleadoAgregado;



        public AgregarEmpleado(TallerDbContext context)
        {
            InitializeComponent();

            _dataAccessLeyer = new DataAccessLeyer(context);

            CargarDatosComboBox();

            txtNombre.KeyPress += txtNombre_KeyPress;
            txtApellidoPaterno.KeyPress += txtApellidoPaterno_KeyPress;
            txtApellidoMaterno.KeyPress += txtApellidoMaterno_keyPress;
            cmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtNumero.KeyPress += txtNumeroCelular_keyPress;

            //txtCalle.KeyPress += txtCalle_KeyPress;
            //txtNoExterior.KeyPress += txtNoEnterior_keyPress;
            //txtNoInterior.KeyPress += txtNoInteriro_keyPress;
            //txtCodigoPostal.KeyPress += txtCodigo_KeyPress;
            //txtEstado.KeyPress += txtEstado_KeyPress;
            //txtMunicipio.KeyPress += txtEstado_KeyPress;
            //txtCiudad.KeyPress += txtCiudad_KeyPrees;
            //txtColonia.KeyPress += txtColonia_KeyPrees;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }


        #region Validaciones de los textbox

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDeLetrasYLongitud(sender, e, 40);
        }

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDeLetrasYLongitud(sender, e, 30);
        }

        private void txtApellidoMaterno_keyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDeLetrasYLongitud(sender, e, 30);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 30);
        }

        private void txtNoEnterior_keyPress(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 10);
        }

        private void txtNoInteriro_keyPress(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 10);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 20);

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 30);
        }

        private void txtCiudad_KeyPrees(object sender, KeyPressEventArgs e)
        {

            LongitudCarateres(sender, e, 30);
        }

        private void txtColonia_KeyPrees(object sender, KeyPressEventArgs e)
        {
            LongitudCarateres(sender, e, 30);
        }


        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSexo.SelectedItem.ToString();
        }

        private void CargarDatosComboBox()
        {
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Femenino");

        }

        private void txtNumeroCelular_keyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(sender, e, 10);
        }

        private void txtCorreoEletrinico_KeyPrees(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string correoElectronico = txtCorreoEletronico.Text;
            if (!EsCorreoEletronico(correoElectronico))
            {
                MessageBox.Show("Ingrese un formato de correo electrónico válido.", "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Evitar que el control pierda el foco
            }

            //    LongitudCarateres(sender, e, 50);
        }

        private void ValidacionDeLetrasYLongitud(object sender, KeyPressEventArgs e, int longitud)
        {
            TextBox textBox = (TextBox)sender;

            //verifica si esta escribiendo una letra 
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //longitud de caracteres a ingresar 
            if (textBox.TextLength >= longitud && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }

        }

        private void LongitudCarateres(object sender, KeyPressEventArgs e, int longitud2)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.TextLength >= longitud2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e, int longitud)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignora la tecla presionada
            }

            if (textBox.TextLength >= longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private bool EsCorreoEletronico(string correo)
        {
            string CorreoEletronico = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(CorreoEletronico);

            return regex.IsMatch(correo);
        }


        #endregion




        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarTexto();
        }

        private void BorrarTexto()
        {
            txtNombre.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            cmbSexo.Text = string.Empty;
            txtCorreoEletronico.Text = string.Empty;
            txtNumero.Text = string.Empty;
            //txtCalle.Text = string.Empty;
            //txtNoExterior.Text = string.Empty;
            //txtNoInterior.Text = string.Empty;
            //txtCodigoPostal.Text = string.Empty;
            //txtEstado.Text = string.Empty;
            //txtMunicipio.Text = string.Empty;
            //txtCiudad.Text = string.Empty;
            //txtColonia.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellidoPaterno.Text) &&
                !string.IsNullOrEmpty(txtApellidoMaterno.Text) &&
                !string.IsNullOrEmpty(cmbSexo.Text) &&
                !string.IsNullOrEmpty(txtCorreoEletronico.Text) &&
                !string.IsNullOrEmpty(txtNumero.Text))
            {
                AgregarEmpleados();
                EmpleadoAgregado?.Invoke(this, EventArgs.Empty);
                this.Close();

            }
            else
            {

                MessageBox.Show("Por favor, ingrese datos en todos los campos antes de ejecutar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }


        private void AgregarEmpleados()
        {
            GestionPersonalEmpleado empleado = new GestionPersonalEmpleado
            {
                Nombre = txtNombre.Text,
                ApellidoPaterno = txtApellidoPaterno.Text,
                ApellidoMaterno = txtApellidoMaterno.Text,
                Sexo = cmbSexo.Text,
                CorreoEletronico = txtCorreoEletronico.Text,
                NumeroCelular = txtNumero.Text
            };

            _dataAccessLeyer.AgregarEmpleado(empleado);

        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            BorrarTexto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
