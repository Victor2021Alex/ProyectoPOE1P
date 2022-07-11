namespace ProyectoPOE
{
    partial class InventarioStock
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_FiltrarStock = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_ListaProductos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CantidadRegistros = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(820, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "+Agregar Producto";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1067, 65);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "- Eliminar Producto";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cmb_FiltrarStock
            // 
            this.cmb_FiltrarStock.BackColor = System.Drawing.Color.DarkGray;
            this.cmb_FiltrarStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FiltrarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_FiltrarStock.FormattingEnabled = true;
            this.cmb_FiltrarStock.Items.AddRange(new object[] {
            "ABARROTES",
            "PRODUCTOS ENLATADOS",
            "LÁCTEOS",
            "BOTANAS",
            "CONFITERÍA/DULCERIA",
            "HARINAS Y PAN",
            "FRUTAS Y VERDURAS",
            "BEBIDAS",
            "ALIMENTOS PREPARADOS",
            "AUTOMEDICACIÓN",
            "HIGIENE PERSONAL:"});
            this.cmb_FiltrarStock.Location = new System.Drawing.Point(21, 85);
            this.cmb_FiltrarStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_FiltrarStock.Name = "cmb_FiltrarStock";
            this.cmb_FiltrarStock.Size = new System.Drawing.Size(234, 37);
            this.cmb_FiltrarStock.TabIndex = 2;
            this.cmb_FiltrarStock.SelectedIndexChanged += new System.EventHandler(this.cmb_FiltrarStock_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_ListaProductos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(17, 139);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1279, 613);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Productos";
            // 
            // lv_ListaProductos
            // 
            this.lv_ListaProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_ListaProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_ListaProductos.Location = new System.Drawing.Point(4, 29);
            this.lv_ListaProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lv_ListaProductos.Name = "lv_ListaProductos";
            this.lv_ListaProductos.Size = new System.Drawing.Size(1271, 579);
            this.lv_ListaProductos.TabIndex = 0;
            this.lv_ListaProductos.UseCompatibleStateImageBehavior = false;
            this.lv_ListaProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Articulo";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Precio";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha Caducidad";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ubicacion";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Estado";
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Proveedor";
            this.columnHeader9.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 757);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad de registros:";
            // 
            // lbl_CantidadRegistros
            // 
            this.lbl_CantidadRegistros.AutoSize = true;
            this.lbl_CantidadRegistros.Location = new System.Drawing.Point(215, 757);
            this.lbl_CantidadRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CantidadRegistros.Name = "lbl_CantidadRegistros";
            this.lbl_CantidadRegistros.Size = new System.Drawing.Size(47, 25);
            this.lbl_CantidadRegistros.TabIndex = 5;
            this.lbl_CantidadRegistros.Text = "_____";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(182, 34);
            this.btn_Regresar.TabIndex = 6;
            this.btn_Regresar.Text = "<- Regresar al menu";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // InventarioStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 798);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.lbl_CantidadRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_FiltrarStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventarioStock";
            this.Text = "Stock";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private ComboBox cmb_FiltrarStock;
        private GroupBox groupBox1;
        private ListView lv_ListaProductos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label1;
        private Label lbl_CantidadRegistros;
        private Button btn_Regresar;
    }
}