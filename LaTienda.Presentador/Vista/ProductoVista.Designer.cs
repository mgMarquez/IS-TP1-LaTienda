namespace LaTienda.Presentador
{
    partial class ProductoVista
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelGestionarProducto = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.TbCodigo = new System.Windows.Forms.TextBox();
            this.BsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.TbDescripcion = new System.Windows.Forms.TextBox();
            this.TbPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbCosto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbPorcentajeGanancias = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbPorcentajeIva = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbMarca = new System.Windows.Forms.ComboBox();
            this.TbIva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbRubro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbNetoGravado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsProducto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelGestionarProducto, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 47);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LabelGestionarProducto
            // 
            this.LabelGestionarProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelGestionarProducto.AutoSize = true;
            this.LabelGestionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGestionarProducto.Location = new System.Drawing.Point(124, 13);
            this.LabelGestionarProducto.Name = "LabelGestionarProducto";
            this.LabelGestionarProducto.Size = new System.Drawing.Size(164, 20);
            this.LabelGestionarProducto.TabIndex = 0;
            this.LabelGestionarProducto.Text = "Gestionar producto";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbCodigo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbDescripcion, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbPrecioVenta, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TbCosto, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbPorcentajeGanancias, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TbPorcentajeIva, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbMarca, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbIva, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.CbRubro, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.TbNetoGravado, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 199);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripción:";
            // 
            // TbCodigo
            // 
            this.TbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "Codigo", true));
            this.TbCodigo.Location = new System.Drawing.Point(89, 6);
            this.TbCodigo.Name = "TbCodigo";
            this.TbCodigo.Size = new System.Drawing.Size(103, 20);
            this.TbCodigo.TabIndex = 0;
            // 
            // BsProducto
            // 
            this.BsProducto.DataSource = typeof(LaTienda.Dominio.Producto);
            // 
            // TbDescripcion
            // 
            this.TbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.TbDescripcion, 3);
            this.TbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "Descripcion", true));
            this.TbDescripcion.Location = new System.Drawing.Point(89, 39);
            this.TbDescripcion.Name = "TbDescripcion";
            this.TbDescripcion.Size = new System.Drawing.Size(297, 20);
            this.TbDescripcion.TabIndex = 0;
            // 
            // TbPrecioVenta
            // 
            this.TbPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPrecioVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "PrecioDeVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TbPrecioVenta.Enabled = false;
            this.TbPrecioVenta.Location = new System.Drawing.Point(283, 172);
            this.TbPrecioVenta.Name = "TbPrecioVenta";
            this.TbPrecioVenta.Size = new System.Drawing.Size(103, 20);
            this.TbPrecioVenta.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Costo:";
            // 
            // TbCosto
            // 
            this.TbCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbCosto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "Costo", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TbCosto.Location = new System.Drawing.Point(283, 6);
            this.TbCosto.Name = "TbCosto";
            this.TbCosto.Size = new System.Drawing.Size(103, 20);
            this.TbCosto.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Porcentaje de ganancias:";
            // 
            // TbPorcentajeGanancias
            // 
            this.TbPorcentajeGanancias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPorcentajeGanancias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "MargenDeGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p"));
            this.TbPorcentajeGanancias.Location = new System.Drawing.Point(89, 72);
            this.TbPorcentajeGanancias.Name = "TbPorcentajeGanancias";
            this.TbPorcentajeGanancias.Size = new System.Drawing.Size(103, 20);
            this.TbPorcentajeGanancias.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Porcentaje de IVA:";
            // 
            // TbPorcentajeIva
            // 
            this.TbPorcentajeIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPorcentajeIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "PorcentajeDeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "p"));
            this.TbPorcentajeIva.Location = new System.Drawing.Point(283, 72);
            this.TbPorcentajeIva.Name = "TbPorcentajeIva";
            this.TbPorcentajeIva.Size = new System.Drawing.Size(103, 20);
            this.TbPorcentajeIva.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Marca:";
            // 
            // CbMarca
            // 
            this.CbMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMarca.FormattingEnabled = true;
            this.CbMarca.Location = new System.Drawing.Point(89, 105);
            this.CbMarca.Name = "CbMarca";
            this.CbMarca.Size = new System.Drawing.Size(103, 21);
            this.CbMarca.TabIndex = 2;
            // 
            // TbIva
            // 
            this.TbIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "IVA", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TbIva.Enabled = false;
            this.TbIva.Location = new System.Drawing.Point(283, 138);
            this.TbIva.Name = "TbIva";
            this.TbIva.Size = new System.Drawing.Size(103, 20);
            this.TbIva.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "IVA:";
            // 
            // CbRubro
            // 
            this.CbRubro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRubro.FormattingEnabled = true;
            this.CbRubro.Location = new System.Drawing.Point(283, 105);
            this.CbRubro.Name = "CbRubro";
            this.CbRubro.Size = new System.Drawing.Size(103, 21);
            this.CbRubro.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Rubro:";
            // 
            // TbNetoGravado
            // 
            this.TbNetoGravado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbNetoGravado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsProducto, "NetoGravado", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TbNetoGravado.Enabled = false;
            this.TbNetoGravado.Location = new System.Drawing.Point(89, 138);
            this.TbNetoGravado.Name = "TbNetoGravado";
            this.TbNetoGravado.Size = new System.Drawing.Size(103, 20);
            this.TbNetoGravado.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neto gravado:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(192, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Precio de venta:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtConfirmar, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtSalir, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 272);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(413, 45);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtConfirmar.Location = new System.Drawing.Point(315, 11);
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
            this.BtSalir.Location = new System.Drawing.Point(22, 11);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 23);
            this.BtSalir.TabIndex = 0;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // ProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 329);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProductoVista";
            this.Text = "La tienda - gestionar producto";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsProducto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelGestionarProducto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbCodigo;
        private System.Windows.Forms.TextBox TbDescripcion;
        private System.Windows.Forms.TextBox TbCosto;
        private System.Windows.Forms.TextBox TbPorcentajeGanancias;
        private System.Windows.Forms.TextBox TbPorcentajeIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbNetoGravado;
        private System.Windows.Forms.TextBox TbIva;
        private System.Windows.Forms.TextBox TbPrecioVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbMarca;
        private System.Windows.Forms.ComboBox CbRubro;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.BindingSource BsProducto;
    }
}