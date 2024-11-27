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
            this.Refresh = new MaterialSkin.Controls.MaterialButton();
            this.Orders = new MaterialSkin.Controls.MaterialListBox();
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
            this.StaffComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.StaffComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.IntegralHeight = false;
            this.StaffComboBox.ItemHeight = 43;
            this.StaffComboBox.Location = new System.Drawing.Point(36, 731);
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
            this.CustomerListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CustomerListView.Location = new System.Drawing.Point(45, 100);
            this.CustomerListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.SelectedIndex = -1;
            this.CustomerListView.SelectedItem = null;
            this.CustomerListView.Size = new System.Drawing.Size(285, 549);
            this.CustomerListView.TabIndex = 1;
            this.CustomerListView.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.CustomerListView_SelectedIndexChanged);
            // 
            // ProductListView
            // 
            this.ProductListView.BackColor = System.Drawing.Color.White;
            this.ProductListView.BorderColor = System.Drawing.Color.LightGray;
            this.ProductListView.Depth = 0;
            this.ProductListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProductListView.Location = new System.Drawing.Point(365, 100);
            this.ProductListView.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductListView.Name = "ProductListView";
            this.ProductListView.SelectedIndex = -1;
            this.ProductListView.SelectedItem = null;
            this.ProductListView.Size = new System.Drawing.Size(285, 549);
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
            this.ProductData.Location = new System.Drawing.Point(367, 671);
            this.ProductData.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductData.Name = "ProductData";
            this.ProductData.Size = new System.Drawing.Size(107, 19);
            this.ProductData.TabIndex = 2;
            this.ProductData.Text = "materialLabel1";
            // 
            // Refresh
            // 
            this.Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Refresh.Depth = 0;
            this.Refresh.HighEmphasis = true;
            this.Refresh.Icon = null;
            this.Refresh.Location = new System.Drawing.Point(370, 744);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.Refresh.Name = "Refresh";
            this.Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Refresh.Size = new System.Drawing.Size(84, 36);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Refresh";
            this.Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Refresh.UseAccentColor = false;
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.White;
            this.Orders.BorderColor = System.Drawing.Color.LightGray;
            this.Orders.Depth = 0;
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Orders.Location = new System.Drawing.Point(685, 100);
            this.Orders.MouseState = MaterialSkin.MouseState.HOVER;
            this.Orders.Name = "Orders";
            this.Orders.SelectedIndex = -1;
            this.Orders.SelectedItem = null;
            this.Orders.Size = new System.Drawing.Size(285, 549);
            this.Orders.TabIndex = 1;
            this.Orders.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.Orders_SelectedIndexChanged);
            // 
            // BikeStoreRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 833);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.ProductData);
            this.Controls.Add(this.CustomerData);
            this.Controls.Add(this.Orders);
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
        private MaterialSkin.Controls.MaterialButton Refresh;
        private MaterialSkin.Controls.MaterialListBox Orders;
    }
}