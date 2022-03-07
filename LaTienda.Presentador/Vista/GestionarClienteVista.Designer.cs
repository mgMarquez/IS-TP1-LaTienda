namespace LaTienda.Presentador
{
    partial class GestionarClienteVista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarClienteVista));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCliente = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCrear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.TbBuscar = new System.Windows.Forms.TextBox();
            this.DgvCliente = new System.Windows.Forms.DataGridView();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionTributariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCliente)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.DgvCliente);
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
            this.toolStripButtonModificar.Click += new System.EventHandler(this.toolStripButtonModificar_Click);
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
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.toolStripButtonEliminar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(146, 32);
            this.toolStripLabel1.Text = "Gestionar clientes";
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
            // DgvCliente
            // 
            this.DgvCliente.AutoGenerateColumns = false;
            this.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.razonSocialDataGridViewTextBoxColumn,
            this.domicilioDataGridViewTextBoxColumn,
            this.condicionTributariaDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvCliente, 2);
            this.DgvCliente.DataSource = this.BsCliente;
            this.DgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCliente.GridColor = System.Drawing.Color.LightSteelBlue;
            this.DgvCliente.Location = new System.Drawing.Point(3, 63);
            this.DgvCliente.MultiSelect = false;
            this.DgvCliente.Name = "DgvCliente";
            this.DgvCliente.ReadOnly = true;
            this.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCliente.Size = new System.Drawing.Size(615, 308);
            this.DgvCliente.TabIndex = 3;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "NroDocumento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocumentoDataGridViewTextBoxColumn.Width = 104;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDocumentoDataGridViewTextBoxColumn.Width = 108;
            // 
            // razonSocialDataGridViewTextBoxColumn
            // 
            this.razonSocialDataGridViewTextBoxColumn.DataPropertyName = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.HeaderText = "RazonSocial";
            this.razonSocialDataGridViewTextBoxColumn.Name = "razonSocialDataGridViewTextBoxColumn";
            this.razonSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razonSocialDataGridViewTextBoxColumn.Width = 92;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            this.domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            this.domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            this.domicilioDataGridViewTextBoxColumn.Width = 74;
            // 
            // condicionTributariaDataGridViewTextBoxColumn
            // 
            this.condicionTributariaDataGridViewTextBoxColumn.DataPropertyName = "CondicionTributaria";
            this.condicionTributariaDataGridViewTextBoxColumn.HeaderText = "CondicionTributaria";
            this.condicionTributariaDataGridViewTextBoxColumn.Name = "condicionTributariaDataGridViewTextBoxColumn";
            this.condicionTributariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.condicionTributariaDataGridViewTextBoxColumn.Width = 123;
            // 
            // BsCliente
            // 
            this.BsCliente.DataSource = typeof(LaTienda.Dominio.Cliente);
            // 
            // GestionarClienteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GestionarClienteVista";
            this.Text = "Gestionar clientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripCliente.ResumeLayout(false);
            this.toolStripCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsCliente)).EndInit();
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
        private System.Windows.Forms.DataGridView DgvCliente;
        private System.Windows.Forms.BindingSource BsCliente;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionTributariaDataGridViewTextBoxColumn;
    }
}