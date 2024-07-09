namespace Presentacion.ModuloEmpresa
{
    partial class FrmEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.btnBuscaremp = new ReaLTaiizor.Controls.Button();
            this.txtBemp = new ReaLTaiizor.Controls.TextBoxEdit();
            this.dtgEmpresa = new System.Windows.Forms.DataGridView();
            this.idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlRegEmp = new System.Windows.Forms.Panel();
            this.ptbleft = new System.Windows.Forms.PictureBox();
            this.labelEdit12 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtDireccion = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit11 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit6 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtCorreo = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtTelefono = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit8 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtEmpresa = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlListEmp = new System.Windows.Forms.Panel();
            this.ptbadd = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlMempresa = new System.Windows.Forms.Panel();
            this.ptbleftm = new System.Windows.Forms.PictureBox();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtMdireccion = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit5 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtMcorreo = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtMtelefono = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit7 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtMempresa = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit9 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit10 = new ReaLTaiizor.Controls.LabelEdit();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnActualizarEmp = new Presentacion.btnpersonalizados.Botonper();
            this.cmbMtipemp = new Presentacion.btnpersonalizados.PersonComboBox();
            this.btnGuardarE = new Presentacion.btnpersonalizados.Botonper();
            this.cmbtipempresa = new Presentacion.btnpersonalizados.PersonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).BeginInit();
            this.pnlRegEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbleft)).BeginInit();
            this.pnlListEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlMempresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbleftm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscaremp
            // 
            this.btnBuscaremp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscaremp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaremp.EnteredColor = System.Drawing.Color.Transparent;
            this.btnBuscaremp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscaremp.Image = null;
            this.btnBuscaremp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaremp.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscaremp.Location = new System.Drawing.Point(400, 19);
            this.btnBuscaremp.Name = "btnBuscaremp";
            this.btnBuscaremp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscaremp.Size = new System.Drawing.Size(71, 42);
            this.btnBuscaremp.TabIndex = 83;
            this.btnBuscaremp.Text = "Buscar";
            this.btnBuscaremp.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscaremp.Click += new System.EventHandler(this.btnBuscaremp_Click);
            // 
            // txtBemp
            // 
            this.txtBemp.BackColor = System.Drawing.Color.Transparent;
            this.txtBemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBemp.Image = null;
            this.txtBemp.Location = new System.Drawing.Point(144, 19);
            this.txtBemp.MaxLength = 32767;
            this.txtBemp.Multiline = false;
            this.txtBemp.Name = "txtBemp";
            this.txtBemp.ReadOnly = false;
            this.txtBemp.Size = new System.Drawing.Size(259, 42);
            this.txtBemp.TabIndex = 82;
            this.txtBemp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBemp.UseSystemPasswordChar = false;
            this.txtBemp.TextChanged += new System.EventHandler(this.txtBemp_TextChanged);
            // 
            // dtgEmpresa
            // 
            this.dtgEmpresa.AllowUserToAddRows = false;
            this.dtgEmpresa.AllowUserToDeleteRows = false;
            this.dtgEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgEmpresa.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempresa,
            this.empresa,
            this.tipempresa,
            this.telefono,
            this.correo,
            this.direccion,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpresa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgEmpresa.EnableHeadersVisualStyles = false;
            this.dtgEmpresa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgEmpresa.Location = new System.Drawing.Point(36, 80);
            this.dtgEmpresa.Name = "dtgEmpresa";
            this.dtgEmpresa.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmpresa.RowHeadersVisible = false;
            this.dtgEmpresa.RowHeadersWidth = 40;
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgEmpresa.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgEmpresa.Size = new System.Drawing.Size(908, 246);
            this.dtgEmpresa.TabIndex = 81;
            this.dtgEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpresa_CellClick);
            // 
            // idempresa
            // 
            this.idempresa.HeaderText = "Id";
            this.idempresa.Name = "idempresa";
            this.idempresa.ReadOnly = true;
            this.idempresa.Visible = false;
            this.idempresa.Width = 31;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // tipempresa
            // 
            this.tipempresa.HeaderText = "Tipo de Empresa";
            this.tipempresa.Name = "tipempresa";
            this.tipempresa.ReadOnly = true;
            this.tipempresa.Width = 143;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 98;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 84;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 102;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Width = 59;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Image = global::Presentacion.Properties.Resources.trash;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 73;
            // 
            // pnlRegEmp
            // 
            this.pnlRegEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegEmp.Controls.Add(this.ptbleft);
            this.pnlRegEmp.Controls.Add(this.btnGuardarE);
            this.pnlRegEmp.Controls.Add(this.cmbtipempresa);
            this.pnlRegEmp.Controls.Add(this.labelEdit12);
            this.pnlRegEmp.Controls.Add(this.txtDireccion);
            this.pnlRegEmp.Controls.Add(this.labelEdit11);
            this.pnlRegEmp.Controls.Add(this.labelEdit6);
            this.pnlRegEmp.Controls.Add(this.txtCorreo);
            this.pnlRegEmp.Controls.Add(this.txtTelefono);
            this.pnlRegEmp.Controls.Add(this.labelEdit8);
            this.pnlRegEmp.Controls.Add(this.txtEmpresa);
            this.pnlRegEmp.Controls.Add(this.labelEdit2);
            this.pnlRegEmp.Controls.Add(this.labelEdit1);
            this.pnlRegEmp.Location = new System.Drawing.Point(27, 28);
            this.pnlRegEmp.Name = "pnlRegEmp";
            this.pnlRegEmp.Size = new System.Drawing.Size(733, 420);
            this.pnlRegEmp.TabIndex = 84;
            // 
            // ptbleft
            // 
            this.ptbleft.Image = global::Presentacion.Properties.Resources.left_arrow;
            this.ptbleft.Location = new System.Drawing.Point(47, 19);
            this.ptbleft.Name = "ptbleft";
            this.ptbleft.Size = new System.Drawing.Size(47, 33);
            this.ptbleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbleft.TabIndex = 75;
            this.ptbleft.TabStop = false;
            this.ptbleft.Click += new System.EventHandler(this.ptbleft_Click);
            // 
            // labelEdit12
            // 
            this.labelEdit12.AutoSize = true;
            this.labelEdit12.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit12.ForeColor = System.Drawing.Color.White;
            this.labelEdit12.Location = new System.Drawing.Point(53, 269);
            this.labelEdit12.Name = "labelEdit12";
            this.labelEdit12.Size = new System.Drawing.Size(131, 20);
            this.labelEdit12.TabIndex = 58;
            this.labelEdit12.Text = "Tipo de empresa:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtDireccion.Image = null;
            this.txtDireccion.Location = new System.Drawing.Point(486, 117);
            this.txtDireccion.MaxLength = 32767;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = false;
            this.txtDireccion.Size = new System.Drawing.Size(200, 122);
            this.txtDireccion.TabIndex = 57;
            this.txtDireccion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // labelEdit11
            // 
            this.labelEdit11.AutoSize = true;
            this.labelEdit11.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit11.ForeColor = System.Drawing.Color.White;
            this.labelEdit11.Location = new System.Drawing.Point(361, 149);
            this.labelEdit11.Name = "labelEdit11";
            this.labelEdit11.Size = new System.Drawing.Size(79, 20);
            this.labelEdit11.TabIndex = 56;
            this.labelEdit11.Text = "Dirección:";
            // 
            // labelEdit6
            // 
            this.labelEdit6.AutoSize = true;
            this.labelEdit6.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit6.ForeColor = System.Drawing.Color.White;
            this.labelEdit6.Location = new System.Drawing.Point(43, 149);
            this.labelEdit6.Name = "labelEdit6";
            this.labelEdit6.Size = new System.Drawing.Size(61, 20);
            this.labelEdit6.TabIndex = 55;
            this.labelEdit6.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtCorreo.Image = null;
            this.txtCorreo.Location = new System.Drawing.Point(120, 117);
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = false;
            this.txtCorreo.Size = new System.Drawing.Size(200, 122);
            this.txtCorreo.TabIndex = 54;
            this.txtCorreo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCorreo.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtTelefono.Image = null;
            this.txtTelefono.Location = new System.Drawing.Point(488, 60);
            this.txtTelefono.MaxLength = 32767;
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = false;
            this.txtTelefono.Size = new System.Drawing.Size(200, 42);
            this.txtTelefono.TabIndex = 53;
            this.txtTelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // labelEdit8
            // 
            this.labelEdit8.AutoSize = true;
            this.labelEdit8.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit8.ForeColor = System.Drawing.Color.White;
            this.labelEdit8.Location = new System.Drawing.Point(363, 71);
            this.labelEdit8.Name = "labelEdit8";
            this.labelEdit8.Size = new System.Drawing.Size(75, 20);
            this.labelEdit8.TabIndex = 51;
            this.labelEdit8.Text = "Télefono:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmpresa.ForeColor = System.Drawing.Color.White;
            this.txtEmpresa.Image = null;
            this.txtEmpresa.Location = new System.Drawing.Point(120, 60);
            this.txtEmpresa.MaxLength = 32767;
            this.txtEmpresa.Multiline = false;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = false;
            this.txtEmpresa.Size = new System.Drawing.Size(200, 42);
            this.txtEmpresa.TabIndex = 48;
            this.txtEmpresa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmpresa.UseSystemPasswordChar = false;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(277, 20);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(187, 20);
            this.labelEdit2.TabIndex = 47;
            this.labelEdit2.Text = "Registrar nueva empresa";
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(45, 71);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(77, 20);
            this.labelEdit1.TabIndex = 46;
            this.labelEdit1.Text = "Empresa:";
            // 
            // pnlListEmp
            // 
            this.pnlListEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlListEmp.Controls.Add(this.ptbadd);
            this.pnlListEmp.Controls.Add(this.txtBemp);
            this.pnlListEmp.Controls.Add(this.dtgEmpresa);
            this.pnlListEmp.Controls.Add(this.btnBuscaremp);
            this.pnlListEmp.Location = new System.Drawing.Point(27, 28);
            this.pnlListEmp.Name = "pnlListEmp";
            this.pnlListEmp.Size = new System.Drawing.Size(996, 340);
            this.pnlListEmp.TabIndex = 85;
            // 
            // ptbadd
            // 
            this.ptbadd.Image = global::Presentacion.Properties.Resources.add;
            this.ptbadd.Location = new System.Drawing.Point(36, 19);
            this.ptbadd.Name = "ptbadd";
            this.ptbadd.Size = new System.Drawing.Size(43, 38);
            this.ptbadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbadd.TabIndex = 86;
            this.ptbadd.TabStop = false;
            this.ptbadd.Click += new System.EventHandler(this.ptbadd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlMempresa
            // 
            this.pnlMempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlMempresa.Controls.Add(this.ptbleftm);
            this.pnlMempresa.Controls.Add(this.btnActualizarEmp);
            this.pnlMempresa.Controls.Add(this.cmbMtipemp);
            this.pnlMempresa.Controls.Add(this.labelEdit3);
            this.pnlMempresa.Controls.Add(this.txtMdireccion);
            this.pnlMempresa.Controls.Add(this.labelEdit4);
            this.pnlMempresa.Controls.Add(this.labelEdit5);
            this.pnlMempresa.Controls.Add(this.txtMcorreo);
            this.pnlMempresa.Controls.Add(this.txtMtelefono);
            this.pnlMempresa.Controls.Add(this.labelEdit7);
            this.pnlMempresa.Controls.Add(this.txtMempresa);
            this.pnlMempresa.Controls.Add(this.labelEdit9);
            this.pnlMempresa.Controls.Add(this.labelEdit10);
            this.pnlMempresa.Location = new System.Drawing.Point(27, 28);
            this.pnlMempresa.Name = "pnlMempresa";
            this.pnlMempresa.Size = new System.Drawing.Size(733, 420);
            this.pnlMempresa.TabIndex = 86;
            this.pnlMempresa.Visible = false;
            // 
            // ptbleftm
            // 
            this.ptbleftm.Image = global::Presentacion.Properties.Resources.left_arrow;
            this.ptbleftm.Location = new System.Drawing.Point(47, 20);
            this.ptbleftm.Name = "ptbleftm";
            this.ptbleftm.Size = new System.Drawing.Size(41, 33);
            this.ptbleftm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbleftm.TabIndex = 87;
            this.ptbleftm.TabStop = false;
            this.ptbleftm.Click += new System.EventHandler(this.ptbleftm_Click);
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(53, 269);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(131, 20);
            this.labelEdit3.TabIndex = 58;
            this.labelEdit3.Text = "Tipo de empresa:";
            // 
            // txtMdireccion
            // 
            this.txtMdireccion.BackColor = System.Drawing.Color.Transparent;
            this.txtMdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMdireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMdireccion.Image = null;
            this.txtMdireccion.Location = new System.Drawing.Point(486, 117);
            this.txtMdireccion.MaxLength = 32767;
            this.txtMdireccion.Multiline = true;
            this.txtMdireccion.Name = "txtMdireccion";
            this.txtMdireccion.ReadOnly = false;
            this.txtMdireccion.Size = new System.Drawing.Size(200, 122);
            this.txtMdireccion.TabIndex = 57;
            this.txtMdireccion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMdireccion.UseSystemPasswordChar = false;
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit4.ForeColor = System.Drawing.Color.White;
            this.labelEdit4.Location = new System.Drawing.Point(361, 149);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(79, 20);
            this.labelEdit4.TabIndex = 56;
            this.labelEdit4.Text = "Dirección:";
            // 
            // labelEdit5
            // 
            this.labelEdit5.AutoSize = true;
            this.labelEdit5.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit5.ForeColor = System.Drawing.Color.White;
            this.labelEdit5.Location = new System.Drawing.Point(43, 149);
            this.labelEdit5.Name = "labelEdit5";
            this.labelEdit5.Size = new System.Drawing.Size(61, 20);
            this.labelEdit5.TabIndex = 55;
            this.labelEdit5.Text = "Correo:";
            // 
            // txtMcorreo
            // 
            this.txtMcorreo.BackColor = System.Drawing.Color.Transparent;
            this.txtMcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMcorreo.Image = null;
            this.txtMcorreo.Location = new System.Drawing.Point(120, 117);
            this.txtMcorreo.MaxLength = 32767;
            this.txtMcorreo.Multiline = true;
            this.txtMcorreo.Name = "txtMcorreo";
            this.txtMcorreo.ReadOnly = false;
            this.txtMcorreo.Size = new System.Drawing.Size(200, 122);
            this.txtMcorreo.TabIndex = 54;
            this.txtMcorreo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMcorreo.UseSystemPasswordChar = false;
            // 
            // txtMtelefono
            // 
            this.txtMtelefono.BackColor = System.Drawing.Color.Transparent;
            this.txtMtelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMtelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMtelefono.Image = null;
            this.txtMtelefono.Location = new System.Drawing.Point(488, 60);
            this.txtMtelefono.MaxLength = 32767;
            this.txtMtelefono.Multiline = false;
            this.txtMtelefono.Name = "txtMtelefono";
            this.txtMtelefono.ReadOnly = false;
            this.txtMtelefono.Size = new System.Drawing.Size(200, 42);
            this.txtMtelefono.TabIndex = 53;
            this.txtMtelefono.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMtelefono.UseSystemPasswordChar = false;
            // 
            // labelEdit7
            // 
            this.labelEdit7.AutoSize = true;
            this.labelEdit7.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit7.ForeColor = System.Drawing.Color.White;
            this.labelEdit7.Location = new System.Drawing.Point(363, 71);
            this.labelEdit7.Name = "labelEdit7";
            this.labelEdit7.Size = new System.Drawing.Size(75, 20);
            this.labelEdit7.TabIndex = 51;
            this.labelEdit7.Text = "Télefono:";
            // 
            // txtMempresa
            // 
            this.txtMempresa.BackColor = System.Drawing.Color.Transparent;
            this.txtMempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMempresa.ForeColor = System.Drawing.Color.White;
            this.txtMempresa.Image = null;
            this.txtMempresa.Location = new System.Drawing.Point(120, 60);
            this.txtMempresa.MaxLength = 32767;
            this.txtMempresa.Multiline = false;
            this.txtMempresa.Name = "txtMempresa";
            this.txtMempresa.ReadOnly = false;
            this.txtMempresa.Size = new System.Drawing.Size(200, 42);
            this.txtMempresa.TabIndex = 48;
            this.txtMempresa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMempresa.UseSystemPasswordChar = false;
            // 
            // labelEdit9
            // 
            this.labelEdit9.AutoSize = true;
            this.labelEdit9.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit9.ForeColor = System.Drawing.Color.White;
            this.labelEdit9.Location = new System.Drawing.Point(277, 20);
            this.labelEdit9.Name = "labelEdit9";
            this.labelEdit9.Size = new System.Drawing.Size(139, 20);
            this.labelEdit9.TabIndex = 47;
            this.labelEdit9.Text = "Modificar empresa";
            // 
            // labelEdit10
            // 
            this.labelEdit10.AutoSize = true;
            this.labelEdit10.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit10.ForeColor = System.Drawing.Color.White;
            this.labelEdit10.Location = new System.Drawing.Point(45, 71);
            this.labelEdit10.Name = "labelEdit10";
            this.labelEdit10.Size = new System.Drawing.Size(77, 20);
            this.labelEdit10.TabIndex = 46;
            this.labelEdit10.Text = "Empresa:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 59;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.trash;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // btnActualizarEmp
            // 
            this.btnActualizarEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarEmp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarEmp.BorderRadius = 20;
            this.btnActualizarEmp.BorderSize = 0;
            this.btnActualizarEmp.FlatAppearance.BorderSize = 0;
            this.btnActualizarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEmp.ForeColor = System.Drawing.Color.White;
            this.btnActualizarEmp.Location = new System.Drawing.Point(269, 338);
            this.btnActualizarEmp.Name = "btnActualizarEmp";
            this.btnActualizarEmp.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarEmp.TabIndex = 74;
            this.btnActualizarEmp.Text = "Actualizar";
            this.btnActualizarEmp.TextColor = System.Drawing.Color.White;
            this.btnActualizarEmp.UseVisualStyleBackColor = false;
            this.btnActualizarEmp.Click += new System.EventHandler(this.btnActualizarEmp_Click);
            // 
            // cmbMtipemp
            // 
            this.cmbMtipemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cmbMtipemp.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbMtipemp.BorderRadius = 0;
            this.cmbMtipemp.BorderSize = 0;
            this.cmbMtipemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbMtipemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbMtipemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbMtipemp.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbMtipemp.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cmbMtipemp.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbMtipemp.Location = new System.Drawing.Point(190, 258);
            this.cmbMtipemp.MinimumSize = new System.Drawing.Size(200, 42);
            this.cmbMtipemp.Name = "cmbMtipemp";
            this.cmbMtipemp.Size = new System.Drawing.Size(200, 42);
            this.cmbMtipemp.TabIndex = 59;
            this.cmbMtipemp.Texts = "";
            this.cmbMtipemp.Click += new System.EventHandler(this.cmbMtipemp_Click_1);
            // 
            // btnGuardarE
            // 
            this.btnGuardarE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardarE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarE.BorderRadius = 20;
            this.btnGuardarE.BorderSize = 0;
            this.btnGuardarE.FlatAppearance.BorderSize = 0;
            this.btnGuardarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarE.ForeColor = System.Drawing.Color.White;
            this.btnGuardarE.Location = new System.Drawing.Point(290, 346);
            this.btnGuardarE.Name = "btnGuardarE";
            this.btnGuardarE.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarE.TabIndex = 74;
            this.btnGuardarE.Text = "Guardar";
            this.btnGuardarE.TextColor = System.Drawing.Color.White;
            this.btnGuardarE.UseVisualStyleBackColor = false;
            this.btnGuardarE.Click += new System.EventHandler(this.btnGuardarE_Click);
            // 
            // cmbtipempresa
            // 
            this.cmbtipempresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.cmbtipempresa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbtipempresa.BorderRadius = 0;
            this.cmbtipempresa.BorderSize = 0;
            this.cmbtipempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbtipempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbtipempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.cmbtipempresa.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbtipempresa.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.cmbtipempresa.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbtipempresa.Location = new System.Drawing.Point(190, 258);
            this.cmbtipempresa.MinimumSize = new System.Drawing.Size(200, 42);
            this.cmbtipempresa.Name = "cmbtipempresa";
            this.cmbtipempresa.Size = new System.Drawing.Size(200, 42);
            this.cmbtipempresa.TabIndex = 59;
            this.cmbtipempresa.Texts = "";
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 538);
            this.Controls.Add(this.pnlMempresa);
            this.Controls.Add(this.pnlListEmp);
            this.Controls.Add(this.pnlRegEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmpresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).EndInit();
            this.pnlRegEmp.ResumeLayout(false);
            this.pnlRegEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbleft)).EndInit();
            this.pnlListEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlMempresa.ResumeLayout(false);
            this.pnlMempresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbleftm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Button btnBuscaremp;
        private ReaLTaiizor.Controls.TextBoxEdit txtBemp;
        private System.Windows.Forms.DataGridView dtgEmpresa;
        private System.Windows.Forms.Panel pnlRegEmp;
        private System.Windows.Forms.Panel pnlListEmp;
        private ReaLTaiizor.Controls.TextBoxEdit txtTelefono;
        private ReaLTaiizor.Controls.LabelEdit labelEdit8;
        private ReaLTaiizor.Controls.TextBoxEdit txtEmpresa;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.TextBoxEdit txtDireccion;
        private ReaLTaiizor.Controls.LabelEdit labelEdit11;
        private ReaLTaiizor.Controls.LabelEdit labelEdit6;
        private ReaLTaiizor.Controls.TextBoxEdit txtCorreo;
        private btnpersonalizados.PersonComboBox cmbtipempresa;
        private ReaLTaiizor.Controls.LabelEdit labelEdit12;
        private btnpersonalizados.Botonper btnGuardarE;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox ptbadd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlMempresa;
        private btnpersonalizados.Botonper btnActualizarEmp;
        private btnpersonalizados.PersonComboBox cmbMtipemp;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.TextBoxEdit txtMdireccion;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
        private ReaLTaiizor.Controls.TextBoxEdit txtMcorreo;
        private ReaLTaiizor.Controls.TextBoxEdit txtMtelefono;
        private ReaLTaiizor.Controls.LabelEdit labelEdit7;
        private ReaLTaiizor.Controls.TextBoxEdit txtMempresa;
        private ReaLTaiizor.Controls.LabelEdit labelEdit9;
        private ReaLTaiizor.Controls.LabelEdit labelEdit10;
        private System.Windows.Forms.PictureBox ptbleft;
        private System.Windows.Forms.PictureBox ptbleftm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}