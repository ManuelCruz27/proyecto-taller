using PrototipoDos.Empleados;
using PrototipoDos.Inventario;
using PrototipoDos.Models;
using PrototipoDos.Pedido_Broqueleros;
using PrototipoDos.Tabajos_Broqueleros;

namespace PrototipoDos
{
    public partial class MenuPrincipal : Form
    {

        private readonly TallerDbContext _context;
        private readonly DataAccessLeyer _dataAccessLayer;

        private Form _currentForm;

        public MenuPrincipal()
        {
            InitializeComponent();
            _context = new TallerDbContext();
            _dataAccessLayer = new DataAccessLeyer(_context);
            _currentForm = null;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            this.Size = new Size(screenSize.Width, screenSize.Height);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form verEmpleados = new VerEmpleados();
            //verEmpleados.TopLevel = false;
            //panel1.Controls.Add(verEmpleados);
            //verEmpleados.FormBorderStyle = FormBorderStyle.FixedDialog;
            //// verEmpleados.Dock = DockStyle.Fill;
            //verEmpleados.Show();

            AbrirFormulario(new VerEmpleados());

        }


        private void AbrirFormulario(Form form)
        {
            if (_currentForm != null)
            {
                _currentForm.Close();
            }

            _currentForm = form;
            _currentForm.TopLevel = false;
            panel1.Controls.Add(_currentForm);
            _currentForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            _currentForm.Show();
        }



        private void MenuPrincipal_Resize(object sender, EventArgs e)
        {
            panel1.Size = this.ClientSize;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void actualizarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form actualizar = new ActualizarDatos(_context);
            //actualizar.TopLevel = false;
            //panel1.Controls.Add(actualizar);
            //actualizar.FormBorderStyle = FormBorderStyle.FixedDialog;

            //actualizar.Show();

            AbrirFormulario(new ActualizarDatos(_context));


        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new AgregarProducto(_context));
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarMetalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new AgregarMetales(_context));

        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new CrearPedidoBroqueleros(_context));
        }

        private void verTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new VerTrabajos(_context));
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FinalizarPedidos(_context));
        }
    }
}
