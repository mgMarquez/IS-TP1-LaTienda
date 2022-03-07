namespace LaTienda.Presentador
{
    partial class ClienteVista
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TbNroDocumento = new System.Windows.Forms.TextBox();
            this.BsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbRazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbCondicionTributaria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbDomicilio = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxCliente.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(122, 7);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(65, 20);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelCliente, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtConfirmar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtSalir, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 248);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 45);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtConfirmar.Location = new System.Drawing.Point(222, 11);
            this.BtConfirmar.Name = "BtConfirmar";
            this.BtConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BtConfirmar.TabIndex = 3;
            this.BtConfirmar.Text = "Confirmar";
            this.BtConfirmar.UseVisualStyleBackColor = true;
            this.BtConfirmar.Click += new System.EventHandler(this.BtConfirmar_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtSalir.Location = new System.Drawing.Point(12, 11);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 23);
            this.BtSalir.TabIndex = 0;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCliente.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxCliente.Location = new System.Drawing.Point(12, 52);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(310, 190);
            this.groupBoxCliente.TabIndex = 6;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.TbNroDocumento, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbRazonSocial, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CbTipoDocumento, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbCondicionTributaria, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbDomicilio, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(304, 171);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // TbNroDocumento
            // 
            this.TbNroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbNroDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsCliente, "NroDocumento", true));
            this.TbNroDocumento.Location = new System.Drawing.Point(109, 7);
            this.TbNroDocumento.Name = "TbNroDocumento";
            this.TbNroDocumento.Size = new System.Drawing.Size(192, 20);
            this.TbNroDocumento.TabIndex = 0;
            // 
            // BsCliente
            // 
            this.BsCliente.DataSource = typeof(LaTienda.Dominio.Cliente);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro documento";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razon social";
            // 
            // TbRazonSocial
            // 
            this.TbRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbRazonSocial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsCliente, "RazonSocial", true));
            this.TbRazonSocial.Location = new System.Drawing.Point(109, 41);
            this.TbRazonSocial.Name = "TbRazonSocial";
            this.TbRazonSocial.Size = new System.Drawing.Size(192, 20);
            this.TbRazonSocial.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de documento";
            // 
            // CbTipoDocumento
            // 
            this.CbTipoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbTipoDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsCliente, "TipoDocumento", true));
            this.CbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoDocumento.FormattingEnabled = true;
            this.CbTipoDocumento.Location = new System.Drawing.Point(109, 143);
            this.CbTipoDocumento.Name = "CbTipoDocumento";
            this.CbTipoDocumento.Size = new System.Drawing.Size(192, 21);
            this.CbTipoDocumento.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Condición tributaria";
            // 
            // CbCondicionTributaria
            // 
            this.CbCondicionTributaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbCondicionTributaria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsCliente, "CondicionTributaria", true));
            this.CbCondicionTributaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCondicionTributaria.FormattingEnabled = true;
            this.CbCondicionTributaria.Location = new System.Drawing.Point(109, 108);
            this.CbCondicionTributaria.Name = "CbCondicionTributaria";
            this.CbCondicionTributaria.Size = new System.Drawing.Size(192, 21);
            this.CbCondicionTributaria.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Domicilio";
            // 
            // TbDomicilio
            // 
            this.TbDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsCliente, "Domicilio", true));
            this.TbDomicilio.Location = new System.Drawing.Point(109, 75);
            this.TbDomicilio.Name = "TbDomicilio";
            this.TbDomicilio.Size = new System.Drawing.Size(192, 20);
            this.TbDomicilio.TabIndex = 0;
            // 
            // ClienteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 305);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ClienteVista";
            this.Text = "La tienda - Gestionar cliente";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBoxCliente.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TbNroDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbRazonSocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbDomicilio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbCondicionTributaria;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.BindingSource BsCliente;
    }
}