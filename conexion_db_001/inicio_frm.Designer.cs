namespace conexion_db_001
{
    partial class inicio_frm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.salieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(446, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regionalToolStripMenuItem,
            this.centrosToolStripMenuItem,
            this.areasToolStripMenuItem});
            this.ingresosToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.ingresosToolStripMenuItem.Text = "Archivo";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // salieToolStripMenuItem
            // 
            this.salieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.salieToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salieToolStripMenuItem.Name = "salieToolStripMenuItem";
            this.salieToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.salieToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::conexion_db_001.Properties.Resources.apagar1;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // regionalToolStripMenuItem
            // 
            this.regionalToolStripMenuItem.Image = global::conexion_db_001.Properties.Resources.check;
            this.regionalToolStripMenuItem.Name = "regionalToolStripMenuItem";
            this.regionalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.regionalToolStripMenuItem.Text = "Rol";
            // 
            // centrosToolStripMenuItem
            // 
            this.centrosToolStripMenuItem.Image = global::conexion_db_001.Properties.Resources.usuario;
            this.centrosToolStripMenuItem.Name = "centrosToolStripMenuItem";
            this.centrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centrosToolStripMenuItem.Text = "Usuario";
            // 
            // areasToolStripMenuItem
            // 
            this.areasToolStripMenuItem.Image = global::conexion_db_001.Properties.Resources.apagar;
            this.areasToolStripMenuItem.Name = "areasToolStripMenuItem";
            this.areasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areasToolStripMenuItem.Text = "Salir";
            // 
            // inicio_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 258);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "inicio_frm";
            this.Text = "SERVICIO NACIONAL DE APRENDIZAJE SENA - FORMULARIO DE INICIO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}