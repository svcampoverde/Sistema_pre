namespace Presentacion.ModuloProvincia
{
    partial class FrmProvincia
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtgProvincia = new System.Windows.Forms.DataGridView();
            this.pnlRegistropro = new System.Windows.Forms.Panel();
            this.btnRegistrarp = new Presentacion.btnpersonalizados.Botonper();
            this.txtProvincia = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.txtBprovincia = new ReaLTaiizor.Controls.TextBoxEdit();
            this.btnBuscar = new ReaLTaiizor.Controls.Button();
            this.pnlModificarpro = new System.Windows.Forms.Panel();
            this.btnActualizar = new Presentacion.btnpersonalizados.Botonper();
            this.txtMprovincia = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.idprovincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProvincia)).BeginInit();
            this.pnlRegistropro.SuspendLayout();
            this.pnlModificarpro.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtgProvincia
            // 
            this.dtgProvincia.AllowUserToAddRows = false;
            this.dtgProvincia.AllowUserToDeleteRows = false;
            this.dtgProvincia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgProvincia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProvincia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgProvincia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgProvincia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProvincia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProvincia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprovincia,
            this.provincia,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProvincia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProvincia.EnableHeadersVisualStyles = false;
            this.dtgProvincia.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgProvincia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgProvincia.Location = new System.Drawing.Point(41, 94);
            this.dtgProvincia.Name = "dtgProvincia";
            this.dtgProvincia.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProvincia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProvincia.RowHeadersVisible = false;
            this.dtgProvincia.RowHeadersWidth = 40;
            this.dtgProvincia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgProvincia.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProvincia.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgProvincia.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgProvincia.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgProvincia.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgProvincia.Size = new System.Drawing.Size(257, 211);
            this.dtgProvincia.TabIndex = 65;
            this.dtgProvincia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProvincia_CellClick);
            // 
            // pnlRegistropro
            // 
            this.pnlRegistropro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegistropro.Controls.Add(this.btnRegistrarp);
            this.pnlRegistropro.Controls.Add(this.txtProvincia);
            this.pnlRegistropro.Controls.Add(this.labelEdit1);
            this.pnlRegistropro.Controls.Add(this.labelEdit2);
            this.pnlRegistropro.Location = new System.Drawing.Point(361, 94);
            this.pnlRegistropro.Name = "pnlRegistropro";
            this.pnlRegistropro.Size = new System.Drawing.Size(467, 232);
            this.pnlRegistropro.TabIndex = 66;
            // 
            // btnRegistrarp
            // 
            this.btnRegistrarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarp.BorderRadius = 20;
            this.btnRegistrarp.BorderSize = 0;
            this.btnRegistrarp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarp.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarp.Location = new System.Drawing.Point(153, 156);
            this.btnRegistrarp.Name = "btnRegistrarp";
            this.btnRegistrarp.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarp.TabIndex = 26;
            this.btnRegistrarp.Text = "Guardar";
            this.btnRegistrarp.TextColor = System.Drawing.Color.White;
            this.btnRegistrarp.UseVisualStyleBackColor = false;
            this.btnRegistrarp.Click += new System.EventHandler(this.btnRegistrarp_Click);
            // 
            // txtProvincia
            // 
            this.txtProvincia.BackColor = System.Drawing.Color.Transparent;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtProvincia.Image = null;
            this.txtProvincia.Location = new System.Drawing.Point(165, 71);
            this.txtProvincia.MaxLength = 32767;
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = false;
            this.txtProvincia.Size = new System.Drawing.Size(261, 42);
            this.txtProvincia.TabIndex = 71;
            this.txtProvincia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProvincia.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(17, 83);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(142, 20);
            this.labelEdit1.TabIndex = 70;
            this.labelEdit1.Text = "Nombre de ciudad:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(161, 17);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(128, 20);
            this.labelEdit2.TabIndex = 69;
            this.labelEdit2.Text = "Registrar Ciudad";
            // 
            // txtBprovincia
            // 
            this.txtBprovincia.BackColor = System.Drawing.Color.Transparent;
            this.txtBprovincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBprovincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBprovincia.Image = null;
            this.txtBprovincia.Location = new System.Drawing.Point(41, 40);
            this.txtBprovincia.MaxLength = 32767;
            this.txtBprovincia.Multiline = false;
            this.txtBprovincia.Name = "txtBprovincia";
            this.txtBprovincia.ReadOnly = false;
            this.txtBprovincia.Size = new System.Drawing.Size(206, 42);
            this.txtBprovincia.TabIndex = 72;
            this.txtBprovincia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBprovincia.UseSystemPasswordChar = false;
            this.txtBprovincia.TextChanged += new System.EventHandler(this.txtBprovincia_TextChanged);
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
            this.btnBuscar.Location = new System.Drawing.Point(242, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Size = new System.Drawing.Size(71, 40);
            this.btnBuscar.TabIndex = 73;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlModificarpro
            // 
            this.pnlModificarpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlModificarpro.Controls.Add(this.btnActualizar);
            this.pnlModificarpro.Controls.Add(this.txtMprovincia);
            this.pnlModificarpro.Controls.Add(this.labelEdit3);
            this.pnlModificarpro.Controls.Add(this.labelEdit4);
            this.pnlModificarpro.Location = new System.Drawing.Point(361, 94);
            this.pnlModificarpro.Name = "pnlModificarpro";
            this.pnlModificarpro.Size = new System.Drawing.Size(467, 232);
            this.pnlModificarpro.TabIndex = 74;
            this.pnlModificarpro.Visible = false;
            // 
            // FrmModificarUsuario
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizar.BorderRadius = 20;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(153, 156);
            this.btnActualizar.Name = "FrmModificarUsuario";
            this.btnActualizar.Size = new System.Drawing.Size(150, 40);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtMprovincia
            // 
            this.txtMprovincia.BackColor = System.Drawing.Color.Transparent;
            this.txtMprovincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMprovincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMprovincia.Image = null;
            this.txtMprovincia.Location = new System.Drawing.Point(165, 71);
            this.txtMprovincia.MaxLength = 32767;
            this.txtMprovincia.Multiline = false;
            this.txtMprovincia.Name = "txtMprovincia";
            this.txtMprovincia.ReadOnly = false;
            this.txtMprovincia.Size = new System.Drawing.Size(261, 42);
            this.txtMprovincia.TabIndex = 71;
            this.txtMprovincia.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMprovincia.UseSystemPasswordChar = false;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(17, 83);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(142, 20);
            this.labelEdit3.TabIndex = 70;
            this.labelEdit3.Text = "Nombre de ciudad:";
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit4.ForeColor = System.Drawing.Color.White;
            this.labelEdit4.Location = new System.Drawing.Point(161, 17);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(127, 20);
            this.labelEdit4.TabIndex = 69;
            this.labelEdit4.Text = "Modificar Ciudad";
            // 
            // idprovincia
            // 
            this.idprovincia.HeaderText = "Id";
            this.idprovincia.Name = "idprovincia";
            this.idprovincia.ReadOnly = true;
            this.idprovincia.Visible = false;
            this.idprovincia.Width = 31;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            this.provincia.Width = 99;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "Editar";
            this.btnEditar.Image = global::Presentacion.Properties.Resources.draw;
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
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 364);
            this.ControlBox = false;
            this.Controls.Add(this.pnlModificarpro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBprovincia);
            this.Controls.Add(this.pnlRegistropro);
            this.Controls.Add(this.dtgProvincia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FrmProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMProvincia";
            this.Load += new System.EventHandler(this.FrmProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProvincia)).EndInit();
            this.pnlRegistropro.ResumeLayout(false);
            this.pnlRegistropro.PerformLayout();
            this.pnlModificarpro.ResumeLayout(false);
            this.pnlModificarpro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private btnpersonalizados.Botonper btnRegistrarp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgProvincia;
        private System.Windows.Forms.Panel pnlRegistropro;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.TextBoxEdit txtProvincia;
        private ReaLTaiizor.Controls.TextBoxEdit txtBprovincia;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private System.Windows.Forms.Panel pnlModificarpro;
        private btnpersonalizados.Botonper btnActualizar;
        private ReaLTaiizor.Controls.TextBoxEdit txtMprovincia;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprovincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}