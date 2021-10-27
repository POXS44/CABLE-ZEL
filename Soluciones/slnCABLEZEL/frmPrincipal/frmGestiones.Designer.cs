
namespace frmPrincipal
{
    partial class frmGestiones
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
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtTipo_contrato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgTipo = new System.Windows.Forms.DataGridView();
            this.dgbBarrio = new System.Windows.Forms.DataGridView();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtCod_barrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGuardarb = new System.Windows.Forms.Button();
            this.btnEditarb = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(246, 199);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(129, 32);
            this.txtCosto.TabIndex = 79;
            // 
            // txtTipo_contrato
            // 
            this.txtTipo_contrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo_contrato.Location = new System.Drawing.Point(246, 147);
            this.txtTipo_contrato.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo_contrato.Name = "txtTipo_contrato";
            this.txtTipo_contrato.Size = new System.Drawing.Size(267, 32);
            this.txtTipo_contrato.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 77;
            this.label3.Text = "Costo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Tipo de contrato:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 40);
            this.label1.TabIndex = 80;
            this.label1.Text = "Gestiones";
            // 
            // dtgTipo
            // 
            this.dtgTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipo.Location = new System.Drawing.Point(80, 241);
            this.dtgTipo.Name = "dtgTipo";
            this.dtgTipo.RowHeadersWidth = 51;
            this.dtgTipo.RowTemplate.Height = 24;
            this.dtgTipo.Size = new System.Drawing.Size(479, 433);
            this.dtgTipo.TabIndex = 81;
            // 
            // dgbBarrio
            // 
            this.dgbBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbBarrio.Location = new System.Drawing.Point(697, 241);
            this.dgbBarrio.Name = "dgbBarrio";
            this.dgbBarrio.RowHeadersWidth = 51;
            this.dgbBarrio.RowTemplate.Height = 24;
            this.dgbBarrio.Size = new System.Drawing.Size(389, 433);
            this.dgbBarrio.TabIndex = 82;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarrio.Location = new System.Drawing.Point(847, 167);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarrio.Multiline = true;
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(393, 58);
            this.txtBarrio.TabIndex = 86;
            // 
            // txtCod_barrio
            // 
            this.txtCod_barrio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_barrio.Location = new System.Drawing.Point(847, 121);
            this.txtCod_barrio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCod_barrio.Name = "txtCod_barrio";
            this.txtCod_barrio.ReadOnly = true;
            this.txtCod_barrio.Size = new System.Drawing.Size(60, 32);
            this.txtCod_barrio.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 23);
            this.label4.TabIndex = 84;
            this.label4.Text = "Barrio :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 83;
            this.label5.Text = "Codigo de barrio :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(627, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 692);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 88;
            this.label6.Text = "Tipos de contratos ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(838, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 89;
            this.label7.Text = "Barrios";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::frmPrincipal.Properties.Resources.clientes2;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(107, 697);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(209, 70);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(339, 697);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(220, 70);
            this.btnEditar.TabIndex = 91;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(246, 98);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(55, 32);
            this.txtId.TabIndex = 92;
            // 
            // btnGuardarb
            // 
            this.btnGuardarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardarb.FlatAppearance.BorderSize = 0;
            this.btnGuardarb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnGuardarb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarb.ForeColor = System.Drawing.Color.White;
            this.btnGuardarb.Image = global::frmPrincipal.Properties.Resources.clientes2;
            this.btnGuardarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarb.Location = new System.Drawing.Point(697, 697);
            this.btnGuardarb.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarb.Name = "btnGuardarb";
            this.btnGuardarb.Size = new System.Drawing.Size(209, 70);
            this.btnGuardarb.TabIndex = 93;
            this.btnGuardarb.Text = "Guardar";
            this.btnGuardarb.UseVisualStyleBackColor = false;
            this.btnGuardarb.Click += new System.EventHandler(this.btnGuardarb_Click);
            // 
            // btnEditarb
            // 
            this.btnEditarb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditarb.FlatAppearance.BorderSize = 0;
            this.btnEditarb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEditarb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarb.ForeColor = System.Drawing.Color.White;
            this.btnEditarb.Image = global::frmPrincipal.Properties.Resources.clientes2;
            this.btnEditarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarb.Location = new System.Drawing.Point(936, 697);
            this.btnEditarb.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarb.Name = "btnEditarb";
            this.btnEditarb.Size = new System.Drawing.Size(220, 70);
            this.btnEditarb.TabIndex = 94;
            this.btnEditarb.Text = "Editar";
            this.btnEditarb.UseVisualStyleBackColor = false;
            this.btnEditarb.Click += new System.EventHandler(this.btnEditarb_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(115, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 95;
            this.label8.Text = "Id contrato:";
            // 
            // frmGestiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 967);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditarb);
            this.Controls.Add(this.btnGuardarb);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.txtCod_barrio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgbBarrio);
            this.Controls.Add(this.dtgTipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtTipo_contrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestiones";
            this.Text = "TipoContrato";
            this.Load += new System.EventHandler(this.frmGestiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgbBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtTipo_contrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgTipo;
        private System.Windows.Forms.DataGridView dgbBarrio;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtCod_barrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGuardarb;
        private System.Windows.Forms.Button btnEditarb;
        private System.Windows.Forms.Label label8;
    }
}