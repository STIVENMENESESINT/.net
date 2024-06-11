namespace conexion_db_001
{
    partial class recuperar_frm
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
            this.lbl_correo = new System.Windows.Forms.Label();
            this.btn_nueva_cre = new System.Windows.Forms.Button();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(24, 30);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(60, 18);
            this.lbl_correo.TabIndex = 0;
            this.lbl_correo.Text = "Correo";
            // 
            // btn_nueva_cre
            // 
            this.btn_nueva_cre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nueva_cre.Location = new System.Drawing.Point(27, 136);
            this.btn_nueva_cre.Name = "btn_nueva_cre";
            this.btn_nueva_cre.Size = new System.Drawing.Size(376, 35);
            this.btn_nueva_cre.TabIndex = 1;
            this.btn_nueva_cre.Text = "Nueva Credencial";
            this.btn_nueva_cre.UseVisualStyleBackColor = true;
            this.btn_nueva_cre.Click += new System.EventHandler(this.btn_nueva_cre_Click);
            // 
            // txt_correo
            // 
            this.txt_correo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.Location = new System.Drawing.Point(27, 73);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(376, 26);
            this.txt_correo.TabIndex = 2;
            this.txt_correo.TextChanged += new System.EventHandler(this.txt_correo_TextChanged);
            // 
            // recuperar_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 211);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.btn_nueva_cre);
            this.Controls.Add(this.lbl_correo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "recuperar_frm";
            this.Text = "Nueva Credencial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Button btn_nueva_cre;
        private System.Windows.Forms.TextBox txt_correo;
    }
}