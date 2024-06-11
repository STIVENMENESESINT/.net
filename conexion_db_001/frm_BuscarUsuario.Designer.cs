namespace conexion_db_001
{
    partial class frm_BuscarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_opciones_formulario = new System.Windows.Forms.GroupBox();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_departamentos = new System.Windows.Forms.ComboBox();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_opciones_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato a buscar:";
            // 
            // groupBox_opciones_formulario
            // 
            this.groupBox_opciones_formulario.Controls.Add(this.listView1);
            this.groupBox_opciones_formulario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_opciones_formulario.Location = new System.Drawing.Point(25, 143);
            this.groupBox_opciones_formulario.Name = "groupBox_opciones_formulario";
            this.groupBox_opciones_formulario.Size = new System.Drawing.Size(620, 282);
            this.groupBox_opciones_formulario.TabIndex = 4;
            this.groupBox_opciones_formulario.TabStop = false;
            this.groupBox_opciones_formulario.Text = "Resultados:";
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recuperar.Location = new System.Drawing.Point(453, 35);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(173, 35);
            this.btn_recuperar.TabIndex = 6;
            this.btn_recuperar.Text = "Buscar Usuario";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(243, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Nuevo Usuario";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox_departamentos
            // 
            this.comboBox_departamentos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_departamentos.FormattingEnabled = true;
            this.comboBox_departamentos.Items.AddRange(new object[] {
            "Masculino"});
            this.comboBox_departamentos.Location = new System.Drawing.Point(41, 93);
            this.comboBox_departamentos.Name = "comboBox_departamentos";
            this.comboBox_departamentos.Size = new System.Drawing.Size(173, 26);
            this.comboBox_departamentos.TabIndex = 31;
            this.comboBox_departamentos.Text = "Identificación";
            // 
            // txt_usu
            // 
            this.txt_usu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usu.Location = new System.Drawing.Point(243, 93);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(173, 26);
            this.txt_usu.TabIndex = 32;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 37);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 227);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(453, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 33;
            // 
            // frm_BuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 498);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.txt_usu);
            this.Controls.Add(this.comboBox_departamentos);
            this.Controls.Add(this.groupBox_opciones_formulario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_BuscarUsuario";
            this.Text = "Busqueda de Usuario";
            this.groupBox_opciones_formulario.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_opciones_formulario;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_departamentos;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}