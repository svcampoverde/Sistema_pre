namespace Presentacion.ModuloUsuario
{
    partial class FrmRegistrarUsuario
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtCedula = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtNombre = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtApellido = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtCorreo = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtUsuario = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit5 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit6 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit7 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit8 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit9 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit10 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit11 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit12 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit13 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtTelefono = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtDireccion = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtClave = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtCelular = new ReaLTaiizor.Controls.TextBoxEdit();
            this.btnGuardar = new Presentacion.btnpersonalizados.Botonper();
            this.cbRol = new Presentacion.btnpersonalizados.PersonComboBox();
            this.cmbGenero = new Presentacion.btnpersonalizados.PersonComboBox();
            this.cmbCiudad = new Presentacion.btnpersonalizados.PersonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(77, 84);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(63, 20);
            this.labelEdit1.TabIndex = 1;
            this.labelEdit1.Text = "Cedula:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(309, 33);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(195, 20);
            this.labelEdit2.TabIndex = 2;
            this.labelEdit2.Text = "Modificar datos de usuario";
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.Transparent;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCedula.ForeColor = System.Drawing.Color.White;
            this.txtCedula.Image = null;
            this.txtCedula.Location = new System.Drawing.Point(152, 73);
            this.txtCedula.MaxLength = 32767;
            this.txtCedula.Multiline = false;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = false;
            this.txtCedula.Size = new System.Drawing.Size(200, 42);
            this.txtCedula.TabIndex = 3;
            this.txtCedula.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCedula.UseSystemPasswordChar = false;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtNombre.Image = null;
            this.txtNombre.Location = new System.Drawing.Point(152, 129);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = false;
            this.txtNombre.Size = new System.Drawing.Size(200, 42);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.UseSystemPasswordChar = false;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtApellido.Image = null;
            this.txtApellido.Location = new System.Drawing.Point(152, 184);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = false;
            this.txtApellido.Size = new System.Drawing.Size(200, 42);
            this.txtApellido.TabIndex = 28;
            this.txtApellido.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtApellido.UseSystemPasswordChar = false;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtCorreo.Image = null;
            this.txtCorreo.Location = new System.Drawing.Point(152, 295);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.Size = new System.Drawing.Size(200, 42);
            this.txtCorreo.TabIndex = 29;
            this.txtCorreo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.UseSystemPasswordChar = false;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtUsuario.Image = null;
            this.txtUsuario.Location = new System.Drawing.Point(152, 346);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.Size = new System.Drawing.Size(200, 42);
            this.txtUsuario.TabIndex = 32;
            this.txtUsuario.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(77, 142);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(69, 20);
            this.labelEdit3.TabIndex = 33;
            this.labelEdit3.Text = "Nombre:";
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit4.ForeColor = System.Drawing.Color.White;
            this.labelEdit4.Location = new System.Drawing.Point(77, 195);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(69, 20);
            this.labelEdit4.TabIndex = 34;
            this.labelEdit4.Text = "Apellido:";
            // 
            // labelEdit5
            // 
            this.labelEdit5.AutoSize = true;
            this.labelEdit5.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit5.ForeColor = System.Drawing.Color.White;
            this.labelEdit5.Location = new System.Drawing.Point(79, 247);
            this.labelEdit5.Name = "labelEdit5";
            this.labelEdit5.Size = new System.Drawing.Size(67, 20);
            this.labelEdit5.TabIndex = 35;
            this.labelEdit5.Text = "Género:";
            // 
            // labelEdit6
            // 
            this.labelEdit6.AutoSize = true;
            this.labelEdit6.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit6.ForeColor = System.Drawing.Color.White;
            this.labelEdit6.Location = new System.Drawing.Point(79, 304);
            this.labelEdit6.Name = "labelEdit6";
            this.labelEdit6.Size = new System.Drawing.Size(61, 20);
            this.labelEdit6.TabIndex = 36;
            this.labelEdit6.Text = "Correo:";
            // 
            // labelEdit7
            // 
            this.labelEdit7.AutoSize = true;
            this.labelEdit7.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit7.ForeColor = System.Drawing.Color.White;
            this.labelEdit7.Location = new System.Drawing.Point(72, 355);
            this.labelEdit7.Name = "labelEdit7";
            this.labelEdit7.Size = new System.Drawing.Size(68, 20);
            this.labelEdit7.TabIndex = 37;
            this.labelEdit7.Text = "Usuario:";
            // 
            // labelEdit8
            // 
            this.labelEdit8.AutoSize = true;
            this.labelEdit8.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit8.ForeColor = System.Drawing.Color.White;
            this.labelEdit8.Location = new System.Drawing.Point(395, 84);
            this.labelEdit8.Name = "labelEdit8";
            this.labelEdit8.Size = new System.Drawing.Size(75, 20);
            this.labelEdit8.TabIndex = 38;
            this.labelEdit8.Text = "Télefono:";
            // 
            // labelEdit9
            // 
            this.labelEdit9.AutoSize = true;
            this.labelEdit9.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit9.ForeColor = System.Drawing.Color.White;
            this.labelEdit9.Location = new System.Drawing.Point(395, 139);
            this.labelEdit9.Name = "labelEdit9";
            this.labelEdit9.Size = new System.Drawing.Size(62, 20);
            this.labelEdit9.TabIndex = 39;
            this.labelEdit9.Text = "Celular:";
            // 
            // labelEdit10
            // 
            this.labelEdit10.AutoSize = true;
            this.labelEdit10.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit10.ForeColor = System.Drawing.Color.White;
            this.labelEdit10.Location = new System.Drawing.Point(395, 195);
            this.labelEdit10.Name = "labelEdit10";
            this.labelEdit10.Size = new System.Drawing.Size(63, 20);
            this.labelEdit10.TabIndex = 40;
            this.labelEdit10.Text = "Ciudad:";
            // 
            // labelEdit11
            // 
            this.labelEdit11.AutoSize = true;
            this.labelEdit11.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit11.ForeColor = System.Drawing.Color.White;
            this.labelEdit11.Location = new System.Drawing.Point(395, 247);
            this.labelEdit11.Name = "labelEdit11";
            this.labelEdit11.Size = new System.Drawing.Size(79, 20);
            this.labelEdit11.TabIndex = 41;
            this.labelEdit11.Text = "Dirección:";
            // 
            // labelEdit12
            // 
            this.labelEdit12.AutoSize = true;
            this.labelEdit12.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit12.ForeColor = System.Drawing.Color.White;
            this.labelEdit12.Location = new System.Drawing.Point(395, 304);
            this.labelEdit12.Name = "labelEdit12";
            this.labelEdit12.Size = new System.Drawing.Size(121, 20);
            this.labelEdit12.TabIndex = 42;
            this.labelEdit12.Text = "Tipo de usuario:";
            // 
            // labelEdit13
            // 
            this.labelEdit13.AutoSize = true;
            this.labelEdit13.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit13.ForeColor = System.Drawing.Color.White;
            this.labelEdit13.Location = new System.Drawing.Point(395, 355);
            this.labelEdit13.Name = "labelEdit13";
            this.labelEdit13.Size = new System.Drawing.Size(96, 20);
            this.labelEdit13.TabIndex = 43;
            this.labelEdit13.Text = "Contraseña:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtTelefono.Image = null;
            this.txtTelefono.Location = new System.Drawing.Point(520, 73);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.Size = new System.Drawing.Size(200, 42);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtDireccion.Image = null;
            this.txtDireccion.Location = new System.Drawing.Point(520, 238);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = false;
            this.txtDireccion.Size = new System.Drawing.Size(200, 42);
            this.txtDireccion.TabIndex = 46;
            this.txtDireccion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.UseSystemPasswordChar = false;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.Transparent;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtClave.Image = null;
            this.txtClave.Location = new System.Drawing.Point(520, 346);
            this.txtClave.MaxLength = 32767;
            this.txtClave.Multiline = false;
            this.txtClave.Name = "txtClave";
            this.txtClave.ReadOnly = false;
            this.txtClave.Size = new System.Drawing.Size(200, 42);
            this.txtClave.TabIndex = 47;
            this.txtClave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClave.UseSystemPasswordChar = false;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.Color.Transparent;
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtCelular.Image = null;
            this.txtCelular.Location = new System.Drawing.Point(520, 129);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.Multiline = false;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = false;
            this.txtCelular.Size = new System.Drawing.Size(200, 42);
            this.txtCelular.TabIndex = 45;
            this.txtCelular.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCelular.UseSystemPasswordChar = false;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(313, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbRol
            // 
            this.cbRol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cbRol.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cbRol.BorderRadius = 0;
            this.cbRol.BorderSize = 0;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cbRol.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cbRol.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cbRol.ListTextColor = System.Drawing.Color.DimGray;
            this.cbRol.Location = new System.Drawing.Point(522, 295);
            this.cbRol.MinimumSize = new System.Drawing.Size(200, 42);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(200, 42);
            this.cbRol.TabIndex = 50;
            this.cbRol.Texts = "";
            this.cbRol.TabIndexChanged += new System.EventHandler(this.cbRol_TabIndexChanged);
            // 
            // cmbGenero
            // 
            this.cmbGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cmbGenero.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbGenero.BorderRadius = 0;
            this.cmbGenero.BorderSize = 0;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbGenero.IconColor = System.Drawing.Color.MediumPurple;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbGenero.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cmbGenero.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbGenero.Location = new System.Drawing.Point(152, 238);
            this.cmbGenero.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(200, 42);
            this.cmbGenero.TabIndex = 49;
            this.cmbGenero.Texts = "";
            this.cmbGenero.OnSelectedIndexChanged += new System.EventHandler(this.cmbGenero_OnSelectedIndexChanged);
            this.cmbGenero.TabIndexChanged += new System.EventHandler(this.cmbGenero_TabIndexChanged);
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cmbCiudad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCiudad.BorderRadius = 0;
            this.cmbCiudad.BorderSize = 0;
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbCiudad.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbCiudad.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cmbCiudad.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbCiudad.Location = new System.Drawing.Point(520, 185);
            this.cmbCiudad.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(202, 36);
            this.cmbCiudad.TabIndex = 48;
            this.cmbCiudad.Texts = "";
            this.cmbCiudad.TabIndexChanged += new System.EventHandler(this.cmbCiudad_TabIndexChanged);
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(816, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbRol);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelEdit13);
            this.Controls.Add(this.labelEdit12);
            this.Controls.Add(this.labelEdit11);
            this.Controls.Add(this.labelEdit10);
            this.Controls.Add(this.labelEdit9);
            this.Controls.Add(this.labelEdit8);
            this.Controls.Add(this.labelEdit7);
            this.Controls.Add(this.labelEdit6);
            this.Controls.Add(this.labelEdit5);
            this.Controls.Add(this.labelEdit4);
            this.Controls.Add(this.labelEdit3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelEdit2);
            this.Controls.Add(this.labelEdit1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FrmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmRegistrarUsuario";
            this.Load += new System.EventHandler(this.FrmRegistrarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.TextBoxEdit txtCedula;
        private ReaLTaiizor.Controls.TextBoxEdit txtApellido;
        private ReaLTaiizor.Controls.TextBoxEdit txtNombre;
        private ReaLTaiizor.Controls.TextBoxEdit txtCorreo;
        private ReaLTaiizor.Controls.TextBoxEdit txtUsuario;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit6;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
        private ReaLTaiizor.Controls.LabelEdit labelEdit7;
        private ReaLTaiizor.Controls.LabelEdit labelEdit10;
        private ReaLTaiizor.Controls.LabelEdit labelEdit9;
        private ReaLTaiizor.Controls.LabelEdit labelEdit8;
        private ReaLTaiizor.Controls.LabelEdit labelEdit13;
        private ReaLTaiizor.Controls.LabelEdit labelEdit12;
        private ReaLTaiizor.Controls.LabelEdit labelEdit11;
        private ReaLTaiizor.Controls.TextBoxEdit txtTelefono;
        private ReaLTaiizor.Controls.TextBoxEdit txtClave;
        private ReaLTaiizor.Controls.TextBoxEdit txtDireccion;
        private btnpersonalizados.PersonComboBox cmbGenero;
        private btnpersonalizados.PersonComboBox cbRol;
        private btnpersonalizados.Botonper btnGuardar;
        private btnpersonalizados.PersonComboBox cmbCiudad;
        private ReaLTaiizor.Controls.TextBoxEdit txtCelular;
    }
}