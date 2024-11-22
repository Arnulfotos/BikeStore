namespace BikeStore
{
    partial class AddOrEditProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.Model = new MaterialSkin.Controls.MaterialTextBox();
            this.Price = new MaterialSkin.Controls.MaterialTextBox();
            this.Brand = new MaterialSkin.Controls.MaterialComboBox();
            this.Cat = new MaterialSkin.Controls.MaterialComboBox();
            this.ID = new MaterialSkin.Controls.MaterialTextBox();
            this.materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            this.Cancel = new MaterialSkin.Controls.MaterialButton();
            this.Aceptar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // NameProduct
            // 
            this.NameProduct.AnimateReadOnly = false;
            this.NameProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameProduct.Depth = 0;
            this.NameProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NameProduct.Hint = "Nombre";
            this.NameProduct.LeadingIcon = null;
            this.NameProduct.Location = new System.Drawing.Point(29, 131);
            this.NameProduct.MaxLength = 50;
            this.NameProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.NameProduct.Multiline = false;
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(704, 50);
            this.NameProduct.TabIndex = 1;
            this.NameProduct.Text = "";
            this.NameProduct.TrailingIcon = null;
            // 
            // Model
            // 
            this.Model.AnimateReadOnly = false;
            this.Model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Model.Depth = 0;
            this.Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Model.Hint = "Modelo";
            this.Model.LeadingIcon = null;
            this.Model.Location = new System.Drawing.Point(29, 281);
            this.Model.MaxLength = 50;
            this.Model.MouseState = MaterialSkin.MouseState.OUT;
            this.Model.Multiline = false;
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(337, 50);
            this.Model.TabIndex = 1;
            this.Model.Text = "";
            this.Model.TrailingIcon = null;
            // 
            // Price
            // 
            this.Price.AnimateReadOnly = false;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Depth = 0;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Price.Hint = "Precio";
            this.Price.LeadingIcon = null;
            this.Price.Location = new System.Drawing.Point(396, 281);
            this.Price.MaxLength = 50;
            this.Price.MouseState = MaterialSkin.MouseState.OUT;
            this.Price.Multiline = false;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(337, 50);
            this.Price.TabIndex = 1;
            this.Price.Text = "";
            this.Price.TrailingIcon = null;
            // 
            // Brand
            // 
            this.Brand.AutoResize = false;
            this.Brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Brand.Depth = 0;
            this.Brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Brand.DropDownHeight = 174;
            this.Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Brand.DropDownWidth = 121;
            this.Brand.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Brand.FormattingEnabled = true;
            this.Brand.Hint = "Marca";
            this.Brand.IntegralHeight = false;
            this.Brand.ItemHeight = 43;
            this.Brand.Location = new System.Drawing.Point(29, 208);
            this.Brand.MaxDropDownItems = 4;
            this.Brand.MouseState = MaterialSkin.MouseState.OUT;
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(337, 49);
            this.Brand.StartIndex = 0;
            this.Brand.TabIndex = 2;
            // 
            // Cat
            // 
            this.Cat.AutoResize = false;
            this.Cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cat.Depth = 0;
            this.Cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Cat.DropDownHeight = 174;
            this.Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cat.DropDownWidth = 121;
            this.Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cat.FormattingEnabled = true;
            this.Cat.Hint = "Categoria";
            this.Cat.IntegralHeight = false;
            this.Cat.ItemHeight = 43;
            this.Cat.Location = new System.Drawing.Point(396, 208);
            this.Cat.MaxDropDownItems = 4;
            this.Cat.MouseState = MaterialSkin.MouseState.OUT;
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(337, 49);
            this.Cat.StartIndex = 0;
            this.Cat.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AnimateReadOnly = true;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID.Depth = 0;
            this.ID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ID.Hint = "ID";
            this.ID.LeadingIcon = null;
            this.ID.Location = new System.Drawing.Point(29, 75);
            this.ID.MaxLength = 50;
            this.ID.MouseState = MaterialSkin.MouseState.OUT;
            this.ID.Multiline = false;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(138, 36);
            this.ID.TabIndex = 3;
            this.ID.Text = "";
            this.ID.TrailingIcon = null;
            this.ID.UseAccent = false;
            this.ID.UseTallSize = false;
            // 
            // materialScrollBar1
            // 
            this.materialScrollBar1.Depth = 0;
            this.materialScrollBar1.Location = new System.Drawing.Point(784, 75);
            this.materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialScrollBar1.Name = "materialScrollBar1";
            this.materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            this.materialScrollBar1.Size = new System.Drawing.Size(10, 274);
            this.materialScrollBar1.TabIndex = 4;
            this.materialScrollBar1.Text = "materialScrollBar1";
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Cancel.Depth = 0;
            this.Cancel.HighEmphasis = true;
            this.Cancel.Icon = null;
            this.Cancel.Location = new System.Drawing.Point(543, 376);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Cancel.Name = "Cancel";
            this.Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Cancel.Size = new System.Drawing.Size(96, 36);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancelar";
            this.Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Cancel.UseAccentColor = true;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Aceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Aceptar.Depth = 0;
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.HighEmphasis = true;
            this.Aceptar.Icon = null;
            this.Aceptar.Location = new System.Drawing.Point(647, 376);
            this.Aceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Aceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Aceptar.Size = new System.Drawing.Size(86, 36);
            this.Aceptar.TabIndex = 5;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Aceptar.UseAccentColor = false;
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // AddOrEditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.materialScrollBar1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.NameProduct);
            this.Name = "AddOrEditProducts";
            this.Text = "AddOrEditProducts";
            this.Load += new System.EventHandler(this.AddOrEditProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox NameProduct;
        private MaterialSkin.Controls.MaterialTextBox Model;
        private MaterialSkin.Controls.MaterialTextBox Price;
        private MaterialSkin.Controls.MaterialComboBox Brand;
        private MaterialSkin.Controls.MaterialComboBox Cat;
        private MaterialSkin.Controls.MaterialTextBox ID;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private MaterialSkin.Controls.MaterialButton Cancel;
        private MaterialSkin.Controls.MaterialButton Aceptar;
    }
}