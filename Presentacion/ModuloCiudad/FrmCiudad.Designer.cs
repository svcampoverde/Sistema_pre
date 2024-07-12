namespace Presentacion.ModuloCiudad
{
    partial class FrmCiudad
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
            this.cmbProvincias = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardarc = new Presentacion.btnpersonalizados.Botonper();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCiudad = new MaterialSkin.Controls.MaterialTextBox2();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.AutoResize = false;
            this.cmbProvincias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbProvincias.Depth = 0;
            this.cmbProvincias.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProvincias.DropDownHeight = 174;
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.DropDownWidth = 121;
            this.cmbProvincias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbProvincias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.IntegralHeight = false;
            this.cmbProvincias.ItemHeight = 43;
            this.cmbProvincias.Location = new System.Drawing.Point(104, 161);
            this.cmbProvincias.MaxDropDownItems = 4;
            this.cmbProvincias.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(227, 49);
            this.cmbProvincias.StartIndex = 0;
            this.cmbProvincias.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnGuardarc
            // 
            this.btnGuardarc.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarc.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGuardarc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardarc.BorderRadius = 20;
            this.btnGuardarc.BorderSize = 0;
            this.btnGuardarc.FlatAppearance.BorderSize = 0;
            this.btnGuardarc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarc.ForeColor = System.Drawing.Color.White;
            this.btnGuardarc.Location = new System.Drawing.Point(113, 254);
            this.btnGuardarc.Name = "btnGuardarc";
            this.btnGuardarc.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarc.TabIndex = 6;
            this.btnGuardarc.Text = "Guardar";
            this.btnGuardarc.TextColor = System.Drawing.Color.White;
            this.btnGuardarc.UseVisualStyleBackColor = false;
            this.btnGuardarc.Click += new System.EventHandler(this.btnGuardarc_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(59, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = " Ciudad:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(19, 180);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(71, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Provincia:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.AnimateReadOnly = false;
            this.txtCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCiudad.Depth = 0;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCiudad.HideSelection = true;
            this.txtCiudad.LeadingIcon = null;
            this.txtCiudad.Location = new System.Drawing.Point(104, 91);
            this.txtCiudad.MaxLength = 32767;
            this.txtCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.PasswordChar = '\0';
            this.txtCiudad.PrefixSuffixText = null;
            this.txtCiudad.ReadOnly = false;
            this.txtCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCiudad.SelectedText = "";
            this.txtCiudad.SelectionLength = 0;
            this.txtCiudad.SelectionStart = 0;
            this.txtCiudad.ShortcutsEnabled = true;
            this.txtCiudad.Size = new System.Drawing.Size(227, 48);
            this.txtCiudad.TabIndex = 10;
            this.txtCiudad.TabStop = false;
            this.txtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCiudad.TrailingIcon = null;
            this.txtCiudad.UseSystemPasswordChar = false;
            // 
            // FrmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 401);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.btnGuardarc);
            this.Name = "FrmCiudad";
            this.Text = "FrmCiudad";
            this.Load += new System.EventHandler(this.FrmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private btnpersonalizados.Botonper btnGuardarc;
        private MaterialSkin.Controls.MaterialComboBox cmbProvincias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtCiudad;
    }
}