namespace Presentacion.ModuloProducto
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new ReaLTaiizor.Controls.Button();
            this.txtBCategoria = new ReaLTaiizor.Controls.TextBoxEdit();
            this.pnlRegistrorol = new System.Windows.Forms.Panel();
            this.txtCategoria = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlModificarol = new System.Windows.Forms.Panel();
            this.txtMcategoria = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btncActualizar = new Presentacion.btnpersonalizados.Botonper();
            this.btnRegistracat = new Presentacion.btnpersonalizados.Botonper();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            this.pnlRegistrorol.SuspendLayout();
            this.pnlModificarol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCategoria
            // 
            this.dtgCategoria.AllowUserToAddRows = false;
            this.dtgCategoria.AllowUserToDeleteRows = false;
            this.dtgCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgCategoria.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoria,
            this.categoria,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCategoria.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCategoria.EnableHeadersVisualStyles = false;
            this.dtgCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgCategoria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgCategoria.Location = new System.Drawing.Point(29, 94);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCategoria.RowHeadersVisible = false;
            this.dtgCategoria.RowHeadersWidth = 40;
            this.dtgCategoria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgCategoria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCategoria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCategoria.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgCategoria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgCategoria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgCategoria.Size = new System.Drawing.Size(272, 192);
            this.dtgCategoria.TabIndex = 70;
            this.dtgCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCategoria_CellClick);
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
            this.btnBuscar.Location = new System.Drawing.Point(230, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBuscar.Size = new System.Drawing.Size(71, 42);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBCategoria
            // 
            this.txtBCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtBCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBCategoria.Image = null;
            this.txtBCategoria.Location = new System.Drawing.Point(29, 36);
            this.txtBCategoria.MaxLength = 32767;
            this.txtBCategoria.Multiline = false;
            this.txtBCategoria.Name = "txtBCategoria";
            this.txtBCategoria.ReadOnly = false;
            this.txtBCategoria.Size = new System.Drawing.Size(206, 42);
            this.txtBCategoria.TabIndex = 76;
            this.txtBCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBCategoria.UseSystemPasswordChar = false;
            this.txtBCategoria.TextChanged += new System.EventHandler(this.txtBCategoria_TextChanged);
            // 
            // pnlRegistrorol
            // 
            this.pnlRegistrorol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegistrorol.Controls.Add(this.btnRegistracat);
            this.pnlRegistrorol.Controls.Add(this.txtCategoria);
            this.pnlRegistrorol.Controls.Add(this.labelEdit1);
            this.pnlRegistrorol.Controls.Add(this.labelEdit2);
            this.pnlRegistrorol.Location = new System.Drawing.Point(322, 36);
            this.pnlRegistrorol.Name = "pnlRegistrorol";
            this.pnlRegistrorol.Size = new System.Drawing.Size(455, 232);
            this.pnlRegistrorol.TabIndex = 78;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtCategoria.Image = null;
            this.txtCategoria.Location = new System.Drawing.Point(173, 73);
            this.txtCategoria.MaxLength = 32767;
            this.txtCategoria.Multiline = false;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = false;
            this.txtCategoria.Size = new System.Drawing.Size(261, 42);
            this.txtCategoria.TabIndex = 71;
            this.txtCategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(17, 83);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(161, 20);
            this.labelEdit1.TabIndex = 70;
            this.labelEdit1.Text = "Nombre de categoría:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(129, 28);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(191, 20);
            this.labelEdit2.TabIndex = 69;
            this.labelEdit2.Text = "Registrar nueva categoría";
            // 
            // pnlModificarol
            // 
            this.pnlModificarol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlModificarol.Controls.Add(this.btncActualizar);
            this.pnlModificarol.Controls.Add(this.txtMcategoria);
            this.pnlModificarol.Controls.Add(this.labelEdit3);
            this.pnlModificarol.Controls.Add(this.labelEdit4);
            this.pnlModificarol.Location = new System.Drawing.Point(322, 36);
            this.pnlModificarol.Name = "pnlModificarol";
            this.pnlModificarol.Size = new System.Drawing.Size(465, 232);
            this.pnlModificarol.TabIndex = 79;
            this.pnlModificarol.Visible = false;
            // 
            // txtMcategoria
            // 
            this.txtMcategoria.BackColor = System.Drawing.Color.Transparent;
            this.txtMcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMcategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtMcategoria.Image = null;
            this.txtMcategoria.Location = new System.Drawing.Point(184, 72);
            this.txtMcategoria.MaxLength = 32767;
            this.txtMcategoria.Multiline = false;
            this.txtMcategoria.Name = "txtMcategoria";
            this.txtMcategoria.ReadOnly = false;
            this.txtMcategoria.Size = new System.Drawing.Size(261, 42);
            this.txtMcategoria.TabIndex = 71;
            this.txtMcategoria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMcategoria.UseSystemPasswordChar = false;
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(17, 83);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(161, 20);
            this.labelEdit3.TabIndex = 70;
            this.labelEdit3.Text = "Nombre de categoría:";
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
            // idcategoria
            // 
            this.idcategoria.HeaderText = "Id";
            this.idcategoria.Name = "idcategoria";
            this.idcategoria.ReadOnly = true;
            this.idcategoria.Width = 50;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 105;
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
            // btncActualizar
            // 
            this.btncActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btncActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btncActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btncActualizar.BorderRadius = 20;
            this.btncActualizar.BorderSize = 0;
            this.btncActualizar.FlatAppearance.BorderSize = 0;
            this.btncActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncActualizar.ForeColor = System.Drawing.Color.White;
            this.btncActualizar.Location = new System.Drawing.Point(153, 156);
            this.btncActualizar.Name = "btncActualizar";
            this.btncActualizar.Size = new System.Drawing.Size(150, 40);
            this.btncActualizar.TabIndex = 26;
            this.btncActualizar.Text = "Actualizar";
            this.btncActualizar.TextColor = System.Drawing.Color.White;
            this.btncActualizar.UseVisualStyleBackColor = false;
            this.btncActualizar.Click += new System.EventHandler(this.btncActualizar_Click);
            // 
            // btnRegistracat
            // 
            this.btnRegistracat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistracat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistracat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistracat.BorderRadius = 20;
            this.btnRegistracat.BorderSize = 0;
            this.btnRegistracat.FlatAppearance.BorderSize = 0;
            this.btnRegistracat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistracat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracat.ForeColor = System.Drawing.Color.White;
            this.btnRegistracat.Location = new System.Drawing.Point(153, 156);
            this.btnRegistracat.Name = "btnRegistracat";
            this.btnRegistracat.Size = new System.Drawing.Size(150, 40);
            this.btnRegistracat.TabIndex = 26;
            this.btnRegistracat.Text = "Guardar";
            this.btnRegistracat.TextColor = System.Drawing.Color.White;
            this.btnRegistracat.UseVisualStyleBackColor = false;
            this.btnRegistracat.Click += new System.EventHandler(this.btnRegistracat_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 301);
            this.Controls.Add(this.pnlModificarol);
            this.Controls.Add(this.pnlRegistrorol);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBCategoria);
            this.Controls.Add(this.dtgCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            this.pnlRegistrorol.ResumeLayout(false);
            this.pnlRegistrorol.PerformLayout();
            this.pnlModificarol.ResumeLayout(false);
            this.pnlModificarol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategoria;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.TextBoxEdit txtBCategoria;
        private System.Windows.Forms.Panel pnlRegistrorol;
        private btnpersonalizados.Botonper btnRegistracat;
        private ReaLTaiizor.Controls.TextBoxEdit txtCategoria;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.Panel pnlModificarol;
        private btnpersonalizados.Botonper btncActualizar;
        private ReaLTaiizor.Controls.TextBoxEdit txtMcategoria;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}