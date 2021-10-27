
namespace frmPrincipal
{
    partial class frmFacturas
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
            this.txtNum_contrato = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechafactura = new System.Windows.Forms.DateTimePicker();
            this.txtNum_factura = new System.Windows.Forms.TextBox();
            this.dgbFacturas = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum_contrato
            // 
            this.txtNum_contrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_contrato.Location = new System.Drawing.Point(355, 164);
            this.txtNum_contrato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum_contrato.Name = "txtNum_contrato";
            this.txtNum_contrato.Size = new System.Drawing.Size(332, 32);
            this.txtNum_contrato.TabIndex = 91;
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(355, 349);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 34);
            this.txtMonto.TabIndex = 90;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(347, 401);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(160, 32);
            this.txtUsuario.TabIndex = 89;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(355, 256);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(588, 65);
            this.txtDescripcion.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(166, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 86;
            this.label7.Text = "Monto a pagar : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 23);
            this.label6.TabIndex = 85;
            this.label6.Text = "Numero de contrato :  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 84;
            this.label5.Text = "Descripcion : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Usuario : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 40);
            this.label1.TabIndex = 80;
            this.label1.Text = "Facturar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(975, 117);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 23);
            this.label12.TabIndex = 99;
            this.label12.Text = "Num/Factura:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(131, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(208, 23);
            this.label9.TabIndex = 94;
            this.label9.Text = "Fecha de la factura:";
            // 
            // dtpFechafactura
            // 
            this.dtpFechafactura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechafactura.Location = new System.Drawing.Point(355, 117);
            this.dtpFechafactura.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechafactura.Name = "dtpFechafactura";
            this.dtpFechafactura.Size = new System.Drawing.Size(588, 32);
            this.dtpFechafactura.TabIndex = 97;
            this.dtpFechafactura.ValueChanged += new System.EventHandler(this.dtpFechafactura_ValueChanged);
            // 
            // txtNum_factura
            // 
            this.txtNum_factura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_factura.Location = new System.Drawing.Point(1136, 114);
            this.txtNum_factura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum_factura.Name = "txtNum_factura";
            this.txtNum_factura.Size = new System.Drawing.Size(105, 32);
            this.txtNum_factura.TabIndex = 98;
            // 
            // dgbFacturas
            // 
            this.dgbFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbFacturas.Location = new System.Drawing.Point(125, 535);
            this.dgbFacturas.Name = "dgbFacturas";
            this.dgbFacturas.RowHeadersWidth = 51;
            this.dgbFacturas.RowTemplate.Height = 24;
            this.dgbFacturas.Size = new System.Drawing.Size(1116, 225);
            this.dgbFacturas.TabIndex = 101;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::frmPrincipal.Properties.Resources.clientes2;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(979, 437);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(253, 49);
            this.btnEditar.TabIndex = 103;
            this.btnEditar.Text = "Editar Factura";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Image = global::frmPrincipal.Properties.Resources.clientes2;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(748, 437);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(195, 49);
            this.btnFacturar.TabIndex = 102;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 82;
            this.label3.Text = "Estado  : ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Pagado ",
            "Retrasado"});
            this.cmbEstado.Location = new System.Drawing.Point(355, 217);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(183, 31);
            this.cmbEstado.TabIndex = 100;
            this.cmbEstado.Tag = "";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 837);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dgbFacturas);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNum_factura);
            this.Controls.Add(this.dtpFechafactura);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNum_contrato);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNum_contrato;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechafactura;
        private System.Windows.Forms.TextBox txtNum_factura;
        private System.Windows.Forms.DataGridView dgbFacturas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}