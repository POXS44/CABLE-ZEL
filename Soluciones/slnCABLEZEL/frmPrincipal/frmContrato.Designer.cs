
namespace frmPrincipal
{
    partial class frmContrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumcedula = new System.Windows.Forms.TextBox();
            this.txtCantidadequipos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dtpFechacontrato = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbTipocontrato = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNum_contrato = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(531, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Contrato";
            // 
            // txtNumcedula
            // 
            this.txtNumcedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumcedula.Location = new System.Drawing.Point(249, 326);
            this.txtNumcedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumcedula.Name = "txtNumcedula";
            this.txtNumcedula.Size = new System.Drawing.Size(588, 32);
            this.txtNumcedula.TabIndex = 37;
            // 
            // txtCantidadequipos
            // 
            this.txtCantidadequipos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadequipos.Location = new System.Drawing.Point(671, 181);
            this.txtCantidadequipos.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadequipos.Name = "txtCantidadequipos";
            this.txtCantidadequipos.Size = new System.Drawing.Size(41, 32);
            this.txtCantidadequipos.TabIndex = 34;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(249, 101);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(588, 66);
            this.txtDescripcion.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(156, 374);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(31, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Numero de Cedula:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(61, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tipo de Contrato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Barrio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(432, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cantidad de Equipos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(164, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(109, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha del Contrato:";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntidad.Location = new System.Drawing.Point(249, 408);
            this.txtEntidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(386, 32);
            this.txtEntidad.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(147, 417);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "Entidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(262, 485);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(643, 32);
            this.txtNombre.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(140, 485);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 50;
            this.label11.Text = "Nombre:";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1395, 1);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(37, 34);
            this.button6.TabIndex = 53;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dtpFechacontrato
            // 
            this.dtpFechacontrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechacontrato.Location = new System.Drawing.Point(249, 55);
            this.dtpFechacontrato.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechacontrato.Name = "dtpFechacontrato";
            this.dtpFechacontrato.Size = new System.Drawing.Size(588, 32);
            this.dtpFechacontrato.TabIndex = 54;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "CORTADO"});
            this.cmbEstado.Location = new System.Drawing.Point(249, 180);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(167, 31);
            this.cmbEstado.TabIndex = 55;
            this.cmbEstado.Tag = "";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbBarrio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Items.AddRange(new object[] {
            "REPARTO OLIVERO",
            "PEDRO JUAQUIN SECTOR 1",
            "PEDRO JUAQUIN SECTOR 2",
            "PEDRO JUAQUIN SECTOR 3",
            "SOL DE LIBERTAD",
            "ARENERA",
            "LA LUZ",
            "BOMBA",
            "SAN PABLO",
            "CRIKE ARRIBA",
            "MOSQUITOWN",
            "MARCO ANTONIO SOMARRIBA",
            "BARRIO DOLORES",
            "MIMBA"});
            this.cmbBarrio.Location = new System.Drawing.Point(249, 229);
            this.cmbBarrio.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(588, 31);
            this.cmbBarrio.TabIndex = 56;
            // 
            // cmbTipocontrato
            // 
            this.cmbTipocontrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipocontrato.FormattingEnabled = true;
            this.cmbTipocontrato.Items.AddRange(new object[] {
            "DOMICILIAR",
            "INSTITUCIONAL",
            "HOTELES"});
            this.cmbTipocontrato.Location = new System.Drawing.Point(249, 278);
            this.cmbTipocontrato.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipocontrato.Name = "cmbTipocontrato";
            this.cmbTipocontrato.Size = new System.Drawing.Size(588, 31);
            this.cmbTipocontrato.TabIndex = 57;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(249, 370);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(148, 32);
            this.txtUsuario.TabIndex = 58;
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
            this.btnGuardar.Location = new System.Drawing.Point(901, 304);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(195, 49);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(37, 470);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1361, 2);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // dgvContratos
            // 
            this.dgvContratos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvContratos.Location = new System.Drawing.Point(37, 545);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvContratos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContratos.RowTemplate.Height = 24;
            this.dgvContratos.Size = new System.Drawing.Size(1190, 220);
            this.dgvContratos.TabIndex = 63;
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
            this.btnEditar.Location = new System.Drawing.Point(901, 237);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(195, 45);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum_contrato
            // 
            this.txtNum_contrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum_contrato.Location = new System.Drawing.Point(1030, 52);
            this.txtNum_contrato.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum_contrato.Name = "txtNum_contrato";
            this.txtNum_contrato.ReadOnly = true;
            this.txtNum_contrato.Size = new System.Drawing.Size(105, 32);
            this.txtNum_contrato.TabIndex = 65;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(869, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 23);
            this.label12.TabIndex = 66;
            this.label12.Text = "Num/contrato:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ACTIVO",
            "CORTADO"});
            this.comboBox1.Location = new System.Drawing.Point(954, 486);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 31);
            this.comboBox1.TabIndex = 67;
            this.comboBox1.Tag = "";
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1433, 806);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNum_contrato);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvContratos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cmbTipocontrato);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechacontrato);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNumcedula);
            this.Controls.Add(this.txtCantidadequipos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1433, 806);
            this.Name = "frmContrato";
            this.Text = "frmContrato";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumcedula;
        private System.Windows.Forms.TextBox txtCantidadequipos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtpFechacontrato;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbTipocontrato;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNum_contrato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}