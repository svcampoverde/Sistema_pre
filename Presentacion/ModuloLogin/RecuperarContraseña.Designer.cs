namespace Presentacion.ModuloLogin
{
    partial class RecuperarContraseña
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnGuardar = new Presentacion.btnpersonalizados.Botonper();
            this.btnCancelar = new Presentacion.btnpersonalizados.Botonper();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtnpass = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtcpass = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chnpass = new System.Windows.Forms.CheckBox();
            this.chcpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(155, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(179, 23);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Recuperar contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(33, 233);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 51);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.Black;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(315, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 51);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(41, 94);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(133, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Nueva contraseña:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(41, 169);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(159, 19);
            this.materialLabel3.TabIndex = 32;
            this.materialLabel3.Text = "Confirmar contraseña:";
            // 
            // txtnpass
            // 
            this.txtnpass.AnimateReadOnly = false;
            this.txtnpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnpass.Depth = 0;
            this.txtnpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnpass.HideSelection = true;
            this.txtnpass.LeadingIcon = null;
            this.txtnpass.Location = new System.Drawing.Point(212, 78);
            this.txtnpass.MaxLength = 32767;
            this.txtnpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnpass.Name = "txtnpass";
            this.txtnpass.PasswordChar = '*';
            this.txtnpass.PrefixSuffixText = null;
            this.txtnpass.ReadOnly = false;
            this.txtnpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnpass.SelectedText = "";
            this.txtnpass.SelectionLength = 0;
            this.txtnpass.SelectionStart = 0;
            this.txtnpass.ShortcutsEnabled = true;
            this.txtnpass.Size = new System.Drawing.Size(250, 48);
            this.txtnpass.TabIndex = 33;
            this.txtnpass.TabStop = false;
            this.txtnpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnpass.TrailingIcon = null;
            this.txtnpass.UseSystemPasswordChar = false;
            // 
            // txtcpass
            // 
            this.txtcpass.AnimateReadOnly = false;
            this.txtcpass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcpass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcpass.Depth = 0;
            this.txtcpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcpass.HideSelection = true;
            this.txtcpass.LeadingIcon = null;
            this.txtcpass.Location = new System.Drawing.Point(212, 149);
            this.txtcpass.MaxLength = 32767;
            this.txtcpass.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.PasswordChar = '*';
            this.txtcpass.PrefixSuffixText = null;
            this.txtcpass.ReadOnly = false;
            this.txtcpass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcpass.SelectedText = "";
            this.txtcpass.SelectionLength = 0;
            this.txtcpass.SelectionStart = 0;
            this.txtcpass.ShortcutsEnabled = true;
            this.txtcpass.Size = new System.Drawing.Size(250, 48);
            this.txtcpass.TabIndex = 34;
            this.txtcpass.TabStop = false;
            this.txtcpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcpass.TrailingIcon = null;
            this.txtcpass.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 49);
            this.panel1.TabIndex = 35;
            // 
            // chnpass
            // 
            this.chnpass.AutoSize = true;
            this.chnpass.Location = new System.Drawing.Point(212, 126);
            this.chnpass.Name = "chnpass";
            this.chnpass.Size = new System.Drawing.Size(61, 17);
            this.chnpass.TabIndex = 36;
            this.chnpass.Text = "Mostrar";
            this.chnpass.UseVisualStyleBackColor = true;
            this.chnpass.CheckedChanged += new System.EventHandler(this.chnpass_CheckedChanged);
            // 
            // chcpass
            // 
            this.chcpass.AutoSize = true;
            this.chcpass.Location = new System.Drawing.Point(212, 203);
            this.chcpass.Name = "chcpass";
            this.chcpass.Size = new System.Drawing.Size(61, 17);
            this.chcpass.TabIndex = 37;
            this.chcpass.Text = "Mostrar";
            this.chcpass.UseVisualStyleBackColor = true;
            this.chcpass.CheckedChanged += new System.EventHandler(this.chcpass_CheckedChanged);
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 318);
            this.ControlBox = false;
            this.Controls.Add(this.chcpass);
            this.Controls.Add(this.chnpass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcpass);
            this.Controls.Add(this.txtnpass);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnpersonalizados.Botonper btnCancelar;
        private btnpersonalizados.Botonper btnGuardar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtnpass;
        private MaterialSkin.Controls.MaterialTextBox2 txtcpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chnpass;
        private System.Windows.Forms.CheckBox chcpass;
    }
}