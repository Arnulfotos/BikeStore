using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.DTO;
using BikeStore.Models;

namespace BikeStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            var _FrmMarcas = new FrmMarcas();
            _FrmMarcas.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var _FrmProductos = new FrmProductos();
            _FrmProductos.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var _FrmCategorias = new FrmCategorias();
            _FrmCategorias.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var _FrmProductos = new FrmProductos();
            _FrmProductos.Show();
        }
    }
}
