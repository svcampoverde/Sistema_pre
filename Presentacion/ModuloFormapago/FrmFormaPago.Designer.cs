namespace Presentacion.ModuloPago
{
    partial class FrmFormaPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormaPago));
            this.pnlRegfPago = new ReaLTaiizor.Controls.Panel();
            this.txtfpago = new ReaLTaiizor.Controls.TextBoxEdit();
            this.ptbrfpago = new System.Windows.Forms.PictureBox();
            this.txtfpDescrpcion = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit6 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit30 = new ReaLTaiizor.Controls.LabelEdit();
            this.pnlListFpago = new System.Windows.Forms.Panel();
            this.ptbaddfpago = new System.Windows.Forms.PictureBox();
            this.txtBformapag = new ReaLTaiizor.Controls.TextBoxEdit();
            this.dtgFormapago = new System.Windows.Forms.DataGridView();
            this.btnBformapag = new ReaLTaiizor.Controls.Button();
            this.pnlMfpago = new ReaLTaiizor.Controls.Panel();
            this.txtMfpago = new ReaLTaiizor.Controls.TextBoxEdit();
            this.ptbMfpago = new System.Windows.Forms.PictureBox();
            this.txtMfpdescripcion = new ReaLTaiizor.Controls.TextBoxEdit();
            this.labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMfpago = new Presentacion.btnpersonalizados.Botonper();
            this.btnGuardarfpago = new Presentacion.btnpersonalizados.Botonper();
            this.idfpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlRegfPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbrfpago)).BeginInit();
            this.pnlListFpago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbaddfpago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormapago)).BeginInit();
            this.pnlMfpago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMfpago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegfPago
            // 
            this.pnlRegfPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlRegfPago.Controls.Add(this.txtfpago);
            this.pnlRegfPago.Controls.Add(this.ptbrfpago);
            this.pnlRegfPago.Controls.Add(this.btnGuardarfpago);
            this.pnlRegfPago.Controls.Add(this.txtfpDescrpcion);
            this.pnlRegfPago.Controls.Add(this.labelEdit6);
            this.pnlRegfPago.Controls.Add(this.labelEdit3);
            this.pnlRegfPago.Controls.Add(this.labelEdit30);
            this.pnlRegfPago.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlRegfPago.Location = new System.Drawing.Point(12, 12);
            this.pnlRegfPago.Name = "pnlRegfPago";
            this.pnlRegfPago.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRegfPago.Size = new System.Drawing.Size(467, 323);
            this.pnlRegfPago.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlRegfPago.TabIndex = 2;
            this.pnlRegfPago.Visible = false;
            // 
            // txtfpago
            // 
            this.txtfpago.BackColor = System.Drawing.Color.Transparent;
            this.txtfpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfpago.ForeColor = System.Drawing.Color.White;
            this.txtfpago.Image = null;
            this.txtfpago.Location = new System.Drawing.Point(153, 81);
            this.txtfpago.MaxLength = 32767;
            this.txtfpago.Multiline = false;
            this.txtfpago.Name = "txtfpago";
            this.txtfpago.ReadOnly = false;
            this.txtfpago.Size = new System.Drawing.Size(280, 42);
            this.txtfpago.TabIndex = 90;
            this.txtfpago.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfpago.UseSystemPasswordChar = false;
            // 
            // ptbrfpago
            // 
            this.ptbrfpago.Image = global::Presentacion.Properties.Resources.left_arrow;
            this.ptbrfpago.Location = new System.Drawing.Point(30, 12);
            this.ptbrfpago.Name = "ptbrfpago";
            this.ptbrfpago.Size = new System.Drawing.Size(34, 31);
            this.ptbrfpago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbrfpago.TabIndex = 89;
            this.ptbrfpago.TabStop = false;
            this.ptbrfpago.Click += new System.EventHandler(this.ptbrfpago_Click);
            // 
            // txtfpDescrpcion
            // 
            this.txtfpDescrpcion.BackColor = System.Drawing.Color.Transparent;
            this.txtfpDescrpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtfpDescrpcion.ForeColor = System.Drawing.Color.White;
            this.txtfpDescrpcion.Image = null;
            this.txtfpDescrpcion.Location = new System.Drawing.Point(153, 140);
            this.txtfpDescrpcion.MaxLength = 32767;
            this.txtfpDescrpcion.Multiline = true;
            this.txtfpDescrpcion.Name = "txtfpDescrpcion";
            this.txtfpDescrpcion.ReadOnly = false;
            this.txtfpDescrpcion.Size = new System.Drawing.Size(280, 82);
            this.txtfpDescrpcion.TabIndex = 65;
            this.txtfpDescrpcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfpDescrpcion.UseSystemPasswordChar = false;
            // 
            // labelEdit6
            // 
            this.labelEdit6.AutoSize = true;
            this.labelEdit6.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit6.ForeColor = System.Drawing.Color.White;
            this.labelEdit6.Location = new System.Drawing.Point(26, 92);
            this.labelEdit6.Name = "labelEdit6";
            this.labelEdit6.Size = new System.Drawing.Size(121, 20);
            this.labelEdit6.TabIndex = 59;
            this.labelEdit6.Text = "Forma de pago:";
            // 
            // labelEdit3
            // 
            this.labelEdit3.AutoSize = true;
            this.labelEdit3.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit3.ForeColor = System.Drawing.Color.White;
            this.labelEdit3.Location = new System.Drawing.Point(26, 151);
            this.labelEdit3.Name = "labelEdit3";
            this.labelEdit3.Size = new System.Drawing.Size(96, 20);
            this.labelEdit3.TabIndex = 56;
            this.labelEdit3.Text = "Descripción:";
            // 
            // labelEdit30
            // 
            this.labelEdit30.AutoSize = true;
            this.labelEdit30.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit30.ForeColor = System.Drawing.Color.White;
            this.labelEdit30.Location = new System.Drawing.Point(108, 23);
            this.labelEdit30.Name = "labelEdit30";
            this.labelEdit30.Size = new System.Drawing.Size(245, 20);
            this.labelEdit30.TabIndex = 53;
            this.labelEdit30.Text = "Registro de nueva forma de pago";
            // 
            // pnlListFpago
            // 
            this.pnlListFpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlListFpago.Controls.Add(this.ptbaddfpago);
            this.pnlListFpago.Controls.Add(this.txtBformapag);
            this.pnlListFpago.Controls.Add(this.dtgFormapago);
            this.pnlListFpago.Controls.Add(this.btnBformapag);
            this.pnlListFpago.Location = new System.Drawing.Point(21, 24);
            this.pnlListFpago.Name = "pnlListFpago";
            this.pnlListFpago.Size = new System.Drawing.Size(830, 368);
            this.pnlListFpago.TabIndex = 90;
            // 
            // ptbaddfpago
            // 
            this.ptbaddfpago.Image = global::Presentacion.Properties.Resources.add;
            this.ptbaddfpago.Location = new System.Drawing.Point(36, 19);
            this.ptbaddfpago.Name = "ptbaddfpago";
            this.ptbaddfpago.Size = new System.Drawing.Size(43, 38);
            this.ptbaddfpago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbaddfpago.TabIndex = 86;
            this.ptbaddfpago.TabStop = false;
            this.ptbaddfpago.Click += new System.EventHandler(this.ptbaddfpago_Click);
            // 
            // txtBformapag
            // 
            this.txtBformapag.BackColor = System.Drawing.Color.Transparent;
            this.txtBformapag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBformapag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtBformapag.Image = null;
            this.txtBformapag.Location = new System.Drawing.Point(144, 19);
            this.txtBformapag.MaxLength = 32767;
            this.txtBformapag.Multiline = false;
            this.txtBformapag.Name = "txtBformapag";
            this.txtBformapag.ReadOnly = false;
            this.txtBformapag.Size = new System.Drawing.Size(259, 42);
            this.txtBformapag.TabIndex = 82;
            this.txtBformapag.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBformapag.UseSystemPasswordChar = false;
            this.txtBformapag.TextChanged += new System.EventHandler(this.txtBformapag_TextChanged);
            // 
            // dtgFormapago
            // 
            this.dtgFormapago.AllowUserToAddRows = false;
            this.dtgFormapago.AllowUserToDeleteRows = false;
            this.dtgFormapago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgFormapago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgFormapago.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgFormapago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgFormapago.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dtgFormapago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFormapago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgFormapago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFormapago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfpago,
            this.fpago,
            this.descripcion,
            this.btnEditar,
            this.btnEliminar});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgFormapago.DefaultCellStyle = dataGridViewCellStyle11;
            this.dtgFormapago.EnableHeadersVisualStyles = false;
            this.dtgFormapago.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgFormapago.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgFormapago.Location = new System.Drawing.Point(47, 78);
            this.dtgFormapago.Name = "dtgFormapago";
            this.dtgFormapago.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFormapago.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgFormapago.RowHeadersVisible = false;
            this.dtgFormapago.RowHeadersWidth = 40;
            this.dtgFormapago.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.dtgFormapago.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgFormapago.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dtgFormapago.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.dtgFormapago.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgFormapago.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgFormapago.Size = new System.Drawing.Size(759, 216);
            this.dtgFormapago.TabIndex = 81;
            this.dtgFormapago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFormapago_CellClick);
            // 
            // btnBformapag
            // 
            this.btnBformapag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBformapag.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnBformapag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBformapag.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnBformapag.EnteredColor = System.Drawing.Color.Transparent;
            this.btnBformapag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBformapag.Image = null;
            this.btnBformapag.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBformapag.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBformapag.Location = new System.Drawing.Point(400, 19);
            this.btnBformapag.Name = "btnBformapag";
            this.btnBformapag.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnBformapag.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnBformapag.Size = new System.Drawing.Size(71, 42);
            this.btnBformapag.TabIndex = 83;
            this.btnBformapag.Text = "Buscar";
            this.btnBformapag.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBformapag.Click += new System.EventHandler(this.btnBformapag_Click);
            // 
            // pnlMfpago
            // 
            this.pnlMfpago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlMfpago.Controls.Add(this.txtMfpago);
            this.pnlMfpago.Controls.Add(this.ptbMfpago);
            this.pnlMfpago.Controls.Add(this.btnMfpago);
            this.pnlMfpago.Controls.Add(this.txtMfpdescripcion);
            this.pnlMfpago.Controls.Add(this.labelEdit1);
            this.pnlMfpago.Controls.Add(this.labelEdit2);
            this.pnlMfpago.Controls.Add(this.labelEdit4);
            this.pnlMfpago.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlMfpago.Location = new System.Drawing.Point(12, 12);
            this.pnlMfpago.Name = "pnlMfpago";
            this.pnlMfpago.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMfpago.Size = new System.Drawing.Size(435, 302);
            this.pnlMfpago.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlMfpago.TabIndex = 91;
            this.pnlMfpago.Visible = false;
            // 
            // txtMfpago
            // 
            this.txtMfpago.BackColor = System.Drawing.Color.Transparent;
            this.txtMfpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMfpago.ForeColor = System.Drawing.Color.White;
            this.txtMfpago.Image = null;
            this.txtMfpago.Location = new System.Drawing.Point(153, 81);
            this.txtMfpago.MaxLength = 32767;
            this.txtMfpago.Multiline = false;
            this.txtMfpago.Name = "txtMfpago";
            this.txtMfpago.ReadOnly = false;
            this.txtMfpago.Size = new System.Drawing.Size(256, 42);
            this.txtMfpago.TabIndex = 90;
            this.txtMfpago.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMfpago.UseSystemPasswordChar = false;
            // 
            // ptbMfpago
            // 
            this.ptbMfpago.Image = global::Presentacion.Properties.Resources.left_arrow;
            this.ptbMfpago.Location = new System.Drawing.Point(30, 12);
            this.ptbMfpago.Name = "ptbMfpago";
            this.ptbMfpago.Size = new System.Drawing.Size(34, 31);
            this.ptbMfpago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMfpago.TabIndex = 89;
            this.ptbMfpago.TabStop = false;
            this.ptbMfpago.Click += new System.EventHandler(this.ptbMfpago_Click);
            // 
            // txtMfpdescripcion
            // 
            this.txtMfpdescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtMfpdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMfpdescripcion.ForeColor = System.Drawing.Color.White;
            this.txtMfpdescripcion.Image = null;
            this.txtMfpdescripcion.Location = new System.Drawing.Point(153, 140);
            this.txtMfpdescripcion.MaxLength = 32767;
            this.txtMfpdescripcion.Multiline = true;
            this.txtMfpdescripcion.Name = "txtMfpdescripcion";
            this.txtMfpdescripcion.ReadOnly = false;
            this.txtMfpdescripcion.Size = new System.Drawing.Size(256, 68);
            this.txtMfpdescripcion.TabIndex = 65;
            this.txtMfpdescripcion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMfpdescripcion.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            this.labelEdit1.AutoSize = true;
            this.labelEdit1.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit1.ForeColor = System.Drawing.Color.White;
            this.labelEdit1.Location = new System.Drawing.Point(26, 92);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Size = new System.Drawing.Size(121, 20);
            this.labelEdit1.TabIndex = 59;
            this.labelEdit1.Text = "Forma de pago:";
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(26, 151);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(96, 20);
            this.labelEdit2.TabIndex = 56;
            this.labelEdit2.Text = "Descripción:";
            // 
            // labelEdit4
            // 
            this.labelEdit4.AutoSize = true;
            this.labelEdit4.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit4.ForeColor = System.Drawing.Color.White;
            this.labelEdit4.Location = new System.Drawing.Point(108, 23);
            this.labelEdit4.Name = "labelEdit4";
            this.labelEdit4.Size = new System.Drawing.Size(186, 20);
            this.labelEdit4.TabIndex = 53;
            this.labelEdit4.Text = "Actualizar forma de pago";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMfpago
            // 
            this.btnMfpago.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMfpago.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMfpago.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMfpago.BorderRadius = 20;
            this.btnMfpago.BorderSize = 0;
            this.btnMfpago.FlatAppearance.BorderSize = 0;
            this.btnMfpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMfpago.ForeColor = System.Drawing.Color.White;
            this.btnMfpago.Location = new System.Drawing.Point(144, 231);
            this.btnMfpago.Name = "btnMfpago";
            this.btnMfpago.Size = new System.Drawing.Size(150, 40);
            this.btnMfpago.TabIndex = 78;
            this.btnMfpago.Text = "Actualizar";
            this.btnMfpago.TextColor = System.Drawing.Color.White;
            this.btnMfpago.UseVisualStyleBackColor = false;
            this.btnMfpago.Click += new System.EventHandler(this.btnMfpago_Click);
            // 
            // btnGuardarfpago
            // 
            this.btnGuardarfpago.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarfpago.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarfpago.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarfpago.BorderRadius = 20;
            this.btnGuardarfpago.BorderSize = 0;
            this.btnGuardarfpago.FlatAppearance.BorderSize = 0;
            this.btnGuardarfpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarfpago.ForeColor = System.Drawing.Color.White;
            this.btnGuardarfpago.Location = new System.Drawing.Point(174, 256);
            this.btnGuardarfpago.Name = "btnGuardarfpago";
            this.btnGuardarfpago.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarfpago.TabIndex = 78;
            this.btnGuardarfpago.Text = "Guardar";
            this.btnGuardarfpago.TextColor = System.Drawing.Color.White;
            this.btnGuardarfpago.UseVisualStyleBackColor = false;
            this.btnGuardarfpago.Click += new System.EventHandler(this.btnGuardarfpago_Click);
            // 
            // idfpago
            // 
            this.idfpago.HeaderText = "Id";
            this.idfpago.Name = "idfpago";
            this.idfpago.ReadOnly = true;
            this.idfpago.Width = 50;
            // 
            // fpago
            // 
            this.fpago.HeaderText = "Forma de pago";
            this.fpago.Name = "fpago";
            this.fpago.ReadOnly = true;
            this.fpago.Width = 144;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 119;
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
            // FrmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 746);
            this.Controls.Add(this.pnlMfpago);
            this.Controls.Add(this.pnlListFpago);
            this.Controls.Add(this.pnlRegfPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFormaPago";
            this.Load += new System.EventHandler(this.FrmFormaPago_Load);
            this.pnlRegfPago.ResumeLayout(false);
            this.pnlRegfPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbrfpago)).EndInit();
            this.pnlListFpago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbaddfpago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormapago)).EndInit();
            this.pnlMfpago.ResumeLayout(false);
            this.pnlMfpago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMfpago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel pnlRegfPago;
        private btnpersonalizados.Botonper btnGuardarfpago;
        private ReaLTaiizor.Controls.TextBoxEdit txtfpDescrpcion;
        private ReaLTaiizor.Controls.LabelEdit labelEdit6;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit labelEdit30;
        private System.Windows.Forms.PictureBox ptbrfpago;
        private ReaLTaiizor.Controls.TextBoxEdit txtfpago;
        private System.Windows.Forms.Panel pnlListFpago;
        private System.Windows.Forms.PictureBox ptbaddfpago;
        private ReaLTaiizor.Controls.TextBoxEdit txtBformapag;
        private System.Windows.Forms.DataGridView dtgFormapago;
        private ReaLTaiizor.Controls.Button btnBformapag;
        private ReaLTaiizor.Controls.Panel pnlMfpago;
        private ReaLTaiizor.Controls.TextBoxEdit txtMfpago;
        private System.Windows.Forms.PictureBox ptbMfpago;
        private btnpersonalizados.Botonper btnMfpago;
        private ReaLTaiizor.Controls.TextBoxEdit txtMfpdescripcion;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}