using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStore.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BikeStore
{
    public partial class BikeStoreRead : MaterialForm
    {
        bool Start = true;
        public BikeStoreRead()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void BikeStoreRead_Load(object sender, EventArgs e)
        {
            var context = new Models.BikeStoresEntities();

            //Acceder a datos 
            List<Models.customer> CustomerList = context.customers.ToList();
            List<Models.product> ProductList = context.products.ToList();
            List<Models.staff> StaffList = context.staffs.ToList();
            List<Models.order> OrdersList = context.orders.ToList();

            foreach (var Customer in CustomerList)
            {
                CustomerListView.Items.Add(new MaterialListBoxItem { Text = $"{Customer.first_name} {Customer.last_name} {Customer.email}" });
            }
            foreach (var Product in ProductList)
            {
               ProductListView.Items.Add(new MaterialListBoxItem { Text = $"{Product.product_name} {Product.list_price}", Tag = Product });
            }
            foreach (var Order in OrdersList)
            {
                Orders.Items.Add(new MaterialListBoxItem { Text = $"{Order.order_id} {Order.customer.full_name}", Tag = Order });
            }

            /*foreach (var Member in StaffList)
            {
                StaffComboBox.Items.Add(new MaterialListBoxItem { Text = $"{Member.first_name}" });
            }*/
            //Combo marcas con un origen de datos



            StaffComboBox.DataSource = StaffList;
            StaffComboBox.ValueMember = "staff_id";
            StaffComboBox.DisplayMember = "first_name";
            /*
            label4.Text = "";
            label5.Text = "";*/
            Start = false;
        }

        private void CustomerListView_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            CustomerData.Text = selectedItem.Text;
        }

        private void ProductListView_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

            var itemSelected = ProductListView.SelectedItem.Tag;

            if (!Start)
            {
                var newAddOrEditProduct = new AddOrEditProducts();
                newAddOrEditProduct.SelectedProduct = (product) itemSelected;
                newAddOrEditProduct.ShowDialog();

                



            }
            //ProductData.Text = selectedItem.Text;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            var context = new Models.BikeStoresEntities();

            ProductListView.Items.Clear();
            List<Models.product> ProductList = context.products.ToList();


            foreach (var Product in ProductList)
            {
                ProductListView.Items.Add(new MaterialListBoxItem { Text = $"{Product.product_name} {Product.list_price}", Tag = Product });
            }

            Start = true;
        }

        private void Orders_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            var itemSelected = Orders.SelectedItem.Tag;

            if (!Start)
            {
                var newReadOrders = new ReadOrders();
                newReadOrders.SelectedOrder = (order)itemSelected;
                newReadOrders.ShowDialog();





            }
        }
    }
}
