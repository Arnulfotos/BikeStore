using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeStore
{
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            var context = new Models.BikeStoresEntities();

            List<Models.category> Categorias = new List<Models.category>();

            Categorias = context.categories.ToList();

           

            Table.DataSource = Categorias;
            Table.AutoGenerateColumns = true;
        }
    }
}
