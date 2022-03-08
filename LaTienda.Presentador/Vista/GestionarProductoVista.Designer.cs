namespace LaTienda.Presentador
{
    partial class GestionarProductoVista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarProductoVista));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCliente = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.TbBuscar = new System.Windows.Forms.TextBox();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.BsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentajeDeIvaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.margenDeGananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoGravadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDeVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStripCliente);
            this.tableLayoutPanel1.Controls.Add(this.labelBuscar);
            this.tableLayoutPanel1.Controls.Add(this.TbBuscar);
            this.tableLayoutPanel1.Controls.Add(this.DgvProducto);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStripCliente
            // 
            this.toolStripCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.toolStripCliente, 2);
            this.toolStripCliente.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCrear,
            this.toolStripButtonModificar,
            this.toolStripButtonEliminar,
            this.toolStripLabel1});
            this.toolStripCliente.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripCliente.Location = new System.Drawing.Point(0, 1);
            this.toolStripCliente.Name = "toolStripCliente";
            this.toolStripCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripCliente.Size = new System.Drawing.Size(621, 35);
            this.toolStripCliente.TabIndex = 0;
            this.toolStripCliente.Text = "toolStrip1";
            // 
            // toolStripButtonCrear
            // 
            this.toolStripButtonCrear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCrear.Image")));
            this.toolStripButtonCrear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrear.Name = "toolStripButtonCrear";
            this.toolStripButtonCrear.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.toolStripButtonCrear.Size = new System.Drawing.Size(36, 32);
            this.toolStripButtonCrear.Text = "Crear";
            this.toolStripButtonCrear.Click += new System.EventHandler(this.ToolStripButtonCrear_Click);
            // 
            // toolStripButtonModificar
            // 
            this.toolStripButtonModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonModificar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonModificar.Image")));
            this.toolStripButtonModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonModificar.Name = "toolStripButtonModificar";
            this.toolStripButtonModificar.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.toolStripButtonModificar.Size = new System.Drawing.Size(36, 32);
            this.toolStripButtonModificar.Text = "Modificar";
            this.toolStripButtonModificar.Click += new System.EventHandler(this.ToolStripButtonModificar_Click);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(36, 32);
            this.toolStripButtonEliminar.Text = "Eliminar";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.ToolStripButtonEliminar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(164, 32);
            this.toolStripLabel1.Text = "Gestionar productos";
            // 
            // labelBuscar
            // 
            this.labelBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(22, 42);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(40, 13);
            this.labelBuscar.TabIndex = 1;
            this.labelBuscar.Text = "Buscar";
            // 
            // TbBuscar
            // 
            this.TbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbBuscar.Location = new System.Drawing.Point(88, 41);
            this.TbBuscar.Name = "TbBuscar";
            this.TbBuscar.Size = new System.Drawing.Size(530, 20);
            this.TbBuscar.TabIndex = 2;
            this.TbBuscar.TextChanged += new System.EventHandler(this.TbBuscar_TextChanged);
            // 
            // DgvProducto
            // 
            this.DgvProducto.AutoGenerateColumns = false;
            this.DgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.porcentajeDeIvaDataGridViewTextBoxColumn,
            this.margenDeGananciaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.rubroDataGridViewTextBoxColumn,
            this.netoGravadoDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.precioDeVentaDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvProducto, 2);
            this.DgvProducto.DataSource = this.BsProducto;
            this.DgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProducto.GridColor = System.Drawing.Color.LightSteelBlue;
            this.DgvProducto.Location = new System.Drawing.Point(3, 63);
            this.DgvProducto.MultiSelect = false;
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.ReadOnly = true;
            this.DgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducto.Size = new System.Drawing.Size(615, 308);
            this.DgvProducto.TabIndex = 3;
            // 
            // BsProducto
            // 
            this.BsProducto.DataSource = typeof(LaTienda.Dominio.Producto);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 88;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoDataGridViewTextBoxColumn.Width = 59;
            // 
            // porcentajeDeIvaDataGridViewTextBoxColumn
            // 
            this.porcentajeDeIvaDataGridViewTextBoxColumn.DataPropertyName = "PorcentajeDeIva";
            this.porcentajeDeIvaDataGridViewTextBoxColumn.HeaderText = "PorcentajeDeIva";
            this.porcentajeDeIvaDataGridViewTextBoxColumn.Name = "porcentajeDeIvaDataGridViewTextBoxColumn";
            this.porcentajeDeIvaDataGridViewTextBoxColumn.ReadOnly = true;
            this.porcentajeDeIvaDataGridViewTextBoxColumn.Width = 112;
            // 
            // margenDeGananciaDataGridViewTextBoxColumn
            // 
            this.margenDeGananciaDataGridViewTextBoxColumn.DataPropertyName = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.HeaderText = "MargenDeGanancia";
            this.margenDeGananciaDataGridViewTextBoxColumn.Name = "margenDeGananciaDataGridViewTextBoxColumn";
            this.margenDeGananciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.margenDeGananciaDataGridViewTextBoxColumn.Width = 128;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.Width = 62;
            // 
            // rubroDataGridViewTextBoxColumn
            // 
            this.rubroDataGridViewTextBoxColumn.DataPropertyName = "Rubro";
            this.rubroDataGridViewTextBoxColumn.HeaderText = "Rubro";
            this.rubroDataGridViewTextBoxColumn.Name = "rubroDataGridViewTextBoxColumn";
            this.rubroDataGridViewTextBoxColumn.ReadOnly = true;
            this.rubroDataGridViewTextBoxColumn.Width = 61;
            // 
            // netoGravadoDataGridViewTextBoxColumn
            // 
            this.netoGravadoDataGridViewTextBoxColumn.DataPropertyName = "NetoGravado";
            this.netoGravadoDataGridViewTextBoxColumn.HeaderText = "NetoGravado";
            this.netoGravadoDataGridViewTextBoxColumn.Name = "netoGravadoDataGridViewTextBoxColumn";
            this.netoGravadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.netoGravadoDataGridViewTextBoxColumn.Width = 96;
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            this.iVADataGridViewTextBoxColumn.ReadOnly = true;
            this.iVADataGridViewTextBoxColumn.Width = 49;
            // 
            // precioDeVentaDataGridViewTextBoxColumn
            // 
            this.precioDeVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioDeVenta";
            this.precioDeVentaDataGridViewTextBoxColumn.HeaderText = "PrecioDeVenta";
            this.precioDeVentaDataGridViewTextBoxColumn.Name = "precioDeVentaDataGridViewTextBoxColumn";
            this.precioDeVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDeVentaDataGridViewTextBoxColumn.Width = 104;
            // 
            // GestionarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GestionarProductoVista";
            this.Text = "Gestionar clientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripCliente.ResumeLayout(false);
            this.toolStripCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripCliente;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrear;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox TbBuscar;
        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.BindingSource BsProducto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentajeDeIvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn margenDeGananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoGravadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDeVentaDataGridViewTextBoxColumn;
    }
}