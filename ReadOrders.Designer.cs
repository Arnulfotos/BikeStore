namespace BikeStore
{
    partial class ReadOrders
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
            this.OrderID = new MaterialSkin.Controls.MaterialTextBox();
            this.ClienteOrder = new MaterialSkin.Controls.MaterialComboBox();
            this.Status = new MaterialSkin.Controls.MaterialComboBox();
            this.TiendaOrden = new MaterialSkin.Controls.MaterialComboBox();
            this.Fecha_Order = new MaterialSkin.Controls.MaterialTextBox();
            this.Fecha_Requerida = new MaterialSkin.Controls.MaterialTextBox();
            this.Fecha_Envio = new MaterialSkin.Controls.MaterialTextBox();
            this.Empleado = new MaterialSkin.Controls.MaterialComboBox();
            this.ViewOrderItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderID
            // 
            this.OrderID.AnimateReadOnly = true;
            this.OrderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderID.Depth = 0;
            this.OrderID.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.OrderID.Hint = "ID";
            this.OrderID.LeadingIcon = null;
            this.OrderID.Location = new System.Drawing.Point(52, 113);
            this.OrderID.MaxLength = 50;
            this.OrderID.MouseState = MaterialSkin.MouseState.OUT;
            this.OrderID.Multiline = false;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Size = new System.Drawing.Size(100, 50);
            this.OrderID.TabIndex = 0;
            this.OrderID.Text = "";
            this.OrderID.TrailingIcon = null;
            // 
            // ClienteOrder
            // 
            this.ClienteOrder.AutoResize = false;
            this.ClienteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClienteOrder.Depth = 0;
            this.ClienteOrder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClienteOrder.DropDownHeight = 174;
            this.ClienteOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteOrder.DropDownWidth = 121;
            this.ClienteOrder.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ClienteOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClienteOrder.FormattingEnabled = true;
            this.ClienteOrder.Hint = "Cliente";
            this.ClienteOrder.IntegralHeight = false;
            this.ClienteOrder.ItemHeight = 43;
            this.ClienteOrder.Location = new System.Drawing.Point(205, 114);
            this.ClienteOrder.MaxDropDownItems = 4;
            this.ClienteOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.ClienteOrder.Name = "ClienteOrder";
            this.ClienteOrder.Size = new System.Drawing.Size(207, 49);
            this.ClienteOrder.StartIndex = 0;
            this.ClienteOrder.TabIndex = 1;
            // 
            // Status
            // 
            this.Status.AutoResize = false;
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Status.Depth = 0;
            this.Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Status.DropDownHeight = 174;
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.DropDownWidth = 121;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.FormattingEnabled = true;
            this.Status.Hint = "Estatus";
            this.Status.IntegralHeight = false;
            this.Status.ItemHeight = 43;
            this.Status.Location = new System.Drawing.Point(465, 114);
            this.Status.MaxDropDownItems = 4;
            this.Status.MouseState = MaterialSkin.MouseState.OUT;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(207, 49);
            this.Status.StartIndex = 0;
            this.Status.TabIndex = 1;
            // 
            // TiendaOrden
            // 
            this.TiendaOrden.AutoResize = false;
            this.TiendaOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TiendaOrden.Depth = 0;
            this.TiendaOrden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TiendaOrden.DropDownHeight = 174;
            this.TiendaOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TiendaOrden.DropDownWidth = 121;
            this.TiendaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TiendaOrden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TiendaOrden.FormattingEnabled = true;
            this.TiendaOrden.Hint = "Tienda";
            this.TiendaOrden.IntegralHeight = false;
            this.TiendaOrden.ItemHeight = 43;
            this.TiendaOrden.Location = new System.Drawing.Point(725, 114);
            this.TiendaOrden.MaxDropDownItems = 4;
            this.TiendaOrden.MouseState = MaterialSkin.MouseState.OUT;
            this.TiendaOrden.Name = "TiendaOrden";
            this.TiendaOrden.Size = new System.Drawing.Size(207, 49);
            this.TiendaOrden.StartIndex = 0;
            this.TiendaOrden.TabIndex = 1;
            // 
            // Fecha_Order
            // 
            this.Fecha_Order.AnimateReadOnly = false;
            this.Fecha_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fecha_Order.Depth = 0;
            this.Fecha_Order.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Fecha_Order.Hint = "Fecha";
            this.Fecha_Order.LeadingIcon = null;
            this.Fecha_Order.Location = new System.Drawing.Point(52, 219);
            this.Fecha_Order.MaxLength = 50;
            this.Fecha_Order.MouseState = MaterialSkin.MouseState.OUT;
            this.Fecha_Order.Multiline = false;
            this.Fecha_Order.Name = "Fecha_Order";
            this.Fecha_Order.Size = new System.Drawing.Size(193, 50);
            this.Fecha_Order.TabIndex = 2;
            this.Fecha_Order.Text = "";
            this.Fecha_Order.TrailingIcon = null;
            // 
            // Fecha_Requerida
            // 
            this.Fecha_Requerida.AnimateReadOnly = false;
            this.Fecha_Requerida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fecha_Requerida.Depth = 0;
            this.Fecha_Requerida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Fecha_Requerida.Hint = "Fecha Requerida";
            this.Fecha_Requerida.LeadingIcon = null;
            this.Fecha_Requerida.Location = new System.Drawing.Point(293, 220);
            this.Fecha_Requerida.MaxLength = 50;
            this.Fecha_Requerida.MouseState = MaterialSkin.MouseState.OUT;
            this.Fecha_Requerida.Multiline = false;
            this.Fecha_Requerida.Name = "Fecha_Requerida";
            this.Fecha_Requerida.Size = new System.Drawing.Size(193, 50);
            this.Fecha_Requerida.TabIndex = 2;
            this.Fecha_Requerida.Text = "";
            this.Fecha_Requerida.TrailingIcon = null;
            // 
            // Fecha_Envio
            // 
            this.Fecha_Envio.AnimateReadOnly = false;
            this.Fecha_Envio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Fecha_Envio.Depth = 0;
            this.Fecha_Envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Fecha_Envio.Hint = "Fecha Envio";
            this.Fecha_Envio.LeadingIcon = null;
            this.Fecha_Envio.Location = new System.Drawing.Point(534, 220);
            this.Fecha_Envio.MaxLength = 50;
            this.Fecha_Envio.MouseState = MaterialSkin.MouseState.OUT;
            this.Fecha_Envio.Multiline = false;
            this.Fecha_Envio.Name = "Fecha_Envio";
            this.Fecha_Envio.Size = new System.Drawing.Size(193, 50);
            this.Fecha_Envio.TabIndex = 2;
            this.Fecha_Envio.Text = "";
            this.Fecha_Envio.TrailingIcon = null;
            // 
            // Empleado
            // 
            this.Empleado.AutoResize = false;
            this.Empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Empleado.Depth = 0;
            this.Empleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Empleado.DropDownHeight = 174;
            this.Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Empleado.DropDownWidth = 121;
            this.Empleado.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Empleado.FormattingEnabled = true;
            this.Empleado.Hint = "Empleado";
            this.Empleado.IntegralHeight = false;
            this.Empleado.ItemHeight = 43;
            this.Empleado.Location = new System.Drawing.Point(775, 221);
            this.Empleado.MaxDropDownItems = 4;
            this.Empleado.MouseState = MaterialSkin.MouseState.OUT;
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(193, 49);
            this.Empleado.StartIndex = 0;
            this.Empleado.TabIndex = 3;
            // 
            // ViewOrderItems
            // 
            this.ViewOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrderItems.Location = new System.Drawing.Point(52, 305);
            this.ViewOrderItems.Name = "ViewOrderItems";
            this.ViewOrderItems.Size = new System.Drawing.Size(1073, 437);
            this.ViewOrderItems.TabIndex = 4;
            // 
            // ReadOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 797);
            this.Controls.Add(this.ViewOrderItems);
            this.Controls.Add(this.Empleado);
            this.Controls.Add(this.Fecha_Envio);
            this.Controls.Add(this.Fecha_Requerida);
            this.Controls.Add(this.Fecha_Order);
            this.Controls.Add(this.TiendaOrden);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ClienteOrder);
            this.Controls.Add(this.OrderID);
            this.Name = "ReadOrders";
            this.Text = "ReadOrders";
            this.Load += new System.EventHandler(this.ReadOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox OrderID;
        private MaterialSkin.Controls.MaterialComboBox ClienteOrder;
        private MaterialSkin.Controls.MaterialComboBox Status;
        private MaterialSkin.Controls.MaterialComboBox TiendaOrden;
        private MaterialSkin.Controls.MaterialTextBox Fecha_Order;
        private MaterialSkin.Controls.MaterialTextBox Fecha_Requerida;
        private MaterialSkin.Controls.MaterialTextBox Fecha_Envio;
        private MaterialSkin.Controls.MaterialComboBox Empleado;
        private System.Windows.Forms.DataGridView ViewOrderItems;
    }
}