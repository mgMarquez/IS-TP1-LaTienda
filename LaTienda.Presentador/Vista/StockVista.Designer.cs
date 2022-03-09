namespace LaTienda.Presentador
{
    partial class StockVista
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
            this.LabelGestionarStock = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.TbStockId = new System.Windows.Forms.TextBox();
            this.BsStock = new System.Windows.Forms.BindingSource(this.components);
            this.CbTalle = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CbColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCantStock = new System.Windows.Forms.TextBox();
            this.CbProducto = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtConfirmar = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsStock)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "StockID:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LabelGestionarStock, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 47);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LabelGestionarStock
            // 
            this.LabelGestionarStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelGestionarStock.AutoSize = true;
            this.LabelGestionarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGestionarStock.Location = new System.Drawing.Point(87, 13);
            this.LabelGestionarStock.Name = "LabelGestionarStock";
            this.LabelGestionarStock.Size = new System.Drawing.Size(136, 20);
            this.LabelGestionarStock.TabIndex = 0;
            this.LabelGestionarStock.Text = "Gestionar stock";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbStockId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CbTalle, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CbColor, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.TbCantStock, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.CbProducto, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(310, 158);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Producto";
            // 
            // TbStockId
            // 
            this.TbStockId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbStockId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsStock, "StockID", true));
            this.TbStockId.Enabled = false;
            this.TbStockId.Location = new System.Drawing.Point(89, 5);
            this.TbStockId.Name = "TbStockId";
            this.TbStockId.Size = new System.Drawing.Size(218, 20);
            this.TbStockId.TabIndex = 0;
            // 
            // BsStock
            // 
            this.BsStock.DataSource = typeof(LaTienda.Dominio.Stock);
            // 
            // CbTalle
            // 
            this.CbTalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTalle.FormattingEnabled = true;
            this.CbTalle.Location = new System.Drawing.Point(89, 67);
            this.CbTalle.Name = "CbTalle";
            this.CbTalle.Size = new System.Drawing.Size(218, 21);
            this.CbTalle.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Talle:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Color";
            // 
            // CbColor
            // 
            this.CbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbColor.FormattingEnabled = true;
            this.CbColor.Location = new System.Drawing.Point(89, 98);
            this.CbColor.Name = "CbColor";
            this.CbColor.Size = new System.Drawing.Size(218, 21);
            this.CbColor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cant. en stock:";
            // 
            // TbCantStock
            // 
            this.TbCantStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbCantStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BsStock, "CantidadEnStock", true));
            this.TbCantStock.Location = new System.Drawing.Point(89, 131);
            this.TbCantStock.Name = "TbCantStock";
            this.TbCantStock.Size = new System.Drawing.Size(218, 20);
            this.TbCantStock.TabIndex = 0;
            // 
            // CbProducto
            // 
            this.CbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProducto.FormattingEnabled = true;
            this.CbProducto.Location = new System.Drawing.Point(89, 36);
            this.CbProducto.Name = "CbProducto";
            this.CbProducto.Size = new System.Drawing.Size(218, 21);
            this.CbProducto.TabIndex = 2;
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(310, 45);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // BtConfirmar
            // 
            this.BtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtConfirmar.Location = new System.Drawing.Point(212, 11);
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
            // StockVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 329);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockVista";
            this.Text = "La tienda - gestionar stock";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsStock)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LabelGestionarStock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbStockId;
        private System.Windows.Forms.TextBox TbCantStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbTalle;
        private System.Windows.Forms.ComboBox CbColor;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtConfirmar;
        private System.Windows.Forms.BindingSource BsStock;
        private System.Windows.Forms.ComboBox CbProducto;
    }
}