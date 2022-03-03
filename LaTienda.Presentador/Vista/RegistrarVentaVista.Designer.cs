namespace LaTienda.Presentador.Vista
{
    partial class RegistrarVentaVista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.nudCantidadProductos = new System.Windows.Forms.NumericUpDown();
            this.btAgregarProducto = new System.Windows.Forms.Button();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.bsStock = new System.Windows.Forms.BindingSource(this.components);
            this.tbStock = new System.Windows.Forms.TextBox();
            this.cbTalle = new System.Windows.Forms.ComboBox();
            this.btBuscarProducto = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbRubro = new System.Windows.Forms.TextBox();
            this.bsRubro = new System.Windows.Forms.BindingSource(this.components);
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGVDetalleVenta = new System.Windows.Forms.DataGridView();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVATotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoGravadoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDeVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbNeto = new System.Windows.Forms.TextBox();
            this.tbIva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDeVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.nudCantidadProductos);
            this.groupBox1.Controls.Add(this.btAgregarProducto);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.tbStock);
            this.groupBox1.Controls.Add(this.cbTalle);
            this.groupBox1.Controls.Add(this.btBuscarProducto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMarca);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.tbRubro);
            this.groupBox1.Controls.Add(this.tbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PrecioDeVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.textBox1.Location = new System.Drawing.Point(383, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LaTienda.Dominio.Producto);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(287, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Precio de venta";
            // 
            // nudCantidadProductos
            // 
            this.nudCantidadProductos.Location = new System.Drawing.Point(315, 160);
            this.nudCantidadProductos.Name = "nudCantidadProductos";
            this.nudCantidadProductos.Size = new System.Drawing.Size(78, 20);
            this.nudCantidadProductos.TabIndex = 0;
            // 
            // btAgregarProducto
            // 
            this.btAgregarProducto.Location = new System.Drawing.Point(408, 157);
            this.btAgregarProducto.Name = "btAgregarProducto";
            this.btAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btAgregarProducto.TabIndex = 2;
            this.btAgregarProducto.Text = "Agregar";
            this.btAgregarProducto.UseVisualStyleBackColor = true;
            this.btAgregarProducto.Click += new System.EventHandler(this.BtAgregarProducto_Click);
            // 
            // cbColor
            // 
            this.cbColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "Color", true));
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(235, 131);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(124, 21);
            this.cbColor.TabIndex = 3;
            this.cbColor.SelectedValueChanged += new System.EventHandler(this.CbColor_SelectedValueChanged);
            // 
            // bsStock
            // 
            this.bsStock.DataSource = typeof(LaTienda.Dominio.Stock);
            // 
            // tbStock
            // 
            this.tbStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "CantidadEnStock", true));
            this.tbStock.Enabled = false;
            this.tbStock.Location = new System.Drawing.Point(417, 131);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(66, 20);
            this.tbStock.TabIndex = 0;
            // 
            // cbTalle
            // 
            this.cbTalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "Talle", true));
            this.cbTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTalle.FormattingEnabled = true;
            this.cbTalle.Location = new System.Drawing.Point(52, 131);
            this.cbTalle.Name = "cbTalle";
            this.cbTalle.Size = new System.Drawing.Size(124, 21);
            this.cbTalle.TabIndex = 3;
            this.cbTalle.SelectedValueChanged += new System.EventHandler(this.CbTalle_SelectedValueChanged);
            // 
            // btBuscarProducto
            // 
            this.btBuscarProducto.Location = new System.Drawing.Point(408, 22);
            this.btBuscarProducto.Name = "btBuscarProducto";
            this.btBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btBuscarProducto.TabIndex = 2;
            this.btBuscarProducto.Text = "Buscar";
            this.btBuscarProducto.UseVisualStyleBackColor = true;
            this.btBuscarProducto.Click += new System.EventHandler(this.BtBuscarProducto_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Agregar la cantidad de productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Talle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rubro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // tbMarca
            // 
            this.tbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMarca, "Descripcion", true));
            this.tbMarca.Enabled = false;
            this.tbMarca.Location = new System.Drawing.Point(290, 51);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(193, 20);
            this.tbMarca.TabIndex = 0;
            // 
            // bsMarca
            // 
            this.bsMarca.DataSource = typeof(LaTienda.Dominio.Marca);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true));
            this.tbDescripcion.Enabled = false;
            this.tbDescripcion.Location = new System.Drawing.Point(75, 77);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(408, 20);
            this.tbDescripcion.TabIndex = 0;
            // 
            // tbRubro
            // 
            this.tbRubro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRubro, "Descripcion", true));
            this.tbRubro.Enabled = false;
            this.tbRubro.Location = new System.Drawing.Point(52, 51);
            this.tbRubro.Name = "tbRubro";
            this.tbRubro.Size = new System.Drawing.Size(168, 20);
            this.tbRubro.TabIndex = 0;
            // 
            // bsRubro
            // 
            this.bsRubro.DataSource = typeof(LaTienda.Dominio.Rubro);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(52, 24);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(307, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGVDetalleVenta);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de venta";
            // 
            // dataGVDetalleVenta
            // 
            this.dataGVDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVDetalleVenta.AutoGenerateColumns = false;
            this.dataGVDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProductoDataGridViewTextBoxColumn,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.marcaProductoDataGridViewTextBoxColumn,
            this.descripcionColorDataGridViewTextBoxColumn,
            this.descripcionTalleDataGridViewTextBoxColumn,
            this.iVATotalDataGridViewTextBoxColumn,
            this.netoGravadoTotalDataGridViewTextBoxColumn,
            this.precioProductoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dataGVDetalleVenta.DataSource = this.lineaDeVentaBindingSource;
            this.dataGVDetalleVenta.Location = new System.Drawing.Point(9, 48);
            this.dataGVDetalleVenta.Name = "dataGVDetalleVenta";
            this.dataGVDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVDetalleVenta.Size = new System.Drawing.Size(474, 162);
            this.dataGVDetalleVenta.TabIndex = 3;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.FillWeight = 232.0186F;
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoProductoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionProducto";
            this.descripcionProductoDataGridViewTextBoxColumn.FillWeight = 180.9394F;
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            this.descripcionProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionProductoDataGridViewTextBoxColumn.Width = 88;
            // 
            // marcaProductoDataGridViewTextBoxColumn
            // 
            this.marcaProductoDataGridViewTextBoxColumn.DataPropertyName = "MarcaProducto";
            this.marcaProductoDataGridViewTextBoxColumn.FillWeight = 141.7122F;
            this.marcaProductoDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaProductoDataGridViewTextBoxColumn.Name = "marcaProductoDataGridViewTextBoxColumn";
            this.marcaProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaProductoDataGridViewTextBoxColumn.Width = 62;
            // 
            // descripcionColorDataGridViewTextBoxColumn
            // 
            this.descripcionColorDataGridViewTextBoxColumn.DataPropertyName = "DescripcionColor";
            this.descripcionColorDataGridViewTextBoxColumn.FillWeight = 111.587F;
            this.descripcionColorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.descripcionColorDataGridViewTextBoxColumn.Name = "descripcionColorDataGridViewTextBoxColumn";
            this.descripcionColorDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionColorDataGridViewTextBoxColumn.Width = 56;
            // 
            // descripcionTalleDataGridViewTextBoxColumn
            // 
            this.descripcionTalleDataGridViewTextBoxColumn.DataPropertyName = "DescripcionTalle";
            this.descripcionTalleDataGridViewTextBoxColumn.FillWeight = 88.45189F;
            this.descripcionTalleDataGridViewTextBoxColumn.HeaderText = "Talle";
            this.descripcionTalleDataGridViewTextBoxColumn.Name = "descripcionTalleDataGridViewTextBoxColumn";
            this.descripcionTalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionTalleDataGridViewTextBoxColumn.Width = 55;
            // 
            // iVATotalDataGridViewTextBoxColumn
            // 
            this.iVATotalDataGridViewTextBoxColumn.DataPropertyName = "IVATotal";
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.iVATotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.iVATotalDataGridViewTextBoxColumn.FillWeight = 70.68504F;
            this.iVATotalDataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVATotalDataGridViewTextBoxColumn.Name = "iVATotalDataGridViewTextBoxColumn";
            this.iVATotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.iVATotalDataGridViewTextBoxColumn.Width = 49;
            // 
            // netoGravadoTotalDataGridViewTextBoxColumn
            // 
            this.netoGravadoTotalDataGridViewTextBoxColumn.DataPropertyName = "NetoGravadoTotal";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.netoGravadoTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.netoGravadoTotalDataGridViewTextBoxColumn.FillWeight = 57.10493F;
            this.netoGravadoTotalDataGridViewTextBoxColumn.HeaderText = "Neto gravado";
            this.netoGravadoTotalDataGridViewTextBoxColumn.Name = "netoGravadoTotalDataGridViewTextBoxColumn";
            this.netoGravadoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.netoGravadoTotalDataGridViewTextBoxColumn.Width = 97;
            // 
            // precioProductoDataGridViewTextBoxColumn
            // 
            this.precioProductoDataGridViewTextBoxColumn.DataPropertyName = "PrecioProducto";
            dataGridViewCellStyle11.Format = "C2";
            dataGridViewCellStyle11.NullValue = null;
            this.precioProductoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.precioProductoDataGridViewTextBoxColumn.FillWeight = 46.60554F;
            this.precioProductoDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioProductoDataGridViewTextBoxColumn.Name = "precioProductoDataGridViewTextBoxColumn";
            this.precioProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioProductoDataGridViewTextBoxColumn.Width = 62;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 38.54317F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 74;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.subTotalDataGridViewTextBoxColumn.FillWeight = 32.3523F;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 75;
            // 
            // lineaDeVentaBindingSource
            // 
            this.lineaDeVentaBindingSource.DataSource = typeof(LaTienda.Dominio.LineaDeVenta);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Quitar seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(404, 434);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(91, 20);
            this.tbTotal.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Total";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(404, 482);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(306, 482);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(21, 482);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // tbNeto
            // 
            this.tbNeto.Enabled = false;
            this.tbNeto.Location = new System.Drawing.Point(259, 434);
            this.tbNeto.Name = "tbNeto";
            this.tbNeto.Size = new System.Drawing.Size(100, 20);
            this.tbNeto.TabIndex = 3;
            // 
            // tbIva
            // 
            this.tbIva.Enabled = false;
            this.tbIva.Location = new System.Drawing.Point(75, 434);
            this.tbIva.Name = "tbIva";
            this.tbIva.Size = new System.Drawing.Size(100, 20);
            this.tbIva.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 437);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Neto gravado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "IVA";
            // 
            // RegistrarVentaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 517);
            this.Controls.Add(this.tbIva);
            this.Controls.Add(this.tbNeto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btAceptar);
            this.Name = "RegistrarVentaVista";
            this.Text = "La tienda - Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineaDeVentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.ComboBox cbTalle;
        private System.Windows.Forms.Button btBuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbRubro;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.NumericUpDown nudCantidadProductos;
        private System.Windows.Forms.Button btAgregarProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGVDetalleVenta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.BindingSource lineaDeVentaBindingSource;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.BindingSource bsMarca;
        private System.Windows.Forms.BindingSource bsRubro;
        private System.Windows.Forms.BindingSource bsStock;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionTalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVATotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoGravadoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbNeto;
        private System.Windows.Forms.TextBox tbIva;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}