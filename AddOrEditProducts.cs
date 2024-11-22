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
    public partial class AddOrEditProducts : MaterialForm
    {
        public product SelectedProduct;
        public BikeStoresEntities context;
        public AddOrEditProducts()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void AddOrEditProducts_Load(object sender, EventArgs e)
        {
            context = new Models.BikeStoresEntities();
            var BrandList = context.brands.ToList();
            var CatergoryList = context.categories.ToList();

            Brand.DataSource = BrandList;
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
            Price.Text = SelectedProduct.list_price.ToString();



        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if(context == null)
            {
                context = new BikeStoresEntities();
            }

            int ProductID = int.Parse(ID.Text);

            var Product2Edit = context.products.FirstOrDefault(x => x.product_id == ProductID); 

            if(Product2Edit != null)
            {
                Product2Edit.product_name = NameProduct.Text;
                Product2Edit.list_price = decimal.Parse(Price.Text);
                Product2Edit.model_year = short.Parse(Model.Text);
                Product2Edit.brand_id = int.Parse(Brand.SelectedValue.ToString());
                Product2Edit.category_id = int.Parse(Cat.SelectedValue.ToString());

                context.SaveChanges();

                MessageBox.Show("Registro actualizado correctamente");

                this.Close();

            }
            else{
                MessageBox.Show("Ocurrio un error");

            }

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
