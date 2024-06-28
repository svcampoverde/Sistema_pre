namespace Presentacion.Provincia
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtProvincia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRegistrarp = new Presentacion.btnpersonalizados.Botonper();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnRegistrarp);
            this.materialCard1.Controls.Add(this.txtProvincia);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, -1);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 253);
            this.materialCard1.TabIndex = 0;
            // 
            // txtProvincia
            // 
            this.txtProvincia.AnimateReadOnly = false;
            this.txtProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtProvincia.Depth = 0;
            this.txtProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtProvincia.HideSelection = true;
            this.txtProvincia.LeadingIcon = null;
            this.txtProvincia.Location = new System.Drawing.Point(198, 77);
            this.txtProvincia.MaxLength = 32767;
            this.txtProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.PasswordChar = '\0';
            this.txtProvincia.PrefixSuffixText = null;
            this.txtProvincia.ReadOnly = false;
            this.txtProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProvincia.SelectedText = "";
            this.txtProvincia.SelectionLength = 0;
            this.txtProvincia.SelectionStart = 0;
            this.txtProvincia.ShortcutsEnabled = true;
            this.txtProvincia.Size = new System.Drawing.Size(277, 48);
            this.txtProvincia.TabIndex = 25;
            this.txtProvincia.TabStop = false;
            this.txtProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProvincia.TrailingIcon = null;
            this.txtProvincia.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(29, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 23);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Nombre de provincia:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(195, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(133, 19);
            this.materialLabel8.TabIndex = 23;
            this.materialLabel8.Text = "Registrar provincia";
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
            this.btnRegistrarp.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarp.Location = new System.Drawing.Point(198, 182);
            this.btnRegistrarp.Name = "btnRegistrarp";
            this.btnRegistrarp.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarp.TabIndex = 26;
            this.btnRegistrarp.Text = "Guardar";
            this.btnRegistrarp.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarp.UseVisualStyleBackColor = false;
            this.btnRegistrarp.Click += new System.EventHandler(this.btnRegistrarp_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 253);
            this.ControlBox = false;
            this.Controls.Add(this.materialCard1);
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FrmProvincia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRMProvincia";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtProvincia;
        private btnpersonalizados.Botonper btnRegistrarp;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}