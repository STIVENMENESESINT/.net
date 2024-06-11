namespace conexion_db_001
{
    partial class login_frm
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
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_clave
            // 
            this.txt_clave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clave.Location = new System.Drawing.Point(29, 133);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(237, 26);
            this.txt_clave.TabIndex = 7;
            this.txt_clave.TextChanged += new System.EventHandler(this.txt_clave_TextChanged);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(26, 25);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(70, 18);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            this.lbl_usuario.Click += new System.EventHandler(this.lbl_usuario_Click);
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.Location = new System.Drawing.Point(26, 100);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(53, 18);
            this.lbl_clave.TabIndex = 3;
            this.lbl_clave.Text = "Clave";
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuperar.Location = new System.Drawing.Point(29, 202);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(237, 35);
            this.btn_recuperar.TabIndex = 5;
            this.btn_recuperar.Text = "Nueva Clave";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // txt_usu
            // 
            this.txt_usu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.Location = new System.Drawing.Point(29, 56);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(237, 26);
            this.txt_usu.TabIndex = 8;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 268);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.lbl_clave);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_clave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login_frm";
            this.Text = "CONTROL DE ACCESO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.TextBox txt_usu;
    }
}