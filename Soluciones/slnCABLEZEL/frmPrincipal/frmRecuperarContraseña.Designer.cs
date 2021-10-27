
namespace frmPrincipal
{
    partial class frmRecuperarContraseña
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
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRequest.Location = new System.Drawing.Point(125, 56);
            this.txtUserRequest.Multiline = true;
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.Size = new System.Drawing.Size(265, 27);
            this.txtUserRequest.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su Usuario O Contraseña CHATEL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(22, 153);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(83, 18);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado:";
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 356);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserRequest);
            this.Name = "frmRecuperarContraseña";
            this.Text = "frmRecuperarContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
    }
}