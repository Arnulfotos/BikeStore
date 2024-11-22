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
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            var context = new Models.BikeStoresEntities();

            List<Models.brand> brands = new List<Models.brand>();

            brands = context.brands.ToList();
            
           var brandsItems = new List<Models.brand>();

            foreach ( var brand in brands)
            {
                brandsItems.Add(brand);
            }

            Table.DataSource = brandsItems;
            Table.AutoGenerateColumns = true;
        }
    }
}
