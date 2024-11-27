using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BikeStore
{
    public partial class ReadOrders : MaterialForm
    {

        public order SelectedOrder;
        public BikeStoresEntities context;
        public ReadOrders()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void ReadOrders_Load(object sender, EventArgs e)
        {

            context = new Models.BikeStoresEntities();
            var ClientsList = context.customers.ToList();
            var StoresList = context.stores.ToList();
            var EmpleadosList = context.staffs.ToList();
            var OrderItems = context.order_items.Where(x => x.order_id == SelectedOrder.order_id).ToList();

            OrderID.Text = SelectedOrder.order_id.ToString();

            ClienteOrder.DataSource = ClientsList;
            ClienteOrder.ValueMember = "customer_id";
            ClienteOrder.DisplayMember = "full_name";

            Status.Items.Insert(0,"Activa");
            Status.Items.Insert(1,"Cerrada");
            Status.Items.Insert(2,"Cancelada");
            Status.SelectedIndex = 0;
          
            TiendaOrden.DataSource = StoresList;
            TiendaOrden.ValueMember = "store_id";
            TiendaOrden.DisplayMember = "store_name";

            Fecha_Order.Text = SelectedOrder.order_date.ToShortDateString();
            Fecha_Requerida.Text = SelectedOrder.required_date.ToShortDateString();
            Fecha_Envio.Text = SelectedOrder.shipped_date.HasValue ? SelectedOrder.shipped_date.Value.ToShortDateString() : "";

            Empleado.DataSource = EmpleadosList;
            Empleado.ValueMember = "staff_id";
            Empleado.DisplayMember = "full_name";

            ClienteOrder.SelectedValue = SelectedOrder.customer_id;
            TiendaOrden.SelectedValue = SelectedOrder.store_id;
            Empleado.SelectedValue = SelectedOrder.staff_id;

            ViewOrderItems.AutoGenerateColumns = true ;
            ViewOrderItems.DataSource = OrderItems;
          
            /* Brand.DataSource = BrandList;
             Brand.ValueMember = "brand_id";
             Brand.DisplayMember = "brand_name";

             Cat.DataSource = CatergoryList;
             Cat.ValueMember = "category_id";
             Cat.DisplayMember = "category_name";

             Brand.SelectedValue = SelectedProduct.brand_id;
             Cat.SelectedValue = SelectedProduct.category_id;

             ID.Text = SelectedProduct.product_id.ToString();
             NameProduct.Text = SelectedProduct.product_name.ToString();
             Model.Text = SelectedProduct.model_year.ToString();
             Price.Text = SelectedProduct.list_price.ToString();*/


        }
    }
}
