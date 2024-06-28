namespace Presentacion.ModuloProvincia
{
    partial class FrmBuscarProvincia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgProvincia = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtProvincia = new MaterialSkin.Controls.MaterialTextBox();
            this.btnProvincia = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProvincia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProvincia
            // 
            this.dtgProvincia.AllowUserToAddRows = false;
            this.dtgProvincia.AllowUserToDeleteRows = false;
            this.dtgProvincia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProvincia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgProvincia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgProvincia.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgProvincia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProvincia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProvincia.ColumnHeadersHeight = 30;
            this.dtgProvincia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.btneditar,
            this.btneliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProvincia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProvincia.EnableHeadersVisualStyles = false;
            this.dtgProvincia.GridColor = System.Drawing.SystemColors.Control;
            this.dtgProvincia.Location = new System.Drawing.Point(46, 87);
            this.dtgProvincia.Name = "dtgProvincia";
            this.dtgProvincia.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProvincia.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProvincia.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgProvincia.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProvincia.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgProvincia.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dtgProvincia.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProvincia.Size = new System.Drawing.Size(434, 150);
            this.dtgProvincia.TabIndex = 0;
            this.dtgProvincia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProvincia_CellClick);
            this.dtgProvincia.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgProvincia_CellPainting);
            // 
            // name
            // 
            this.name.HeaderText = "Provincia";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // btneditar
            // 
            this.btneditar.HeaderText = "Editar";
            this.btneditar.Name = "btneditar";
            this.btneditar.ReadOnly = true;
            this.btneditar.UseColumnTextForButtonValue = true;
            // 
            // btneliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.btneliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.HeaderText = "Eliminar";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            this.btneliminar.UseColumnTextForButtonValue = true;
            // 
            // txtProvincia
            // 
            this.txtProvincia.AnimateReadOnly = false;
            this.txtProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProvincia.LeadingIcon = null;
            this.txtProvincia.Location = new System.Drawing.Point(46, 19);
            this.txtProvincia.MaxLength = 50;
            this.txtProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProvincia.Multiline = false;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(355, 50);
            this.txtProvincia.TabIndex = 6;
            this.txtProvincia.Text = "";
            this.txtProvincia.TrailingIcon = null;
            this.txtProvincia.TextChanged += new System.EventHandler(this.txtProvincia_TextChanged);
            // 
            // btnProvincia
            // 
            this.btnProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnProvincia.FlatAppearance.BorderSize = 0;
            this.btnProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvincia.ForeColor = System.Drawing.Color.Black;
            this.btnProvincia.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProvincia.IconColor = System.Drawing.Color.Black;
            this.btnProvincia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProvincia.Location = new System.Drawing.Point(399, 18);
            this.btnProvincia.Name = "btnProvincia";
            this.btnProvincia.Size = new System.Drawing.Size(81, 51);
            this.btnProvincia.TabIndex = 7;
            this.btnProvincia.Text = "Buscar";
            this.btnProvincia.UseVisualStyleBackColor = false;
            this.btnProvincia.Click += new System.EventHandler(this.btnProvincia_Click);
            // 
            // FrmBuscarProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 251);
            this.ControlBox = false;
            this.Controls.Add(this.btnProvincia);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.dtgProvincia);
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FrmBuscarProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmBuscarProvincia";
            this.Load += new System.EventHandler(this.FrmBuscarProvincia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProvincia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProvincia;
        private FontAwesome.Sharp.IconButton btnProvincia;
        private MaterialSkin.Controls.MaterialTextBox txtProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn btneditar;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
    }
}