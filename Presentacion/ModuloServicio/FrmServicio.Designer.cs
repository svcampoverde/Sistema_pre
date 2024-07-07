namespace Presentacion.ModuloServicio
{
    partial class FrmServicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgServicio = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new ReaLTaiizor.Controls.Button();
            this.txtBservicio = new ReaLTaiizor.Controls.TextBoxEdit();
            this.pnlRegistroservicio = new System.Windows.Forms.Panel();
            this.txtServicio = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlModificaservicio = new System.Windows.Forms.Panel();
            this.txtMservicio = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.idservicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtgService = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.brnGuardarS = new Presentacion.btnpersonalizados.Botonper();
            this.btnActualizarS = new Presentacion.btnpersonalizados.Botonper();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicio)).BeginInit();
            this.pnlRegistroservicio.SuspendLayout();
            this.pnlModificaservicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgServicio
            // 
            this.dtgServicio.AllowUserToAddRows = false;
            this.dtgServicio.AllowUserToDeleteRows = false;
            this.dtgServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgServicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgServicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgServicio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idservicio,
            this.servicio,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgServicio.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgServicio.EnableHeadersVisualStyles = false;
            this.dtgServicio.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgServicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgServicio.Location = new System.Drawing.Point(24, 99);
            this.dtgServicio.Name = "dtgServicio";
            this.dtgServicio.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicio.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgServicio.RowHeadersVisible = false;
            this.dtgServicio.RowHeadersWidth = 40;
            this.dtgServicio.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgServicio.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgServicio.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgServicio.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgServicio.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgServicio.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgServicio.Size = new System.Drawing.Size(272, 192);
            this.dtgServicio.TabIndex = 70;
            this.dtgServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgServico_CellClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.EnteredColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Location = new System.Drawing.Point(225, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Size = new System.Drawing.Size(71, 42);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBservicio
            // 
            this.txtBservicio.BackColor = System.Drawing.Color.Transparent;
            this.txtBservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBservicio.Image = null;
            this.txtBservicio.Location = new System.Drawing.Point(24, 38);
            this.txtBservicio.MaxLength = 32767;
            this.txtBservicio.Multiline = false;
            this.txtBservicio.Name = "txtBservicio";
            this.txtBservicio.ReadOnly = false;
            this.txtBservicio.Size = new System.Drawing.Size(206, 42);
            this.txtBservicio.TabIndex = 76;
            this.txtBservicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBservicio.UseSystemPasswordChar = false;
            this.txtBservicio.TextChanged += new System.EventHandler(this.txtBservicio_TextChanged);
            // 
            // pnlRegistroservicio
            // 
            this.pnlRegistroservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegistroservicio.Controls.Add(this.brnGuardarS);
            this.pnlRegistroservicio.Controls.Add(this.txtServicio);
            this.pnlRegistroservicio.Controls.Add(this.labelEdit1);
            this.pnlRegistroservicio.Controls.Add(this.labelEdit2);
            this.pnlRegistroservicio.Location = new System.Drawing.Point(315, 38);
            this.pnlRegistroservicio.Name = "pnlRegistroservicio";
            this.pnlRegistroservicio.Size = new System.Drawing.Size(456, 232);
            this.pnlRegistroservicio.TabIndex = 78;
            // 
            // txtServicio
            // 
            this.txtServicio.BackColor = System.Drawing.Color.Transparent;
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtServicio.Image = null;
            this.txtServicio.Location = new System.Drawing.Point(170, 73);
            this.txtServicio.MaxLength = 32767;
            this.txtServicio.Multiline = false;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.ReadOnly = false;
            this.txtServicio.Size = new System.Drawing.Size(261, 42);
            this.txtServicio.TabIndex = 71;
            this.txtServicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServicio.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(17, 83);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(147, 20);
            this.labelEdit1.TabIndex = 70;
            this.labelEdit1.Text = "Nombre de servicio:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(129, 28);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(177, 20);
            this.labelEdit2.TabIndex = 69;
            this.labelEdit2.Text = "Registrar nuevo servicio";
            // 
            // pnlModificaservicio
            // 
            this.pnlModificaservicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlModificaservicio.Controls.Add(this.btnActualizarS);
            this.pnlModificaservicio.Controls.Add(this.txtMservicio);
            this.pnlModificaservicio.Controls.Add(this.labelEdit3);
            this.pnlModificaservicio.Controls.Add(this.labelEdit4);
            this.pnlModificaservicio.Location = new System.Drawing.Point(315, 38);
            this.pnlModificaservicio.Name = "pnlModificaservicio";
            this.pnlModificaservicio.Size = new System.Drawing.Size(457, 232);
            this.pnlModificaservicio.TabIndex = 79;
            this.pnlModificaservicio.Visible = false;
            // 
            // txtMservicio
            // 
            this.txtMservicio.BackColor = System.Drawing.Color.Transparent;
            this.txtMservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMservicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMservicio.Image = null;
            this.txtMservicio.Location = new System.Drawing.Point(165, 74);
            this.txtMservicio.MaxLength = 32767;
            this.txtMservicio.Multiline = false;
            this.txtMservicio.Name = "txtMservicio";
            this.txtMservicio.ReadOnly = false;
            this.txtMservicio.Size = new System.Drawing.Size(261, 42);
            this.txtMservicio.TabIndex = 71;
            this.txtMservicio.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMservicio.UseSystemPasswordChar = false;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(17, 83);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(147, 20);
            this.labelEdit3.TabIndex = 70;
            this.labelEdit3.Text = "Nombre de servicio:";
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit4.ForeColor = System.Drawing.Color.White;
            this.labelEdit4.Location = new System.Drawing.Point(166, 32);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(159, 20);
            this.labelEdit4.TabIndex = 69;
            this.labelEdit4.Text = "Modificar información";
            // 
            // idservicio
            // 
            this.idservicio.HeaderText = "Id";
            this.idservicio.Name = "idservicio";
            this.idservicio.ReadOnly = true;
            this.idservicio.Width = 50;
            // 
            // servicio
            // 
            this.servicio.HeaderText = "Servicio";
            this.servicio.Name = "servicio";
            this.servicio.ReadOnly = true;
            this.servicio.Width = 91;
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
            // dtgService
            // 
            this.dtgService.AllowUserToAddRows = false;
            this.dtgService.AllowUserToDeleteRows = false;
            this.dtgService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgService.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgService.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgService.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgService.DefaultCellStyle = dataGridViewCellStyle17;
            this.dtgService.EnableHeadersVisualStyles = false;
            this.dtgService.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgService.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgService.Location = new System.Drawing.Point(24, 99);
            this.dtgService.Name = "dtgService";
            this.dtgService.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgService.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dtgService.RowHeadersVisible = false;
            this.dtgService.RowHeadersWidth = 40;
            this.dtgService.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgService.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgService.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgService.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgService.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgService.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgService.Size = new System.Drawing.Size(272, 192);
            this.dtgService.TabIndex = 70;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // brnGuardarS
            // 
            this.brnGuardarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnGuardarS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnGuardarS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.brnGuardarS.BorderRadius = 20;
            this.brnGuardarS.BorderSize = 0;
            this.brnGuardarS.FlatAppearance.BorderSize = 0;
            this.brnGuardarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnGuardarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGuardarS.ForeColor = System.Drawing.Color.White;
            this.brnGuardarS.Location = new System.Drawing.Point(144, 154);
            this.brnGuardarS.Name = "brnGuardarS";
            this.brnGuardarS.Size = new System.Drawing.Size(150, 40);
            this.brnGuardarS.TabIndex = 72;
            this.brnGuardarS.Text = "Guardar";
            this.brnGuardarS.TextColor = System.Drawing.Color.White;
            this.brnGuardarS.UseVisualStyleBackColor = false;
            this.brnGuardarS.Click += new System.EventHandler(this.brnGuardarS_Click);
            // 
            // btnActualizarS
            // 
            this.btnActualizarS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarS.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarS.BorderRadius = 20;
            this.btnActualizarS.BorderSize = 0;
            this.btnActualizarS.FlatAppearance.BorderSize = 0;
            this.btnActualizarS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarS.ForeColor = System.Drawing.Color.White;
            this.btnActualizarS.Location = new System.Drawing.Point(144, 160);
            this.btnActualizarS.Name = "btnActualizarS";
            this.btnActualizarS.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarS.TabIndex = 73;
            this.btnActualizarS.Text = "Actualizar";
            this.btnActualizarS.TextColor = System.Drawing.Color.White;
            this.btnActualizarS.UseVisualStyleBackColor = false;
            this.btnActualizarS.Click += new System.EventHandler(this.btnActualizarS_Click);
            // 
            // FrmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 317);
            this.Controls.Add(this.pnlModificaservicio);
            this.Controls.Add(this.pnlRegistroservicio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBservicio);
            this.Controls.Add(this.dtgServicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServicio";
            this.Load += new System.EventHandler(this.FrmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicio)).EndInit();
            this.pnlRegistroservicio.ResumeLayout(false);
            this.pnlRegistroservicio.PerformLayout();
            this.pnlModificaservicio.ResumeLayout(false);
            this.pnlModificaservicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgServicio;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.TextBoxEdit txtBservicio;
        private System.Windows.Forms.Panel pnlRegistroservicio;
        private ReaLTaiizor.Controls.TextBoxEdit txtServicio;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.Panel pnlModificaservicio;
        private ReaLTaiizor.Controls.TextBoxEdit txtMservicio;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idservicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicio;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.DataGridView dtgService;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private btnpersonalizados.Botonper brnGuardarS;
        private btnpersonalizados.Botonper btnActualizarS;
    }
}