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

namespace PrototipoDos.Tabajos_Broqueleros
{
    public partial class VerTrabajos : Form
    {
        
        DataAccessLeyer _dataAccessLeyer;

        public VerTrabajos(TallerDbContext _context)
        {
            InitializeComponent();

         //   _context = new TallerDbContext();
            _dataAccessLeyer = new DataAccessLeyer(_context);



        }

        private void VerTrabajos_Load(object sender, EventArgs e)
        {
            CargarPedidos();
        }


        public void MostrarPedidos<T>(List<T> datos)
        {
            GridVerPedidos.DataSource = datos;
        }


        private void CargarPedidos()
        {
            var PedidosBroquelerosEntrada = _dataAccessLeyer.ObtenerPedidosEntrada();
            MostrarPedidos(PedidosBroquelerosEntrada);

        }



    }
}
