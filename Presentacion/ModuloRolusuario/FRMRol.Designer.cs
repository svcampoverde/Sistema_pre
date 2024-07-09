namespace Presentacion.ModuloRolusuario
{
    partial class FrmRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRol));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlRegistrorol = new System.Windows.Forms.Panel();
            this.txtRol = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlModificarol = new System.Windows.Forms.Panel();
            this.txtErol = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.dtgRol = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new ReaLTaiizor.Controls.Button();
            this.txtBrol = new ReaLTaiizor.Controls.TextBoxEdit();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.idroles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.brnActualizar = new Presentacion.btnpersonalizados.Botonper();
            this.btnRegistrarol = new Presentacion.btnpersonalizados.Botonper();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlRegistrorol.SuspendLayout();
            this.pnlModificarol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRol)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlRegistrorol
            // 
            this.pnlRegistrorol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegistrorol.Controls.Add(this.btnRegistrarol);
            this.pnlRegistrorol.Controls.Add(this.txtRol);
            this.pnlRegistrorol.Controls.Add(this.labelEdit1);
            this.pnlRegistrorol.Controls.Add(this.labelEdit2);
            this.pnlRegistrorol.Location = new System.Drawing.Point(361, 44);
            this.pnlRegistrorol.Name = "pnlRegistrorol";
            this.pnlRegistrorol.Size = new System.Drawing.Size(447, 232);
            this.pnlRegistrorol.TabIndex = 67;
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.Color.Transparent;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtRol.Image = null;
            this.txtRol.Location = new System.Drawing.Point(135, 73);
            this.txtRol.MaxLength = 32767;
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = false;
            this.txtRol.Size = new System.Drawing.Size(261, 42);
            this.txtRol.TabIndex = 71;
            this.txtRol.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(17, 83);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(112, 20);
            this.labelEdit1.TabIndex = 70;
            this.labelEdit1.Text = "Nombre de rol:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(129, 28);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(220, 20);
            this.labelEdit2.TabIndex = 69;
            this.labelEdit2.Text = "Registrar nuevo rol de usuario";
            // 
            // pnlModificarol
            // 
            this.pnlModificarol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlModificarol.Controls.Add(this.brnActualizar);
            this.pnlModificarol.Controls.Add(this.txtErol);
            this.pnlModificarol.Controls.Add(this.labelEdit3);
            this.pnlModificarol.Controls.Add(this.labelEdit4);
            this.pnlModificarol.Location = new System.Drawing.Point(361, 44);
            this.pnlModificarol.Name = "pnlModificarol";
            this.pnlModificarol.Size = new System.Drawing.Size(447, 232);
            this.pnlModificarol.TabIndex = 68;
            this.pnlModificarol.Visible = false;
            // 
            // txtErol
            // 
            this.txtErol.BackColor = System.Drawing.Color.Transparent;
            this.txtErol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtErol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtErol.Image = null;
            this.txtErol.Location = new System.Drawing.Point(135, 73);
            this.txtErol.MaxLength = 32767;
            this.txtErol.Multiline = false;
            this.txtErol.Name = "txtErol";
            this.txtErol.ReadOnly = false;
            this.txtErol.Size = new System.Drawing.Size(261, 42);
            this.txtErol.TabIndex = 71;
            this.txtErol.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtErol.UseSystemPasswordChar = false;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(17, 83);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(112, 20);
            this.labelEdit3.TabIndex = 70;
            this.labelEdit3.Text = "Nombre de rol:";
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
            // dtgRol
            // 
            this.dtgRol.AllowUserToAddRows = false;
            this.dtgRol.AllowUserToDeleteRows = false;
            this.dtgRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgRol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgRol.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idroles,
            this.rol,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRol.EnableHeadersVisualStyles = false;
            this.dtgRol.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgRol.Location = new System.Drawing.Point(41, 101);
            this.dtgRol.Name = "dtgRol";
            this.dtgRol.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRol.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRol.RowHeadersVisible = false;
            this.dtgRol.RowHeadersWidth = 40;
            this.dtgRol.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgRol.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRol.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgRol.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgRol.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgRol.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgRol.Size = new System.Drawing.Size(272, 192);
            this.dtgRol.TabIndex = 69;
            this.dtgRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRol_CellClick);
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
            this.btnBuscar.Location = new System.Drawing.Point(242, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Size = new System.Drawing.Size(71, 42);
            this.btnBuscar.TabIndex = 75;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBrol
            // 
            this.txtBrol.BackColor = System.Drawing.Color.Transparent;
            this.txtBrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBrol.Image = null;
            this.txtBrol.Location = new System.Drawing.Point(41, 44);
            this.txtBrol.MaxLength = 32767;
            this.txtBrol.Multiline = false;
            this.txtBrol.Name = "txtBrol";
            this.txtBrol.ReadOnly = false;
            this.txtBrol.Size = new System.Drawing.Size(206, 42);
            this.txtBrol.TabIndex = 74;
            this.txtBrol.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBrol.UseSystemPasswordChar = false;
            this.txtBrol.TextChanged += new System.EventHandler(this.txtBrol_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 59;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.trash;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // idroles
            // 
            this.idroles.HeaderText = "Id";
            this.idroles.Name = "idroles";
            this.idroles.ReadOnly = true;
            this.idroles.Visible = false;
            this.idroles.Width = 31;
            // 
            // rol
            // 
            this.rol.HeaderText = "Tipo de usuario";
            this.rol.Name = "rol";
            this.rol.ReadOnly = true;
            this.rol.Width = 144;
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
            // brnActualizar
            // 
            this.brnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.brnActualizar.BorderRadius = 20;
            this.brnActualizar.BorderSize = 0;
            this.brnActualizar.FlatAppearance.BorderSize = 0;
            this.brnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnActualizar.ForeColor = System.Drawing.Color.White;
            this.brnActualizar.Location = new System.Drawing.Point(153, 156);
            this.brnActualizar.Name = "brnActualizar";
            this.brnActualizar.Size = new System.Drawing.Size(150, 40);
            this.brnActualizar.TabIndex = 26;
            this.brnActualizar.Text = "Actualizar";
            this.brnActualizar.TextColor = System.Drawing.Color.White;
            this.brnActualizar.UseVisualStyleBackColor = false;
            this.brnActualizar.Click += new System.EventHandler(this.brnActualizar_Click);
            // 
            // btnRegistrarol
            // 
            this.btnRegistrarol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarol.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarol.BorderRadius = 20;
            this.btnRegistrarol.BorderSize = 0;
            this.btnRegistrarol.FlatAppearance.BorderSize = 0;
            this.btnRegistrarol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarol.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarol.Location = new System.Drawing.Point(153, 156);
            this.btnRegistrarol.Name = "btnRegistrarol";
            this.btnRegistrarol.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarol.TabIndex = 26;
            this.btnRegistrarol.Text = "Guardar";
            this.btnRegistrarol.TextColor = System.Drawing.Color.White;
            this.btnRegistrarol.UseVisualStyleBackColor = false;
            this.btnRegistrarol.Click += new System.EventHandler(this.btnRegistrarol_Click);
            // 
            // FRMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBrol);
            this.Controls.Add(this.dtgRol);
            this.Controls.Add(this.pnlModificarol);
            this.Controls.Add(this.pnlRegistrorol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FRMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRMRoles";
            this.Load += new System.EventHandler(this.FRMRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlRegistrorol.ResumeLayout(false);
            this.pnlRegistrorol.PerformLayout();
            this.pnlModificarol.ResumeLayout(false);
            this.pnlModificarol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlRegistrorol;
        private btnpersonalizados.Botonper btnRegistrarol;
        private ReaLTaiizor.Controls.TextBoxEdit txtRol;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.Panel pnlModificarol;
        private btnpersonalizados.Botonper brnActualizar;
        private ReaLTaiizor.Controls.TextBoxEdit txtErol;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.DataGridView dtgRol;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.TextBoxEdit txtBrol;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idroles;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}