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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BikeStore
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            var context = new Models.BikeStoresEntities();

            List<Models.product> products = new List<Models.product>();
            products = context.products.ToList();
            var lstProductos = new List<DtoProducto>();
            foreach (var p in products)
            {
                var product = new DtoProducto()
                {

                    Id = p.product_id,
                    Name = p.product_name,
                    Model = p.product_name,
                    Price = p.list_price
                };

                lstProductos.Add(product);
            }


            Tabla.DataSource = lstProductos;
            Tabla.AutoGenerateColumns = true;
        }
    }
}
