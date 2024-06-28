namespace Presentacion.ModuloRolusuario
{
    partial class FRMRol
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
            this.btnRegistrarol = new Presentacion.btnpersonalizados.Botonper();
            this.txtRol = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnRegistrarol);
            this.materialCard1.Controls.Add(this.txtRol);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(3, 5);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(542, 253);
            this.materialCard1.TabIndex = 1;
            // 
            // btnRegistrarol
            // 
            this.btnRegistrarol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(14)))), ((int)(((byte)(15)))));
            this.btnRegistrarol.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarol.BorderRadius = 20;
            this.btnRegistrarol.BorderSize = 0;
            this.btnRegistrarol.FlatAppearance.BorderSize = 0;
            this.btnRegistrarol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarol.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarol.Location = new System.Drawing.Point(198, 182);
            this.btnRegistrarol.Name = "btnRegistrarol";
            this.btnRegistrarol.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrarol.TabIndex = 26;
            this.btnRegistrarol.Text = "Guardar";
            this.btnRegistrarol.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarol.UseVisualStyleBackColor = false;
            this.btnRegistrarol.Click += new System.EventHandler(this.btnRegistrarol_Click);
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
            this.txtRol.Location = new System.Drawing.Point(198, 77);
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
            this.txtRol.Size = new System.Drawing.Size(277, 48);
            this.txtRol.TabIndex = 25;
            this.txtRol.TabStop = false;
            this.txtRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRol.TrailingIcon = null;
            this.txtRol.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 23);
            this.materialLabel1.TabIndex = 28;
            this.materialLabel1.Text = "Nombre de rol:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(195, 14);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(164, 19);
            this.materialLabel8.TabIndex = 23;
            this.materialLabel8.Text = "Registrar rol de usuario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FRMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.materialCard1);
            this.Location = new System.Drawing.Point(2, 1);
            this.Name = "FRMRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FRMRoles";
            this.Load += new System.EventHandler(this.FRMRol_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private btnpersonalizados.Botonper btnRegistrarol;
        private MaterialSkin.Controls.MaterialTextBox2 txtRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}