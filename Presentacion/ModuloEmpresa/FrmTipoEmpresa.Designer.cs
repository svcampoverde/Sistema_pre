﻿namespace Presentacion.ModuloEmpresa
{
    partial class FrmTipoEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipoEmpresa));
            this.btnBuscartemp = new ReaLTaiizor.Controls.Button();
            this.txtBtipemp = new ReaLTaiizor.Controls.TextBoxEdit();
            this.dtgTipEmpresa = new System.Windows.Forms.DataGridView();
            this.pnlRegistrotip = new System.Windows.Forms.Panel();
            this.brnGuardarTE = new Presentacion.btnpersonalizados.Botonper();
            this.txtTipempresa = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlModificatipo = new System.Windows.Forms.Panel();
            this.btnActualizarTE = new Presentacion.btnpersonalizados.Botonper();
            this.txtMtipemp = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipEmpresa)).BeginInit();
            this.pnlRegistrotip.SuspendLayout();
            this.pnlModificatipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscartemp
            // 
            this.btnBuscartemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscartemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscartemp.EnteredColor = System.Drawing.Color.Transparent;
            this.btnBuscartemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscartemp.Image = null;
            this.btnBuscartemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscartemp.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscartemp.Location = new System.Drawing.Point(235, 31);
            this.btnBuscartemp.Name = "btnBuscartemp";
            this.btnBuscartemp.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscartemp.Size = new System.Drawing.Size(71, 42);
            this.btnBuscartemp.TabIndex = 80;
            this.btnBuscartemp.Text = "Buscar";
            this.btnBuscartemp.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscartemp.Click += new System.EventHandler(this.btnBuscartemp_Click);
            // 
            // txtBtipemp
            // 
            this.txtBtipemp.BackColor = System.Drawing.Color.Transparent;
            this.txtBtipemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBtipemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBtipemp.Image = null;
            this.txtBtipemp.Location = new System.Drawing.Point(34, 31);
            this.txtBtipemp.MaxLength = 32767;
            this.txtBtipemp.Multiline = false;
            this.txtBtipemp.Name = "txtBtipemp";
            this.txtBtipemp.ReadOnly = false;
            this.txtBtipemp.Size = new System.Drawing.Size(206, 42);
            this.txtBtipemp.TabIndex = 79;
            this.txtBtipemp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBtipemp.UseSystemPasswordChar = false;
            this.txtBtipemp.TextChanged += new System.EventHandler(this.txtBtipemp_TextChanged);
            // 
            // dtgTipEmpresa
            // 
            this.dtgTipEmpresa.AllowUserToAddRows = false;
            this.dtgTipEmpresa.AllowUserToDeleteRows = false;
            this.dtgTipEmpresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgTipEmpresa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgTipEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgTipEmpresa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgTipEmpresa.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgTipEmpresa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipEmpresa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgTipEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTipEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipo,
            this.tipemp,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgTipEmpresa.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgTipEmpresa.EnableHeadersVisualStyles = false;
            this.dtgTipEmpresa.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgTipEmpresa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgTipEmpresa.Location = new System.Drawing.Point(34, 92);
            this.dtgTipEmpresa.Name = "dtgTipEmpresa";
            this.dtgTipEmpresa.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgTipEmpresa.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgTipEmpresa.RowHeadersVisible = false;
            this.dtgTipEmpresa.RowHeadersWidth = 40;
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgTipEmpresa.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgTipEmpresa.Size = new System.Drawing.Size(272, 192);
            this.dtgTipEmpresa.TabIndex = 78;
            this.dtgTipEmpresa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTipEmpresa_CellClick);
            // 
            // pnlRegistrotip
            // 
            this.pnlRegistrotip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegistrotip.Controls.Add(this.brnGuardarTE);
            this.pnlRegistrotip.Controls.Add(this.txtTipempresa);
            this.pnlRegistrotip.Controls.Add(this.labelEdit1);
            this.pnlRegistrotip.Controls.Add(this.labelEdit2);
            this.pnlRegistrotip.Location = new System.Drawing.Point(341, 31);
            this.pnlRegistrotip.Name = "pnlRegistrotip";
            this.pnlRegistrotip.Size = new System.Drawing.Size(432, 232);
            this.pnlRegistrotip.TabIndex = 81;
            // 
            // brnGuardarTE
            // 
            this.brnGuardarTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnGuardarTE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.brnGuardarTE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.brnGuardarTE.BorderRadius = 20;
            this.brnGuardarTE.BorderSize = 0;
            this.brnGuardarTE.FlatAppearance.BorderSize = 0;
            this.brnGuardarTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnGuardarTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGuardarTE.ForeColor = System.Drawing.Color.White;
            this.brnGuardarTE.Location = new System.Drawing.Point(144, 154);
            this.brnGuardarTE.Name = "brnGuardarTE";
            this.brnGuardarTE.Size = new System.Drawing.Size(150, 40);
            this.brnGuardarTE.TabIndex = 72;
            this.brnGuardarTE.Text = "Guardar";
            this.brnGuardarTE.TextColor = System.Drawing.Color.White;
            this.brnGuardarTE.UseVisualStyleBackColor = false;
            this.brnGuardarTE.Click += new System.EventHandler(this.brnGuardarTE_Click);
            // 
            // txtTipempresa
            // 
            this.txtTipempresa.BackColor = System.Drawing.Color.Transparent;
            this.txtTipempresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTipempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtTipempresa.Image = null;
            this.txtTipempresa.Location = new System.Drawing.Point(144, 71);
            this.txtTipempresa.MaxLength = 32767;
            this.txtTipempresa.Multiline = false;
            this.txtTipempresa.Name = "txtTipempresa";
            this.txtTipempresa.ReadOnly = false;
            this.txtTipempresa.Size = new System.Drawing.Size(261, 42);
            this.txtTipempresa.TabIndex = 71;
            this.txtTipempresa.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTipempresa.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(17, 83);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(131, 20);
            this.labelEdit1.TabIndex = 70;
            this.labelEdit1.Text = "Tipo de empresa:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(108, 22);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(239, 20);
            this.labelEdit2.TabIndex = 69;
            this.labelEdit2.Text = "Registrar nuevo tipo de empresa";
            // 
            // pnlModificatipo
            // 
            this.pnlModificatipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlModificatipo.Controls.Add(this.btnActualizarTE);
            this.pnlModificatipo.Controls.Add(this.txtMtipemp);
            this.pnlModificatipo.Controls.Add(this.labelEdit3);
            this.pnlModificatipo.Controls.Add(this.labelEdit4);
            this.pnlModificatipo.Location = new System.Drawing.Point(341, 31);
            this.pnlModificatipo.Name = "pnlModificatipo";
            this.pnlModificatipo.Size = new System.Drawing.Size(432, 232);
            this.pnlModificatipo.TabIndex = 82;
            this.pnlModificatipo.Visible = false;
            // 
            // btnActualizarTE
            // 
            this.btnActualizarTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarTE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnActualizarTE.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnActualizarTE.BorderRadius = 20;
            this.btnActualizarTE.BorderSize = 0;
            this.btnActualizarTE.FlatAppearance.BorderSize = 0;
            this.btnActualizarTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTE.ForeColor = System.Drawing.Color.White;
            this.btnActualizarTE.Location = new System.Drawing.Point(144, 160);
            this.btnActualizarTE.Name = "btnActualizarTE";
            this.btnActualizarTE.Size = new System.Drawing.Size(150, 40);
            this.btnActualizarTE.TabIndex = 73;
            this.btnActualizarTE.Text = "Actualizar";
            this.btnActualizarTE.TextColor = System.Drawing.Color.White;
            this.btnActualizarTE.UseVisualStyleBackColor = false;
            this.btnActualizarTE.Click += new System.EventHandler(this.btnActualizarTE_Click);
            // 
            // txtMtipemp
            // 
            this.txtMtipemp.BackColor = System.Drawing.Color.Transparent;
            this.txtMtipemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMtipemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMtipemp.Image = null;
            this.txtMtipemp.Location = new System.Drawing.Point(144, 72);
            this.txtMtipemp.MaxLength = 32767;
            this.txtMtipemp.Multiline = false;
            this.txtMtipemp.Name = "txtMtipemp";
            this.txtMtipemp.ReadOnly = false;
            this.txtMtipemp.Size = new System.Drawing.Size(261, 42);
            this.txtMtipemp.TabIndex = 71;
            this.txtMtipemp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMtipemp.UseSystemPasswordChar = false;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(17, 83);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(131, 20);
            this.labelEdit3.TabIndex = 70;
            this.labelEdit3.Text = "Tipo de empresa:";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idtipo
            // 
            this.idtipo.HeaderText = "Id";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Width = 50;
            // 
            // tipemp
            // 
            this.tipemp.HeaderText = "Tipo de Empresa";
            this.tipemp.Name = "tipemp";
            this.tipemp.ReadOnly = true;
            this.tipemp.Width = 143;
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
            // FrmTipoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 313);
            this.Controls.Add(this.pnlModificatipo);
            this.Controls.Add(this.pnlRegistrotip);
            this.Controls.Add(this.btnBuscartemp);
            this.Controls.Add(this.txtBtipemp);
            this.Controls.Add(this.dtgTipEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipoEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoEmpresa";
            this.Load += new System.EventHandler(this.FrmTipoEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTipEmpresa)).EndInit();
            this.pnlRegistrotip.ResumeLayout(false);
            this.pnlRegistrotip.PerformLayout();
            this.pnlModificatipo.ResumeLayout(false);
            this.pnlModificatipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Button btnBuscartemp;
        private ReaLTaiizor.Controls.TextBoxEdit txtBtipemp;
        private System.Windows.Forms.DataGridView dtgTipEmpresa;
        private System.Windows.Forms.Panel pnlRegistrotip;
        private btnpersonalizados.Botonper brnGuardarTE;
        private ReaLTaiizor.Controls.TextBoxEdit txtTipempresa;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.Panel pnlModificatipo;
        private btnpersonalizados.Botonper btnActualizarTE;
        private ReaLTaiizor.Controls.TextBoxEdit txtMtipemp;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipemp;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}