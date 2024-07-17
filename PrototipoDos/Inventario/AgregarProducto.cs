using Microsoft.Web.WebView2.Core;
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

namespace PrototipoDos.Inventario
{
    public partial class AgregarProducto : Form
    {
        DataAccessLeyer _DataAccessLeyer;

        public AgregarProducto(TallerDbContext context)
        {
            InitializeComponent();

            _DataAccessLeyer = new DataAccessLeyer(context);

            CargarMetalesComboBox();

            cmbKilataje.Enabled = false;
            cmbTipoDeMetal.SelectedIndexChanged += ComboBoxMetal_SelectdIndexChangend; // Corregido

            txtCodigo.KeyPress += txtCodigo_KeyPrees;
            txtNombreProducto.KeyPress += txtNombreProdducto_KeyPrees;
            txtModeloONumero.KeyPress += txtModeloONumero_KeyPress;
            txtPrecioPorPar.KeyPress += txtPrecioPorPar_KeyPress;
            cmbTipoDeMetal.DropDownStyle = ComboBoxStyle.DropDownList;
            // txtKilataje.KeyPress += txtKilataje_KeyPress;
        }

        #region Cargar datos de base de datos
        private void CargarMetalesComboBox()
        {
            DataAccessLeyer dataAccessLeyer =
                new DataAccessLeyer(new TallerDbContext());

            List<string> metales = dataAccessLeyer.GetMetales();
            cmbTipoDeMetal.Items.Clear();

            foreach (var metal in metales)
            {
                cmbTipoDeMetal.Items.Add(metal);
            }
        }

        private void CargarMetalesComboBox(string BuscarK)
        {

            cmbKilataje.Items.Clear();

            DataAccessLeyer dataAccessLeyer2 =
                new DataAccessLeyer(new TallerDbContext());

            List<string> kilate = dataAccessLeyer2.GetKilataje(BuscarK);

            foreach (var kilataje in kilate)
            {
                cmbKilataje.Items.Add(kilataje);
            }

            if (cmbKilataje.Items.Count > 0)
            {
                cmbKilataje.SelectedIndex = 0; // Esto selecciona automáticamente el primer elemento
            }

        }

        #endregion

        private void ComboBoxMetal_SelectdIndexChangend(object sender, EventArgs e)
        {

            if (cmbTipoDeMetal.SelectedItem == null)
            {
                return; // No hay selección, salimos del método.
            }

            string seleccionDeMetal = cmbTipoDeMetal.SelectedItem.ToString().Trim();

            // Asegúrate de que cmbKilataje no es null antes de llamar ToString()
            // Habilita cmbKilataje si la selección es "Oro" o "Oro blanco"
            cmbKilataje.Enabled = seleccionDeMetal == "Oro" || seleccionDeMetal == "Oro blanco";


            // Asumiendo que CargarMetalesComboBox está definido correctamente para tomar un string como parámetro
            CargarMetalesComboBox(seleccionDeMetal);


        }

        private void txtNombreProdducto_KeyPrees(object sender, KeyPressEventArgs e)
        {
            ValidacionDeLetrasYLongitud(sender, e, 35);
        }
        private void txtCodigo_KeyPrees(object sender, KeyPressEventArgs e)
        {
            ValidacionDeNumerosYlongitud(sender, e, 6);
        }
        private void txtModeloONumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ModeloOnumero(sender, e, 5);
        }

        private void txtPrecioPorPar_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosConpuntoYlongitud(sender, e, 5);
        }
        private void txtKilataje_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDeNumerosYlongitud(sender, e, 5);

        }


        private void ValidacionDeLetrasYLongitud(object sender, KeyPressEventArgs e, int longitud)
        {
            TextBox text = (TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (text.TextLength >= longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void ValidacionDeNumerosYlongitud(object sender, KeyPressEventArgs e, int Longitud)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (textBox.TextLength >= Longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void SoloNumerosConpuntoYlongitud(object sender, KeyPressEventArgs e, int Longitud)
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

        private void ModeloOnumero(object sender, KeyPressEventArgs e, int Longitud)
        {

            TextBox textBox = (TextBox)sender;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '/' && textBox.Text.Contains('/'))
            {
                e.Handled = true;
            }


            if (textBox.Text.Length >= Longitud && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }



        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProcu_TextChanged(object sender, EventArgs e)
        {

        }


        private void obtenerDatos()
        {
            InvProducto producto = new InvProducto
            {
                CodigoRelacionado = txtCodigo.Text,
                NombreProducto = txtNombreProducto.Text,
                ModeloONumero = txtModeloONumero.Text,
                TipoMetal = cmbTipoDeMetal.Text,
                Kilataje = cmbKilataje.Text,
                PrecioPorPar = decimal.Parse(txtPrecioPorPar.Text)

            };

            _DataAccessLeyer.AgregarProducto(producto);


        }




        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) &&
                !string.IsNullOrEmpty(txtNombreProducto.Text) &&
                !string.IsNullOrEmpty(txtModeloONumero.Text) &&
                !string.IsNullOrEmpty(txtPrecioPorPar.Text) &&
                !string.IsNullOrEmpty(cmbTipoDeMetal.Text))
            {
                obtenerDatos();
            }
            else
            {

                MessageBox.Show("Por favor, ingrese datos en todos los campos antes de ejecutar la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoDeMetal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
