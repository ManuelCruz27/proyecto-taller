using PrototipoDos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoDos.Inventario
{
    public partial class AgregarMetales : Form
    {
        private DataAccessLeyer _DataAccessLeyer;
        public AgregarMetales(TallerDbContext context)
        {
            InitializeComponent();
            _DataAccessLeyer = new DataAccessLeyer(context);

            CargarDatosComboBox();
            txtTipoMetal.Enabled = false;

            cmbTipoMatal.SelectedIndexChanged += cmbTipoMetal_SelectdIndexChangend;

            cmbTipoMatal.DropDownStyle = ComboBoxStyle.DropDownList;    
            
            txtTipoMetal.KeyPress += txtTipoMetal_KeyPress;
            txtKilataje.KeyPress += txtKilataje_KeyPress;
            txtGramos.KeyPress += txtGramos_KeyPress;
        }



        private void txtTipoMetal_KeyPress(object sender, KeyPressEventArgs e)
        {

            TextBox textBox = (TextBox)sender;

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //longitud de caracteres a ingresar 
            if (textBox.TextLength >= 15 && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;
            }

        }

        private void txtKilataje_KeyPress(object sender, KeyPressEventArgs e) {

            TextBox textBox1 = (TextBox)sender;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            bool hasDecimap = (sender as TextBox).Text.Contains('.');

            if (e.KeyChar == '.')
            {

                if (hasDecimap || string.IsNullOrEmpty((sender as TextBox).Text))
                {
                    e.Handled = true;
                }
            }

            if (textBox1.TextLength >= 5 && e.KeyChar != (char)Keys.Back)
            {

                e.Handled = true;

            }

        }

        private void txtGramos_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox1 = (TextBox)sender ;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            bool hasDecimap = (sender as TextBox).Text.Contains('.');

            if (e.KeyChar == '.') {

                if (hasDecimap || string.IsNullOrEmpty((sender as TextBox).Text))
                {
                    e.Handled = true;
                }
            }

            if (textBox1.TextLength >= 5 && e.KeyChar != (char)Keys.Back) {
            
                e.Handled= true;

            }


        }




        private void cmbTipoMetal_SelectdIndexChangend(object sender, EventArgs e)
        {
            if (cmbTipoMatal.SelectedItem.ToString() == "Oro" || cmbTipoMatal.SelectedItem.ToString() == "Oro blanco")
            {
                txtTipoMetal.Enabled = false;
                txtTipoMetal.Text = string.Empty;

            }
            else
            {
                txtTipoMetal.Enabled = true;
            }

        }



        private void CargarDatosComboBox()
        {
            cmbTipoMatal.Items.Add("Oro");
            cmbTipoMatal.Items.Add("Oro blanco");
            cmbTipoMatal.Items.Add("Otro");
        }



        private void AgregarMetales_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTipoMatal.SelectedItem.ToString() == "Oro" || cmbTipoMatal.SelectedItem.ToString() == "Oro blanco")
            {
                ObtenerDatosOro();

            }else if (cmbTipoMatal.SelectedItem.ToString() == "Otro")
            {
                ObtenerDatosOtro();
            }
            else{

            }

        }

        private void ObtenerDatosOro()
        {
            InvMetale invMetale = new InvMetale
            {
                NombreMetal = cmbTipoMatal.Text,
                Kilataje = txtKilataje.Text,
                Gramos = decimal.Parse(txtGramos.Text)
            };

            _DataAccessLeyer.AgregarMaterial(invMetale);
            Borrar();

        }

        private void ObtenerDatosOtro()
        {
            InvMetale invMetale = new InvMetale
            {
              
                NombreMetal = txtTipoMetal.Text,
                Kilataje = txtKilataje.Text,
                Gramos = decimal.Parse(txtGramos.Text)
            };

            _DataAccessLeyer.AgregarMaterial(invMetale);
            Borrar();

        }


        private void Borrar()
        {
            cmbTipoMatal.Text = "";
            txtTipoMetal.Text = string.Empty;
            txtKilataje.Text = string.Empty;
            txtGramos.Text = string.Empty;

        }
    }
}
