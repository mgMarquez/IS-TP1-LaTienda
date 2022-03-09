namespace LaTienda.Presentador
{
    partial class GestionarStockVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarStockVista));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripStock = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.TbBuscar = new System.Windows.Forms.TextBox();
            this.DgvStock = new System.Windows.Forms.DataGridView();
            this.BsStock = new System.Windows.Forms.BindingSource(this.components);
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadEnStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStripStock);
            this.tableLayoutPanel1.Controls.Add(this.labelBuscar);
            this.tableLayoutPanel1.Controls.Add(this.TbBuscar);
            this.tableLayoutPanel1.Controls.Add(this.DgvStock);
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
            // toolStripStock
            // 
            this.toolStripStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.toolStripStock, 2);
            this.toolStripStock.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCrear,
            this.toolStripButtonModificar,
            this.toolStripButtonEliminar,
            this.toolStripLabel1});
            this.toolStripStock.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripStock.Location = new System.Drawing.Point(0, 1);
            this.toolStripStock.Name = "toolStripStock";
            this.toolStripStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStock.Size = new System.Drawing.Size(621, 35);
            this.toolStripStock.TabIndex = 0;
            this.toolStripStock.Text = "toolStrip1";
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
            this.toolStripLabel1.Size = new System.Drawing.Size(129, 32);
            this.toolStripLabel1.Text = "Gestionar Stock";
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
            // DgvStock
            // 
            this.DgvStock.AutoGenerateColumns = false;
            this.DgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockID,
            this.productoDataGridViewTextBoxColumn,
            this.talleDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.cantidadEnStockDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvStock, 2);
            this.DgvStock.DataSource = this.BsStock;
            this.DgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStock.GridColor = System.Drawing.Color.LightSteelBlue;
            this.DgvStock.Location = new System.Drawing.Point(3, 63);
            this.DgvStock.MultiSelect = false;
            this.DgvStock.Name = "DgvStock";
            this.DgvStock.ReadOnly = true;
            this.DgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStock.Size = new System.Drawing.Size(615, 308);
            this.DgvStock.TabIndex = 3;
            // 
            // BsStock
            // 
            this.BsStock.DataSource = typeof(LaTienda.Dominio.Stock);
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            this.StockID.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // talleDataGridViewTextBoxColumn
            // 
            this.talleDataGridViewTextBoxColumn.DataPropertyName = "Talle";
            this.talleDataGridViewTextBoxColumn.HeaderText = "Talle";
            this.talleDataGridViewTextBoxColumn.Name = "talleDataGridViewTextBoxColumn";
            this.talleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadEnStockDataGridViewTextBoxColumn
            // 
            this.cantidadEnStockDataGridViewTextBoxColumn.DataPropertyName = "CantidadEnStock";
            this.cantidadEnStockDataGridViewTextBoxColumn.HeaderText = "CantidadEnStock";
            this.cantidadEnStockDataGridViewTextBoxColumn.Name = "cantidadEnStockDataGridViewTextBoxColumn";
            this.cantidadEnStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GestionarStockVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GestionarStockVista";
            this.Text = "Gestionar clientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripStock.ResumeLayout(false);
            this.toolStripStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripStock;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrear;
        private System.Windows.Forms.ToolStripButton toolStripButtonModificar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox TbBuscar;
        private System.Windows.Forms.DataGridView DgvStock;
        private System.Windows.Forms.BindingSource BsStock;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn talleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadEnStockDataGridViewTextBoxColumn;
    }
}