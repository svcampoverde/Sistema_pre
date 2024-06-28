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
            this.txtCiudad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbProvincias = new MaterialSkin.Controls.MaterialComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardarc = new Presentacion.btnpersonalizados.Botonper();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCiudad
            // 
            // 
            // 
            // 
            this.txtCiudad.Border.BackColorGradientAngle = 5;
            this.txtCiudad.Border.Class = "TextBoxBorder";
            this.txtCiudad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(212, 133);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(170, 26);
            this.txtCiudad.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(69, 128);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(137, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Nombre de ciudad";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(69, 190);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(137, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Seleccionar provincia";
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
            this.cmbProvincias.Location = new System.Drawing.Point(245, 176);
            this.cmbProvincias.MaxDropDownItems = 4;
            this.cmbProvincias.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(121, 49);
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
            this.btnGuardarc.Location = new System.Drawing.Point(181, 266);
            this.btnGuardarc.Name = "btnGuardarc";
            this.btnGuardarc.Size = new System.Drawing.Size(150, 40);
            this.btnGuardarc.TabIndex = 6;
            this.btnGuardarc.Text = "Guardar";
            this.btnGuardarc.TextColor = System.Drawing.Color.White;
            this.btnGuardarc.UseVisualStyleBackColor = false;
            this.btnGuardarc.Click += new System.EventHandler(this.btnGuardarc_Click);
            // 
            // FrmCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 323);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.btnGuardarc);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtCiudad);
            this.Name = "FrmCiudad";
            this.Text = "FrmCiudad";
            this.Load += new System.EventHandler(this.FrmCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.TextBoxX txtCiudad;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private btnpersonalizados.Botonper btnGuardarc;
        private MaterialSkin.Controls.MaterialComboBox cmbProvincias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}