namespace Presentacion
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEdit9 = new ReaLTaiizor.Controls.LabelEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            this.ptbCategoria = new System.Windows.Forms.PictureBox();
            this.ptbempresa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbempresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEdit9);
            this.panel1.Controls.Add(this.ptbempresa);
            this.panel1.Location = new System.Drawing.Point(31, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 151);
            this.panel1.TabIndex = 1;
            // 
            // labelEdit9
            // 
            this.labelEdit9.AutoSize = true;
            this.labelEdit9.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit9.ForeColor = System.Drawing.Color.White;
            this.labelEdit9.Location = new System.Drawing.Point(14, 123);
            this.labelEdit9.Name = "labelEdit9";
            this.labelEdit9.Size = new System.Drawing.Size(127, 20);
            this.labelEdit9.TabIndex = 48;
            this.labelEdit9.Text = "Modulo empresa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelEdit2);
            this.panel2.Controls.Add(this.ptbCategoria);
            this.panel2.Location = new System.Drawing.Point(201, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 151);
            this.panel2.TabIndex = 49;
            // 
            // labelEdit2
            // 
            this.labelEdit2.AutoSize = true;
            this.labelEdit2.BackColor = System.Drawing.Color.Transparent;
            this.labelEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEdit2.ForeColor = System.Drawing.Color.White;
            this.labelEdit2.Location = new System.Drawing.Point(14, 123);
            this.labelEdit2.Name = "labelEdit2";
            this.labelEdit2.Size = new System.Drawing.Size(86, 20);
            this.labelEdit2.TabIndex = 48;
            this.labelEdit2.Text = "Categorias";
            // 
            // ptbCategoria
            // 
            this.ptbCategoria.Image = global::Presentacion.Properties.Resources.categorization;
            this.ptbCategoria.Location = new System.Drawing.Point(4, 3);
            this.ptbCategoria.Name = "ptbCategoria";
            this.ptbCategoria.Size = new System.Drawing.Size(139, 117);
            this.ptbCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCategoria.TabIndex = 0;
            this.ptbCategoria.TabStop = false;
            this.ptbCategoria.Click += new System.EventHandler(this.ptbCategoria_Click);
            // 
            // ptbempresa
            // 
            this.ptbempresa.Image = global::Presentacion.Properties.Resources.office;
            this.ptbempresa.Location = new System.Drawing.Point(4, 3);
            this.ptbempresa.Name = "ptbempresa";
            this.ptbempresa.Size = new System.Drawing.Size(139, 117);
            this.ptbempresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbempresa.TabIndex = 0;
            this.ptbempresa.TabStop = false;
            this.ptbempresa.Click += new System.EventHandler(this.ptbempresa_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(903, 575);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(203, 52);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbempresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbempresa;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit9;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private System.Windows.Forms.PictureBox ptbCategoria;
    }
}