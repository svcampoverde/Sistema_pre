namespace Presentacion.ModuloRolusuario
{
    partial class BuscarRol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRol));
            this.txtRol = new MaterialSkin.Controls.MaterialTextBox();
            this.dtgRol = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBrol = new FontAwesome.Sharp.IconButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRol
            // 
            this.txtRol.AnimateReadOnly = false;
            this.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRol.Depth = 0;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRol.LeadingIcon = null;
            this.txtRol.Location = new System.Drawing.Point(16, 15);
            this.txtRol.MaxLength = 50;
            this.txtRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRol.Multiline = false;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(165, 50);
            this.txtRol.TabIndex = 9;
            this.txtRol.Text = "";
            this.txtRol.TrailingIcon = null;
            this.txtRol.TextChanged += new System.EventHandler(this.txtRol_TextChanged);
            // 
            // dtgRol
            // 
            this.dtgRol.AllowUserToAddRows = false;
            this.dtgRol.AllowUserToDeleteRows = false;
            this.dtgRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgRol.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dtgRol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgRol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgRol.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRol.EnableHeadersVisualStyles = false;
            this.dtgRol.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgRol.Location = new System.Drawing.Point(16, 86);
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
            this.dtgRol.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dtgRol.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRol.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgRol.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgRol.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dtgRol.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgRol.Size = new System.Drawing.Size(284, 94);
            this.dtgRol.TabIndex = 8;
            this.dtgRol.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgRol_CellClick);
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
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 73;
            // 
            // btnBrol
            // 
            this.btnBrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBrol.FlatAppearance.BorderSize = 0;
            this.btnBrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrol.ForeColor = System.Drawing.Color.White;
            this.btnBrol.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBrol.IconColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBrol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrol.Location = new System.Drawing.Point(219, 15);
            this.btnBrol.Name = "btnBrol";
            this.btnBrol.Size = new System.Drawing.Size(81, 51);
            this.btnBrol.TabIndex = 10;
            this.btnBrol.Text = "Buscar";
            this.btnBrol.UseVisualStyleBackColor = false;
            this.btnBrol.Click += new System.EventHandler(this.btnBrol_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 31;
            // 
            // name
            // 
            this.name.HeaderText = "Tipo de usuario";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 144;
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
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 73;
            // 
            // BuscarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btnBrol);
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.dtgRol);
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "BuscarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BuscarRoles";
            this.Load += new System.EventHandler(this.BuscarRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBrol;
        private MaterialSkin.Controls.MaterialTextBox txtRol;
        private System.Windows.Forms.DataGridView dtgRol;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}