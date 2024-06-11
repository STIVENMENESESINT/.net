namespace conexion_db_001
{
    partial class frm_usu
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
            this.lbl_titulo_formulario = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox_genero = new System.Windows.Forms.ComboBox();
            this.groupBox_opciones_formulario = new System.Windows.Forms.GroupBox();
            this.lbl_cancelar = new System.Windows.Forms.Label();
            this.lbl_buscar = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_guardar = new System.Windows.Forms.Label();
            this.lbl_borrar = new System.Windows.Forms.Label();
            this.lbl_actualizar = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox_datos_ingreso = new System.Windows.Forms.GroupBox();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.lbl_clave = new System.Windows.Forms.Label();
            this.txt_usu = new System.Windows.Forms.TextBox();
            this.lbl_usu = new System.Windows.Forms.Label();
            this.comboBox_rol = new System.Windows.Forms.ComboBox();
            this.lbl_rol = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.comboBox_municipio = new System.Windows.Forms.ComboBox();
            this.lbl_municipio = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.comboBox_departamentos = new System.Windows.Forms.ComboBox();
            this.lbl_departamentos = new System.Windows.Forms.Label();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.lbl_genero = new System.Windows.Forms.Label();
            this.txt_num_documento = new System.Windows.Forms.TextBox();
            this.lbl_num_documento = new System.Windows.Forms.Label();
            this.txt_tipo_documento = new System.Windows.Forms.TextBox();
            this.lbl_tipo_documento = new System.Windows.Forms.Label();
            this.txt_fecha_registro = new System.Windows.Forms.TextBox();
            this.lbl_fecha_registro = new System.Windows.Forms.Label();
            this.groupBox_img_usu = new System.Windows.Forms.GroupBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.pictureBox_usu = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_inactivo = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox_activo = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lbl_info = new System.Windows.Forms.Label();
            this.groupBox_opciones_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox_datos_ingreso.SuspendLayout();
            this.groupBox_img_usu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_usu)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo_formulario
            // 
            this.lbl_titulo_formulario.AutoSize = true;
            this.lbl_titulo_formulario.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_formulario.Location = new System.Drawing.Point(21, 19);
            this.lbl_titulo_formulario.Name = "lbl_titulo_formulario";
            this.lbl_titulo_formulario.Size = new System.Drawing.Size(419, 25);
            this.lbl_titulo_formulario.TabIndex = 0;
            this.lbl_titulo_formulario.Text = "FORMULARIO INGRESO USUARIOS";
            this.lbl_titulo_formulario.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_genero
            // 
            this.comboBox_genero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_genero.FormattingEnabled = true;
            this.comboBox_genero.Items.AddRange(new object[] {
            "Masculino"});
            this.comboBox_genero.Location = new System.Drawing.Point(471, 67);
            this.comboBox_genero.Name = "comboBox_genero";
            this.comboBox_genero.Size = new System.Drawing.Size(131, 26);
            this.comboBox_genero.TabIndex = 1;
            this.comboBox_genero.Text = "Masculino";
            this.comboBox_genero.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox_opciones_formulario
            // 
            this.groupBox_opciones_formulario.Controls.Add(this.lbl_cancelar);
            this.groupBox_opciones_formulario.Controls.Add(this.lbl_buscar);
            this.groupBox_opciones_formulario.Controls.Add(this.pictureBox4);
            this.groupBox_opciones_formulario.Controls.Add(this.pictureBox2);
            this.groupBox_opciones_formulario.Controls.Add(this.lbl_guardar);
            this.groupBox_opciones_formulario.Controls.Add(this.lbl_borrar);
            this.groupBox_opciones_formulario.Controls.Add(this.lbl_actualizar);
            this.groupBox_opciones_formulario.Controls.Add(this.pictureBox6);
            this.groupBox_opciones_formulario.Controls.Add(this.pictureBox5);
            this.groupBox_opciones_formulario.Controls.Add(this.pictureBox3);
            this.groupBox_opciones_formulario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_opciones_formulario.Location = new System.Drawing.Point(26, 62);
            this.groupBox_opciones_formulario.Name = "groupBox_opciones_formulario";
            this.groupBox_opciones_formulario.Size = new System.Drawing.Size(620, 149);
            this.groupBox_opciones_formulario.TabIndex = 2;
            this.groupBox_opciones_formulario.TabStop = false;
            this.groupBox_opciones_formulario.Text = "Opciones de Formulario";
            this.groupBox_opciones_formulario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_cancelar
            // 
            this.lbl_cancelar.AutoSize = true;
            this.lbl_cancelar.Location = new System.Drawing.Point(357, 112);
            this.lbl_cancelar.Name = "lbl_cancelar";
            this.lbl_cancelar.Size = new System.Drawing.Size(78, 18);
            this.lbl_cancelar.TabIndex = 18;
            this.lbl_cancelar.Text = "Cancelar";
            this.lbl_cancelar.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_buscar
            // 
            this.lbl_buscar.AutoSize = true;
            this.lbl_buscar.Location = new System.Drawing.Point(457, 112);
            this.lbl_buscar.Name = "lbl_buscar";
            this.lbl_buscar.Size = new System.Drawing.Size(63, 18);
            this.lbl_buscar.TabIndex = 19;
            this.lbl_buscar.Text = "Buscar";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::conexion_db_001.Properties.Resources.delete;
            this.pictureBox4.Location = new System.Drawing.Point(274, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(71, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::conexion_db_001.Properties.Resources.save;
            this.pictureBox2.Location = new System.Drawing.Point(69, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_guardar
            // 
            this.lbl_guardar.AutoSize = true;
            this.lbl_guardar.Location = new System.Drawing.Point(81, 112);
            this.lbl_guardar.Name = "lbl_guardar";
            this.lbl_guardar.Size = new System.Drawing.Size(74, 18);
            this.lbl_guardar.TabIndex = 16;
            this.lbl_guardar.Text = "Guardar";
            // 
            // lbl_borrar
            // 
            this.lbl_borrar.AutoSize = true;
            this.lbl_borrar.Location = new System.Drawing.Point(285, 112);
            this.lbl_borrar.Name = "lbl_borrar";
            this.lbl_borrar.Size = new System.Drawing.Size(60, 18);
            this.lbl_borrar.TabIndex = 15;
            this.lbl_borrar.Text = "Borrar";
            // 
            // lbl_actualizar
            // 
            this.lbl_actualizar.AutoSize = true;
            this.lbl_actualizar.Location = new System.Drawing.Point(167, 112);
            this.lbl_actualizar.Name = "lbl_actualizar";
            this.lbl_actualizar.Size = new System.Drawing.Size(89, 18);
            this.lbl_actualizar.TabIndex = 14;
            this.lbl_actualizar.Text = "Actualizar";
            this.lbl_actualizar.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::conexion_db_001.Properties.Resources.Basic_Ui__151_;
            this.pictureBox6.Location = new System.Drawing.Point(449, 43);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 57);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::conexion_db_001.Properties.Resources.bloqueo;
            this.pictureBox5.Location = new System.Drawing.Point(360, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(71, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::conexion_db_001.Properties.Resources.update;
            this.pictureBox3.Location = new System.Drawing.Point(170, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox_datos_ingreso
            // 
            this.groupBox_datos_ingreso.Controls.Add(this.txt_clave);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_clave);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_usu);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_usu);
            this.groupBox_datos_ingreso.Controls.Add(this.comboBox_rol);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_rol);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_correo);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_correo);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_telefono);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_tel);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_dir);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_direccion);
            this.groupBox_datos_ingreso.Controls.Add(this.comboBox_municipio);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_municipio);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_apellidos);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_nombres);
            this.groupBox_datos_ingreso.Controls.Add(this.comboBox_departamentos);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_departamentos);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_apellidos);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_nombres);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_genero);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_num_documento);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_num_documento);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_tipo_documento);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_tipo_documento);
            this.groupBox_datos_ingreso.Controls.Add(this.txt_fecha_registro);
            this.groupBox_datos_ingreso.Controls.Add(this.lbl_fecha_registro);
            this.groupBox_datos_ingreso.Controls.Add(this.comboBox_genero);
            this.groupBox_datos_ingreso.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_datos_ingreso.Location = new System.Drawing.Point(26, 238);
            this.groupBox_datos_ingreso.Name = "groupBox_datos_ingreso";
            this.groupBox_datos_ingreso.Size = new System.Drawing.Size(620, 452);
            this.groupBox_datos_ingreso.TabIndex = 3;
            this.groupBox_datos_ingreso.TabStop = false;
            this.groupBox_datos_ingreso.Text = "Datos de Ingreso";
            this.groupBox_datos_ingreso.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(227, 392);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(185, 26);
            this.txt_clave.TabIndex = 46;
            // 
            // lbl_clave
            // 
            this.lbl_clave.AutoSize = true;
            this.lbl_clave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clave.Location = new System.Drawing.Point(224, 356);
            this.lbl_clave.Name = "lbl_clave";
            this.lbl_clave.Size = new System.Drawing.Size(49, 18);
            this.lbl_clave.TabIndex = 45;
            this.lbl_clave.Text = "Clave";
            // 
            // txt_usu
            // 
            this.txt_usu.Location = new System.Drawing.Point(18, 392);
            this.txt_usu.Name = "txt_usu";
            this.txt_usu.Size = new System.Drawing.Size(185, 26);
            this.txt_usu.TabIndex = 44;
            // 
            // lbl_usu
            // 
            this.lbl_usu.AutoSize = true;
            this.lbl_usu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usu.Location = new System.Drawing.Point(15, 355);
            this.lbl_usu.Name = "lbl_usu";
            this.lbl_usu.Size = new System.Drawing.Size(64, 18);
            this.lbl_usu.TabIndex = 43;
            this.lbl_usu.Text = "Usuario";
            // 
            // comboBox_rol
            // 
            this.comboBox_rol.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rol.FormattingEnabled = true;
            this.comboBox_rol.Items.AddRange(new object[] {
            "Masculino"});
            this.comboBox_rol.Location = new System.Drawing.Point(429, 305);
            this.comboBox_rol.Name = "comboBox_rol";
            this.comboBox_rol.Size = new System.Drawing.Size(173, 26);
            this.comboBox_rol.TabIndex = 42;
            this.comboBox_rol.Text = "Mesero";
            // 
            // lbl_rol
            // 
            this.lbl_rol.AutoSize = true;
            this.lbl_rol.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rol.Location = new System.Drawing.Point(426, 273);
            this.lbl_rol.Name = "lbl_rol";
            this.lbl_rol.Size = new System.Drawing.Size(31, 18);
            this.lbl_rol.TabIndex = 41;
            this.lbl_rol.Text = "Rol";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(224, 305);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(185, 26);
            this.txt_correo.TabIndex = 40;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_correo.Location = new System.Drawing.Point(224, 273);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(60, 18);
            this.lbl_correo.TabIndex = 39;
            this.lbl_correo.Text = "Correo";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(15, 273);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(70, 18);
            this.lbl_telefono.TabIndex = 38;
            this.lbl_telefono.Text = "Teléfono";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(17, 305);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(185, 26);
            this.txt_tel.TabIndex = 37;
            // 
            // txt_dir
            // 
            this.txt_dir.Location = new System.Drawing.Point(224, 226);
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(378, 26);
            this.txt_dir.TabIndex = 36;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(221, 193);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(75, 18);
            this.lbl_direccion.TabIndex = 35;
            this.lbl_direccion.Text = "Dirección";
            // 
            // comboBox_municipio
            // 
            this.comboBox_municipio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_municipio.FormattingEnabled = true;
            this.comboBox_municipio.Items.AddRange(new object[] {
            "Masculino"});
            this.comboBox_municipio.Location = new System.Drawing.Point(17, 226);
            this.comboBox_municipio.Name = "comboBox_municipio";
            this.comboBox_municipio.Size = new System.Drawing.Size(173, 26);
            this.comboBox_municipio.TabIndex = 34;
            this.comboBox_municipio.Text = "Restrepo";
            // 
            // lbl_municipio
            // 
            this.lbl_municipio.AutoSize = true;
            this.lbl_municipio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_municipio.Location = new System.Drawing.Point(15, 190);
            this.lbl_municipio.Name = "lbl_municipio";
            this.lbl_municipio.Size = new System.Drawing.Size(75, 18);
            this.lbl_municipio.TabIndex = 33;
            this.lbl_municipio.Text = "Municipio";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(224, 140);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(185, 26);
            this.txt_apellidos.TabIndex = 32;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(17, 140);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(185, 26);
            this.txt_nombres.TabIndex = 31;
            // 
            // comboBox_departamentos
            // 
            this.comboBox_departamentos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_departamentos.FormattingEnabled = true;
            this.comboBox_departamentos.Items.AddRange(new object[] {
            "Masculino"});
            this.comboBox_departamentos.Location = new System.Drawing.Point(429, 140);
            this.comboBox_departamentos.Name = "comboBox_departamentos";
            this.comboBox_departamentos.Size = new System.Drawing.Size(173, 26);
            this.comboBox_departamentos.TabIndex = 30;
            this.comboBox_departamentos.Text = "Valle del Cauca";
            // 
            // lbl_departamentos
            // 
            this.lbl_departamentos.AutoSize = true;
            this.lbl_departamentos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_departamentos.Location = new System.Drawing.Point(426, 110);
            this.lbl_departamentos.Name = "lbl_departamentos";
            this.lbl_departamentos.Size = new System.Drawing.Size(124, 18);
            this.lbl_departamentos.TabIndex = 29;
            this.lbl_departamentos.Text = "Departamentos";
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(221, 110);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(72, 18);
            this.lbl_apellidos.TabIndex = 28;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombres.Location = new System.Drawing.Point(14, 110);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(76, 18);
            this.lbl_nombres.TabIndex = 27;
            this.lbl_nombres.Text = "Nombres";
            // 
            // lbl_genero
            // 
            this.lbl_genero.AutoSize = true;
            this.lbl_genero.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genero.Location = new System.Drawing.Point(468, 40);
            this.lbl_genero.Name = "lbl_genero";
            this.lbl_genero.Size = new System.Drawing.Size(63, 18);
            this.lbl_genero.TabIndex = 26;
            this.lbl_genero.Text = "Género";
            // 
            // txt_num_documento
            // 
            this.txt_num_documento.Location = new System.Drawing.Point(317, 67);
            this.txt_num_documento.Name = "txt_num_documento";
            this.txt_num_documento.Size = new System.Drawing.Size(131, 26);
            this.txt_num_documento.TabIndex = 25;
            // 
            // lbl_num_documento
            // 
            this.lbl_num_documento.AutoSize = true;
            this.lbl_num_documento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_num_documento.Location = new System.Drawing.Point(314, 40);
            this.lbl_num_documento.Name = "lbl_num_documento";
            this.lbl_num_documento.Size = new System.Drawing.Size(116, 18);
            this.lbl_num_documento.TabIndex = 24;
            this.lbl_num_documento.Text = "N. Documento";
            this.lbl_num_documento.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_tipo_documento
            // 
            this.txt_tipo_documento.Location = new System.Drawing.Point(165, 67);
            this.txt_tipo_documento.Name = "txt_tipo_documento";
            this.txt_tipo_documento.Size = new System.Drawing.Size(131, 26);
            this.txt_tipo_documento.TabIndex = 23;
            // 
            // lbl_tipo_documento
            // 
            this.lbl_tipo_documento.AutoSize = true;
            this.lbl_tipo_documento.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_documento.Location = new System.Drawing.Point(162, 40);
            this.lbl_tipo_documento.Name = "lbl_tipo_documento";
            this.lbl_tipo_documento.Size = new System.Drawing.Size(131, 18);
            this.lbl_tipo_documento.TabIndex = 22;
            this.lbl_tipo_documento.Text = "Tipo Documento";
            // 
            // txt_fecha_registro
            // 
            this.txt_fecha_registro.Location = new System.Drawing.Point(17, 67);
            this.txt_fecha_registro.Name = "txt_fecha_registro";
            this.txt_fecha_registro.Size = new System.Drawing.Size(131, 26);
            this.txt_fecha_registro.TabIndex = 21;
            this.txt_fecha_registro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_fecha_registro
            // 
            this.lbl_fecha_registro.AutoSize = true;
            this.lbl_fecha_registro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_registro.Location = new System.Drawing.Point(14, 40);
            this.lbl_fecha_registro.Name = "lbl_fecha_registro";
            this.lbl_fecha_registro.Size = new System.Drawing.Size(118, 18);
            this.lbl_fecha_registro.TabIndex = 20;
            this.lbl_fecha_registro.Text = "Fecha Registro";
            // 
            // groupBox_img_usu
            // 
            this.groupBox_img_usu.Controls.Add(this.btn_img);
            this.groupBox_img_usu.Controls.Add(this.pictureBox_usu);
            this.groupBox_img_usu.Controls.Add(this.groupBox4);
            this.groupBox_img_usu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_img_usu.Location = new System.Drawing.Point(667, 62);
            this.groupBox_img_usu.Name = "groupBox_img_usu";
            this.groupBox_img_usu.Size = new System.Drawing.Size(257, 628);
            this.groupBox_img_usu.TabIndex = 3;
            this.groupBox_img_usu.TabStop = false;
            this.groupBox_img_usu.Text = "Imagen Usuario";
            // 
            // btn_img
            // 
            this.btn_img.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_img.Location = new System.Drawing.Point(55, 308);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(148, 34);
            this.btn_img.TabIndex = 4;
            this.btn_img.Text = "Cargar Imagen";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_usu
            // 
            this.pictureBox_usu.Image = global::conexion_db_001.Properties.Resources.pngegg;
            this.pictureBox_usu.Location = new System.Drawing.Point(23, 80);
            this.pictureBox_usu.Name = "pictureBox_usu";
            this.pictureBox_usu.Size = new System.Drawing.Size(210, 184);
            this.pictureBox_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_usu.TabIndex = 7;
            this.pictureBox_usu.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_inactivo);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.checkBox_activo);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(23, 391);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 116);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado Usuario";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // checkBox_inactivo
            // 
            this.checkBox_inactivo.AutoSize = true;
            this.checkBox_inactivo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_inactivo.Location = new System.Drawing.Point(18, 79);
            this.checkBox_inactivo.Name = "checkBox_inactivo";
            this.checkBox_inactivo.Size = new System.Drawing.Size(86, 22);
            this.checkBox_inactivo.TabIndex = 5;
            this.checkBox_inactivo.Text = "Inactivo";
            this.checkBox_inactivo.UseVisualStyleBackColor = true;
            this.checkBox_inactivo.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(53, 259);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 22);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Inactivo";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox_activo
            // 
            this.checkBox_activo.AutoSize = true;
            this.checkBox_activo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_activo.Location = new System.Drawing.Point(18, 43);
            this.checkBox_activo.Name = "checkBox_activo";
            this.checkBox_activo.Size = new System.Drawing.Size(73, 22);
            this.checkBox_activo.TabIndex = 4;
            this.checkBox_activo.Text = "Activo";
            this.checkBox_activo.UseVisualStyleBackColor = true;
            this.checkBox_activo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(53, 236);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 22);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Activo";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.lbl_info);
            this.groupBox_info.Controls.Add(this.checkBox6);
            this.groupBox_info.Controls.Add(this.checkBox8);
            this.groupBox_info.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_info.Location = new System.Drawing.Point(26, 706);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(898, 56);
            this.groupBox_info.TabIndex = 7;
            this.groupBox_info.TabStop = false;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(890, 24);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(34, 20);
            this.textBox16.TabIndex = 53;
            this.textBox16.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(811, 24);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(34, 20);
            this.textBox15.TabIndex = 52;
            this.textBox15.Visible = false;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(734, 24);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(34, 20);
            this.textBox14.TabIndex = 51;
            this.textBox14.Visible = false;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(655, 24);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(34, 20);
            this.textBox13.TabIndex = 50;
            this.textBox13.Visible = false;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(578, 24);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(34, 20);
            this.textBox11.TabIndex = 49;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(502, 24);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(34, 20);
            this.textBox12.TabIndex = 48;
            this.textBox12.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(53, 259);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(86, 22);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Inactivo";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(53, 236);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(73, 22);
            this.checkBox8.TabIndex = 4;
            this.checkBox8.Text = "Activo";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(30, 22);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(830, 18);
            this.lbl_info.TabIndex = 47;
            this.lbl_info.Text = "SERVICIO NACIONAL DE APRENDIZAJE SENA - CENTRO AGROPECUARIO - REGIONAL CAUCA";
            this.lbl_info.Click += new System.EventHandler(this.label20_Click);
            // 
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 784);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.groupBox_img_usu);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.groupBox_datos_ingreso);
            this.Controls.Add(this.groupBox_opciones_formulario);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.lbl_titulo_formulario);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Name = "frm_Usuario";
            this.Text = "SERVICIO NACIONAL DE APRENDIZAJE SENA";
            this.groupBox_opciones_formulario.ResumeLayout(false);
            this.groupBox_opciones_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox_datos_ingreso.ResumeLayout(false);
            this.groupBox_datos_ingreso.PerformLayout();
            this.groupBox_img_usu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_usu)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_formulario;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_genero;
        private System.Windows.Forms.GroupBox groupBox_opciones_formulario;
        private System.Windows.Forms.GroupBox groupBox_datos_ingreso;
        private System.Windows.Forms.GroupBox groupBox_img_usu;
        private System.Windows.Forms.CheckBox checkBox_inactivo;
        private System.Windows.Forms.CheckBox checkBox_activo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.PictureBox pictureBox_usu;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.Label lbl_actualizar;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_guardar;
        private System.Windows.Forms.Label lbl_borrar;
        private System.Windows.Forms.Label lbl_cancelar;
        private System.Windows.Forms.Label lbl_buscar;
        private System.Windows.Forms.TextBox txt_fecha_registro;
        private System.Windows.Forms.Label lbl_fecha_registro;
        private System.Windows.Forms.TextBox txt_tipo_documento;
        private System.Windows.Forms.Label lbl_tipo_documento;
        private System.Windows.Forms.Label lbl_num_documento;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.Label lbl_genero;
        private System.Windows.Forms.TextBox txt_num_documento;
        private System.Windows.Forms.Label lbl_municipio;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.ComboBox comboBox_departamentos;
        private System.Windows.Forms.Label lbl_departamentos;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label lbl_clave;
        private System.Windows.Forms.TextBox txt_usu;
        private System.Windows.Forms.Label lbl_usu;
        private System.Windows.Forms.ComboBox comboBox_rol;
        private System.Windows.Forms.Label lbl_rol;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.ComboBox comboBox_municipio;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label lbl_info;
    }
}