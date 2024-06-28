namespace Presentacion.ModuloRolusuario
{
    partial class FrmModificarRol
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
            this.txtRol = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnCerrar = new Presentacion.btnpersonalizados.Botonper();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 33);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Rol de usuario:";
            // 
            // txtRol
            // 
            this.txtRol.AnimateReadOnly = false;
            this.txtRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRol.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRol.Depth = 0;
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRol.HideSelection = true;
            this.txtRol.LeadingIcon = null;
            this.txtRol.Location = new System.Drawing.Point(118, 16);
            this.txtRol.MaxLength = 32767;
            this.txtRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRol.Name = "txtRol";
            this.txtRol.PasswordChar = '\0';
            this.txtRol.PrefixSuffixText = null;
            this.txtRol.ReadOnly = false;
            this.txtRol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRol.SelectedText = "";
            this.txtRol.SelectionLength = 0;
            this.txtRol.SelectionStart = 0;
            this.txtRol.ShortcutsEnabled = true;
            this.txtRol.Size = new System.Drawing.Size(250, 48);
            this.txtRol.TabIndex = 2;
            this.txtRol.TabStop = false;
            this.txtRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRol.TrailingIcon = null;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCerrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrar.BorderRadius = 20;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(118, 136);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextColor = System.Drawing.Color.White;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 235);
            this.ControlBox = false;
            this.Controls.Add(this.txtRol);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnCerrar);
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FrmModificarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmModificarRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnpersonalizados.Botonper btnCerrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtRol;
    }
}