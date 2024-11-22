namespace BikeStore
{
    partial class BikeStoreRead
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
            this.StaffComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.CustomerListView = new MaterialSkin.Controls.MaterialListBox();
            this.ProductListView = new MaterialSkin.Controls.MaterialListBox();
            this.CustomerData = new MaterialSkin.Controls.MaterialLabel();
            this.ProductData = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // StaffComboBox
            // 
            this.StaffComboBox.AutoResize = false;
            this.StaffComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StaffComboBox.Depth = 0;
            this.StaffComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StaffComboBox.DropDownHeight = 174;
            this.StaffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffComboBox.DropDownWidth = 121;
            this.StaffComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StaffComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.IntegralHeight = false;
            this.StaffComboBox.ItemHeight = 43;
            this.StaffComboBox.Location = new System.Drawing.Point(959, 100);
            this.StaffComboBox.MaxDropDownItems = 4;
            this.StaffComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.StaffComboBox.Name = "StaffComboBox";
            this.StaffComboBox.Size = new System.Drawing.Size(273, 49);
            this.StaffComboBox.StartIndex = 0;
            this.StaffComboBox.TabIndex = 0;
            // 
            // CustomerListView
            // 
            this.CustomerListView.BackColor = System.Drawing.Color.White;
            this.CustomerListView.BorderColor = System.Drawing.Color.LightGray;
            this.CustomerListView.Depth = 0;
            this.CustomerListView.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerListView.Location = new System.Drawing.Point(45, 100);
            this.CustomerListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.SelectedIndex = -1;
            this.CustomerListView.SelectedItem = null;
            this.CustomerListView.Size = new System.Drawing.Size(513, 549);
            this.CustomerListView.TabIndex = 1;
            this.CustomerListView.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // ProductListView
            // 
            this.ProductListView.BackColor = System.Drawing.Color.White;
            this.ProductListView.BorderColor = System.Drawing.Color.LightGray;
            this.ProductListView.Depth = 0;
            this.ProductListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductListView.Location = new System.Drawing.Point(603, 100);
            this.ProductListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.SelectedIndex = -1;
            this.ProductListView.SelectedItem = null;
            this.ProductListView.Size = new System.Drawing.Size(327, 549);
            this.ProductListView.TabIndex = 1;
            this.ProductListView.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.ProductListView_SelectedIndexChanged);
            // 
            // CustomerData
            // 
            this.CustomerData.AutoSize = true;
            this.CustomerData.Depth = 0;
            this.CustomerData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerData.Location = new System.Drawing.Point(42, 671);
            this.CustomerData.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerData.Name = "CustomerData";
            this.CustomerData.Size = new System.Drawing.Size(107, 19);
            this.CustomerData.TabIndex = 2;
            this.CustomerData.Text = "materialLabel1";
            // 
            // ProductData
            // 
            this.ProductData.AutoSize = true;
            this.ProductData.Depth = 0;
            this.ProductData.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductData.Location = new System.Drawing.Point(600, 671);
            this.ProductData.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductData.Name = "ProductData";
            this.ProductData.Size = new System.Drawing.Size(107, 19);
            this.ProductData.TabIndex = 2;
            this.ProductData.Text = "materialLabel1";
            // 
            // BikeStoreRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 750);
            this.Controls.Add(this.ProductData);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.ProductListView);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.StaffComboBox);
            this.Name = "BikeStoreRead";
            this.Text = "BikeStoreRead";
            this.Load += new System.EventHandler(this.BikeStoreRead_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox StaffComboBox;
        private MaterialSkin.Controls.MaterialListBox CustomerListView;
        private MaterialSkin.Controls.MaterialListBox ProductListView;
        private MaterialSkin.Controls.MaterialLabel CustomerData;
        private MaterialSkin.Controls.MaterialLabel ProductData;
    }
}