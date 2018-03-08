namespace WinAgenda
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_hora = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.pict_contac = new System.Windows.Forms.PictureBox();
            this.pict_mostrar = new System.Windows.Forms.PictureBox();
            this.panel_ingresar = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_paginaweb = new System.Windows.Forms.TextBox();
            this.txt_beeper = new System.Windows.Forms.TextBox();
            this.pict_regresar = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lb_titulo_ingresar = new System.Windows.Forms.Label();
            this.cmb_Sexo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_mostrar = new System.Windows.Forms.Panel();
            this.bt_exportar = new System.Windows.Forms.PictureBox();
            this.pict_regresar2 = new System.Windows.Forms.PictureBox();
            this.pict_modificar = new System.Windows.Forms.PictureBox();
            this.pict_eliminar = new System.Windows.Forms.PictureBox();
            this.grid_mostrar = new System.Windows.Forms.DataGridView();
            this.lb_by = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict_contac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_mostrar)).BeginInit();
            this.panel_ingresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel_mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bt_exportar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_regresar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_hora
            // 
            this.lb_hora.AutoSize = true;
            this.lb_hora.BackColor = System.Drawing.Color.Transparent;
            this.lb_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hora.Location = new System.Drawing.Point(-2, 15);
            this.lb_hora.Name = "lb_hora";
            this.lb_hora.Size = new System.Drawing.Size(135, 33);
            this.lb_hora.TabIndex = 0;
            this.lb_hora.Text = "00:00:00";
            // 
            // lb_fecha
            // 
            this.lb_fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lb_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.Location = new System.Drawing.Point(156, 28);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(130, 20);
            this.lb_fecha.TabIndex = 1;
            this.lb_fecha.Text = "dia, dia de mes";
            this.lb_fecha.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(218)))));
            this.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_agregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_agregar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(159, 262);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(129, 35);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "AGREGAR NUEVO";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(218)))));
            this.btn_mostrar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrar.ForeColor = System.Drawing.Color.White;
            this.btn_mostrar.Location = new System.Drawing.Point(351, 262);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(129, 35);
            this.btn_mostrar.TabIndex = 3;
            this.btn_mostrar.Text = "MOSTRAR";
            this.btn_mostrar.UseVisualStyleBackColor = false;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // pict_contac
            // 
            this.pict_contac.Image = global::WinAgenda.Properties.Resources.Users_2;
            this.pict_contac.Location = new System.Drawing.Point(160, 128);
            this.pict_contac.Name = "pict_contac";
            this.pict_contac.Size = new System.Drawing.Size(128, 128);
            this.pict_contac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pict_contac.TabIndex = 4;
            this.pict_contac.TabStop = false;
            // 
            // pict_mostrar
            // 
            this.pict_mostrar.Image = global::WinAgenda.Properties.Resources.Search_1;
            this.pict_mostrar.Location = new System.Drawing.Point(352, 128);
            this.pict_mostrar.Name = "pict_mostrar";
            this.pict_mostrar.Size = new System.Drawing.Size(128, 128);
            this.pict_mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pict_mostrar.TabIndex = 5;
            this.pict_mostrar.TabStop = false;
            // 
            // panel_ingresar
            // 
            this.panel_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.panel_ingresar.Controls.Add(this.label12);
            this.panel_ingresar.Controls.Add(this.label3);
            this.panel_ingresar.Controls.Add(this.label4);
            this.panel_ingresar.Controls.Add(this.label2);
            this.panel_ingresar.Controls.Add(this.label1);
            this.panel_ingresar.Controls.Add(this.txt_correo);
            this.panel_ingresar.Controls.Add(this.txt_telefono);
            this.panel_ingresar.Controls.Add(this.txt_celular);
            this.panel_ingresar.Controls.Add(this.txt_direccion);
            this.panel_ingresar.Controls.Add(this.txt_paginaweb);
            this.panel_ingresar.Controls.Add(this.txt_beeper);
            this.panel_ingresar.Controls.Add(this.pict_regresar);
            this.panel_ingresar.Controls.Add(this.btn_guardar);
            this.panel_ingresar.Controls.Add(this.picture);
            this.panel_ingresar.Controls.Add(this.txt_edad);
            this.panel_ingresar.Controls.Add(this.txt_apellidos);
            this.panel_ingresar.Controls.Add(this.txt_nombres);
            this.panel_ingresar.Controls.Add(this.lb_titulo_ingresar);
            this.panel_ingresar.Controls.Add(this.cmb_Sexo);
            this.panel_ingresar.Controls.Add(this.label14);
            this.panel_ingresar.Controls.Add(this.label5);
            this.panel_ingresar.Controls.Add(this.label8);
            this.panel_ingresar.Controls.Add(this.label6);
            this.panel_ingresar.Controls.Add(this.label7);
            this.panel_ingresar.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ingresar.ForeColor = System.Drawing.Color.Black;
            this.panel_ingresar.Location = new System.Drawing.Point(4, 60);
            this.panel_ingresar.Name = "panel_ingresar";
            this.panel_ingresar.Size = new System.Drawing.Size(613, 402);
            this.panel_ingresar.TabIndex = 6;
            this.panel_ingresar.Visible = false;
            this.panel_ingresar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_ingresar_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "APELLIDOS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "CORREO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 59;
            this.label4.Text = "TELEFONO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(345, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 58;
            this.label2.Text = "DIRECCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "NOMBRES:";
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(134, 188);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(150, 22);
            this.txt_correo.TabIndex = 9;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(134, 214);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(150, 22);
            this.txt_telefono.TabIndex = 10;
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(134, 240);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(150, 22);
            this.txt_celular.TabIndex = 11;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(446, 63);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(150, 22);
            this.txt_direccion.TabIndex = 12;
            // 
            // txt_paginaweb
            // 
            this.txt_paginaweb.Location = new System.Drawing.Point(446, 89);
            this.txt_paginaweb.Name = "txt_paginaweb";
            this.txt_paginaweb.Size = new System.Drawing.Size(150, 22);
            this.txt_paginaweb.TabIndex = 13;
            // 
            // txt_beeper
            // 
            this.txt_beeper.Location = new System.Drawing.Point(446, 115);
            this.txt_beeper.Name = "txt_beeper";
            this.txt_beeper.Size = new System.Drawing.Size(150, 22);
            this.txt_beeper.TabIndex = 14;
            // 
            // pict_regresar
            // 
            this.pict_regresar.Image = global::WinAgenda.Properties.Resources._622901;
            this.pict_regresar.Location = new System.Drawing.Point(8, 339);
            this.pict_regresar.Name = "pict_regresar";
            this.pict_regresar.Size = new System.Drawing.Size(50, 50);
            this.pict_regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_regresar.TabIndex = 11;
            this.pict_regresar.TabStop = false;
            this.pict_regresar.Click += new System.EventHandler(this.pict_regresar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(150)))), ((int)(((byte)(218)))));
            this.btn_guardar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(224, 297);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(120, 35);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar Datos";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // picture
            // 
            this.picture.Image = global::WinAgenda.Properties.Resources.Contact;
            this.picture.Location = new System.Drawing.Point(446, 187);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(128, 128);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 9;
            this.picture.TabStop = false;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(134, 162);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(150, 22);
            this.txt_edad.TabIndex = 8;
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(134, 100);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(150, 22);
            this.txt_apellidos.TabIndex = 6;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(134, 68);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(150, 22);
            this.txt_nombres.TabIndex = 5;
            // 
            // lb_titulo_ingresar
            // 
            this.lb_titulo_ingresar.AutoSize = true;
            this.lb_titulo_ingresar.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_ingresar.Location = new System.Drawing.Point(5, 9);
            this.lb_titulo_ingresar.Name = "lb_titulo_ingresar";
            this.lb_titulo_ingresar.Size = new System.Drawing.Size(124, 18);
            this.lb_titulo_ingresar.TabIndex = 0;
            this.lb_titulo_ingresar.Text = "Ingresar Nuevo";
            // 
            // cmb_Sexo
            // 
            this.cmb_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sexo.FormattingEnabled = true;
            this.cmb_Sexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cmb_Sexo.Location = new System.Drawing.Point(134, 133);
            this.cmb_Sexo.Name = "cmb_Sexo";
            this.cmb_Sexo.Size = new System.Drawing.Size(150, 23);
            this.cmb_Sexo.TabIndex = 7;
            this.cmb_Sexo.SelectedIndexChanged += new System.EventHandler(this.cmb_Sexo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(361, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 15);
            this.label14.TabIndex = 66;
            this.label14.Text = "BEEPER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(349, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 67;
            this.label5.Text = "PAG. WEB:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(40, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 64;
            this.label8.Text = "CELULAR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "SEXO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 62;
            this.label7.Text = "EDAD:";
            // 
            // panel_mostrar
            // 
            this.panel_mostrar.BackColor = System.Drawing.Color.Transparent;
            this.panel_mostrar.Controls.Add(this.bt_exportar);
            this.panel_mostrar.Controls.Add(this.pict_regresar2);
            this.panel_mostrar.Controls.Add(this.pict_modificar);
            this.panel_mostrar.Controls.Add(this.pict_eliminar);
            this.panel_mostrar.Controls.Add(this.grid_mostrar);
            this.panel_mostrar.Location = new System.Drawing.Point(4, 60);
            this.panel_mostrar.Name = "panel_mostrar";
            this.panel_mostrar.Size = new System.Drawing.Size(613, 402);
            this.panel_mostrar.TabIndex = 12;
            this.panel_mostrar.Visible = false;
            this.panel_mostrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_mostrar_Paint);
            // 
            // bt_exportar
            // 
            this.bt_exportar.Image = global::WinAgenda.Properties.Resources.export_icon_icons_com_69529;
            this.bt_exportar.Location = new System.Drawing.Point(384, 297);
            this.bt_exportar.Name = "bt_exportar";
            this.bt_exportar.Size = new System.Drawing.Size(50, 50);
            this.bt_exportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bt_exportar.TabIndex = 15;
            this.bt_exportar.TabStop = false;
            this.bt_exportar.Visible = false;
            this.bt_exportar.Click += new System.EventHandler(this.bt_exportar_Click);
            // 
            // pict_regresar2
            // 
            this.pict_regresar2.Image = global::WinAgenda.Properties.Resources._62290;
            this.pict_regresar2.Location = new System.Drawing.Point(8, 297);
            this.pict_regresar2.Name = "pict_regresar2";
            this.pict_regresar2.Size = new System.Drawing.Size(50, 50);
            this.pict_regresar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_regresar2.TabIndex = 11;
            this.pict_regresar2.TabStop = false;
            this.pict_regresar2.Click += new System.EventHandler(this.pict_regresar2_Click);
            // 
            // pict_modificar
            // 
            this.pict_modificar.Image = global::WinAgenda.Properties.Resources.male_user_edit_25348;
            this.pict_modificar.Location = new System.Drawing.Point(455, 297);
            this.pict_modificar.Name = "pict_modificar";
            this.pict_modificar.Size = new System.Drawing.Size(50, 50);
            this.pict_modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_modificar.TabIndex = 14;
            this.pict_modificar.TabStop = false;
            this.pict_modificar.Visible = false;
            this.pict_modificar.Click += new System.EventHandler(this.pict_modificar_Click);
            // 
            // pict_eliminar
            // 
            this.pict_eliminar.Image = global::WinAgenda.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.pict_eliminar.Location = new System.Drawing.Point(524, 297);
            this.pict_eliminar.Name = "pict_eliminar";
            this.pict_eliminar.Size = new System.Drawing.Size(50, 50);
            this.pict_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_eliminar.TabIndex = 13;
            this.pict_eliminar.TabStop = false;
            this.pict_eliminar.Visible = false;
            this.pict_eliminar.Click += new System.EventHandler(this.pict_eliminar_Click);
            // 
            // grid_mostrar
            // 
            this.grid_mostrar.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.grid_mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_mostrar.Location = new System.Drawing.Point(0, 0);
            this.grid_mostrar.Name = "grid_mostrar";
            this.grid_mostrar.RowHeadersVisible = false;
            this.grid_mostrar.Size = new System.Drawing.Size(613, 402);
            this.grid_mostrar.TabIndex = 12;
            this.grid_mostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_mostrar_CellContentClick);
            this.grid_mostrar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_mostrar_CellMouseClick);
            // 
            // lb_by
            // 
            this.lb_by.AutoSize = true;
            this.lb_by.BackColor = System.Drawing.Color.Transparent;
            this.lb_by.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_by.ForeColor = System.Drawing.Color.Black;
            this.lb_by.Location = new System.Drawing.Point(160, 378);
            this.lb_by.Name = "lb_by";
            this.lb_by.Size = new System.Drawing.Size(320, 40);
            this.lb_by.TabIndex = 13;
            this.lb_by.Text = "By: Luis David Moscoso Almanzar\r\n            Matricula: 1-15-5161";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinAgenda.Properties.Resources.Abstract_3D_Box_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 461);
            this.Controls.Add(this.panel_mostrar);
            this.Controls.Add(this.panel_ingresar);
            this.Controls.Add(this.pict_mostrar);
            this.Controls.Add(this.pict_contac);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.lb_fecha);
            this.Controls.Add(this.lb_hora);
            this.Controls.Add(this.lb_by);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(635, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(635, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pict_contac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_mostrar)).EndInit();
            this.panel_ingresar.ResumeLayout(false);
            this.panel_ingresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel_mostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bt_exportar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_regresar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hora;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.PictureBox pict_contac;
        private System.Windows.Forms.PictureBox pict_mostrar;
        private System.Windows.Forms.Panel panel_ingresar;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lb_titulo_ingresar;
        private System.Windows.Forms.PictureBox pict_regresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Panel panel_mostrar;
        private System.Windows.Forms.DataGridView grid_mostrar;
        private System.Windows.Forms.PictureBox pict_regresar2;
        private System.Windows.Forms.Label lb_by;
        private System.Windows.Forms.PictureBox pict_modificar;
        private System.Windows.Forms.PictureBox pict_eliminar;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_paginaweb;
        private System.Windows.Forms.TextBox txt_beeper;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sexo;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox bt_exportar;
    }
}

