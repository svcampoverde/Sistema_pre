
namespace Presentacion
{
    partial class FrmIPrincipal
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelhome = new ReaLTaiizor.Controls.Panel();
            this.contUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUser = new ReaLTaiizor.Controls.Panel();
            this.pnlRegistrarU = new ReaLTaiizor.Controls.Panel();
            this.pnlListarU = new ReaLTaiizor.Controls.Panel();
            this.panelcliente = new ReaLTaiizor.Controls.Panel();
            this.pContentPesupuesto = new System.Windows.Forms.FlowLayoutPanel();
            this.PMPresupuesto = new ReaLTaiizor.Controls.Panel();
            this.pnlRpre = new ReaLTaiizor.Controls.Panel();
            this.pnlLp = new ReaLTaiizor.Controls.Panel();
            this.menuTransicion = new System.Windows.Forms.Timer(this.components);
            this.slidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.Mpresupuesto = new System.Windows.Forms.Timer(this.components);
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnUs = new FontAwesome.Sharp.IconButton();
            this.btnMr = new FontAwesome.Sharp.IconButton();
            this.btnML = new FontAwesome.Sharp.IconButton();
            this.btnUsuario = new FontAwesome.Sharp.IconButton();
            this.Mdpresupuesto = new FontAwesome.Sharp.IconButton();
            this.btnRegistrarp = new FontAwesome.Sharp.IconButton();
            this.btnListarp = new FontAwesome.Sharp.IconButton();
            this.icnmax = new System.Windows.Forms.PictureBox();
            this.icnmin = new System.Windows.Forms.PictureBox();
            this.icnrest = new System.Windows.Forms.PictureBox();
            this.icncerrar = new System.Windows.Forms.PictureBox();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.pnelMenu.SuspendLayout();
            this.panelhome.SuspendLayout();
            this.contUsuario.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlRegistrarU.SuspendLayout();
            this.pnlListarU.SuspendLayout();
            this.panelcliente.SuspendLayout();
            this.pContentPesupuesto.SuspendLayout();
            this.PMPresupuesto.SuspendLayout();
            this.pnlRpre.SuspendLayout();
            this.pnlLp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnrest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelHeader.Controls.Add(this.icnmax);
            this.panelHeader.Controls.Add(this.icnmin);
            this.panelHeader.Controls.Add(this.icnrest);
            this.panelHeader.Controls.Add(this.icncerrar);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.ptbMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1088, 40);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema";
            // 
            // pnelMenu
            // 
            this.pnelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnelMenu.Controls.Add(this.panelhome);
            this.pnelMenu.Controls.Add(this.contUsuario);
            this.pnelMenu.Controls.Add(this.panelcliente);
            this.pnelMenu.Controls.Add(this.pContentPesupuesto);
            this.pnelMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnelMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnelMenu.Location = new System.Drawing.Point(0, 40);
            this.pnelMenu.Name = "pnelMenu";
            this.pnelMenu.Size = new System.Drawing.Size(186, 582);
            this.pnelMenu.TabIndex = 1;
            // 
            // panelhome
            // 
            this.panelhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelhome.Controls.Add(this.btnHome);
            this.panelhome.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelhome.Location = new System.Drawing.Point(3, 3);
            this.panelhome.Name = "panelhome";
            this.panelhome.Padding = new System.Windows.Forms.Padding(5);
            this.panelhome.Size = new System.Drawing.Size(184, 62);
            this.panelhome.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelhome.TabIndex = 3;
            this.panelhome.Text = "panel1";
            // 
            // contUsuario
            // 
            this.contUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.contUsuario.Controls.Add(this.pnlUser);
            this.contUsuario.Controls.Add(this.pnlRegistrarU);
            this.contUsuario.Controls.Add(this.pnlListarU);
            this.contUsuario.Location = new System.Drawing.Point(3, 71);
            this.contUsuario.Name = "contUsuario";
            this.contUsuario.Size = new System.Drawing.Size(194, 61);
            this.contUsuario.TabIndex = 5;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlUser.Controls.Add(this.btnUs);
            this.pnlUser.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlUser.Location = new System.Drawing.Point(3, 3);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Padding = new System.Windows.Forms.Padding(5);
            this.pnlUser.Size = new System.Drawing.Size(191, 76);
            this.pnlUser.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlUser.TabIndex = 5;
            this.pnlUser.Text = "panel5";
            // 
            // pnlRegistrarU
            // 
            this.pnlRegistrarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlRegistrarU.Controls.Add(this.btnMr);
            this.pnlRegistrarU.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlRegistrarU.Location = new System.Drawing.Point(3, 85);
            this.pnlRegistrarU.Name = "pnlRegistrarU";
            this.pnlRegistrarU.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRegistrarU.Size = new System.Drawing.Size(181, 70);
            this.pnlRegistrarU.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlRegistrarU.TabIndex = 6;
            this.pnlRegistrarU.Text = "panel4";
            // 
            // pnlListarU
            // 
            this.pnlListarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlListarU.Controls.Add(this.btnML);
            this.pnlListarU.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlListarU.Location = new System.Drawing.Point(3, 161);
            this.pnlListarU.Name = "pnlListarU";
            this.pnlListarU.Padding = new System.Windows.Forms.Padding(5);
            this.pnlListarU.Size = new System.Drawing.Size(181, 70);
            this.pnlListarU.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlListarU.TabIndex = 6;
            this.pnlListarU.Text = "panel3";
            // 
            // panelcliente
            // 
            this.panelcliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelcliente.Controls.Add(this.btnUsuario);
            this.panelcliente.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panelcliente.Location = new System.Drawing.Point(3, 138);
            this.panelcliente.Name = "panelcliente";
            this.panelcliente.Padding = new System.Windows.Forms.Padding(5);
            this.panelcliente.Size = new System.Drawing.Size(184, 62);
            this.panelcliente.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panelcliente.TabIndex = 4;
            this.panelcliente.Text = "panel2";
            // 
            // pContentPesupuesto
            // 
            this.pContentPesupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pContentPesupuesto.Controls.Add(this.PMPresupuesto);
            this.pContentPesupuesto.Controls.Add(this.pnlRpre);
            this.pContentPesupuesto.Controls.Add(this.pnlLp);
            this.pContentPesupuesto.Location = new System.Drawing.Point(3, 206);
            this.pContentPesupuesto.Name = "pContentPesupuesto";
            this.pContentPesupuesto.Size = new System.Drawing.Size(194, 58);
            this.pContentPesupuesto.TabIndex = 7;
            // 
            // PMPresupuesto
            // 
            this.PMPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PMPresupuesto.Controls.Add(this.Mdpresupuesto);
            this.PMPresupuesto.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.PMPresupuesto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.PMPresupuesto.Location = new System.Drawing.Point(3, 3);
            this.PMPresupuesto.Name = "PMPresupuesto";
            this.PMPresupuesto.Padding = new System.Windows.Forms.Padding(5);
            this.PMPresupuesto.Size = new System.Drawing.Size(191, 59);
            this.PMPresupuesto.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PMPresupuesto.TabIndex = 5;
            this.PMPresupuesto.Text = "panel5";
            // 
            // pnlRpre
            // 
            this.pnlRpre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlRpre.Controls.Add(this.btnRegistrarp);
            this.pnlRpre.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlRpre.Location = new System.Drawing.Point(3, 68);
            this.pnlRpre.Name = "pnlRpre";
            this.pnlRpre.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRpre.Size = new System.Drawing.Size(181, 70);
            this.pnlRpre.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlRpre.TabIndex = 6;
            this.pnlRpre.Text = "panel4";
            // 
            // pnlLp
            // 
            this.pnlLp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlLp.Controls.Add(this.btnListarp);
            this.pnlLp.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlLp.Location = new System.Drawing.Point(3, 144);
            this.pnlLp.Name = "pnlLp";
            this.pnlLp.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLp.Size = new System.Drawing.Size(181, 70);
            this.pnlLp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlLp.TabIndex = 6;
            this.pnlLp.Text = "panel3";
            // 
            // menuTransicion
            // 
            this.menuTransicion.Interval = 5;
            this.menuTransicion.Tick += new System.EventHandler(this.menuTransicion_Tick);
            // 
            // slidebarTrans
            // 
            this.slidebarTrans.Interval = 5;
            this.slidebarTrans.Tick += new System.EventHandler(this.slidebarTrans_Tick);
            // 
            // Mpresupuesto
            // 
            this.Mpresupuesto.Interval = 10;
            this.Mpresupuesto.Tick += new System.EventHandler(this.Mpresupuesto_Tick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnHome.BackgroundImage = global::Presentacion.Properties.Resources.homes;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.Color.Black;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHome.Location = new System.Drawing.Point(19, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(133, 36);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "     Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnUs
            // 
            this.btnUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUs.BackgroundImage = global::Presentacion.Properties.Resources.module;
            this.btnUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUs.FlatAppearance.BorderSize = 0;
            this.btnUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUs.ForeColor = System.Drawing.Color.White;
            this.btnUs.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUs.IconColor = System.Drawing.Color.White;
            this.btnUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUs.Location = new System.Drawing.Point(19, 18);
            this.btnUs.Name = "btnUs";
            this.btnUs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUs.Size = new System.Drawing.Size(164, 41);
            this.btnUs.TabIndex = 2;
            this.btnUs.Text = "  Usuario";
            this.btnUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUs.UseVisualStyleBackColor = false;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // btnMr
            // 
            this.btnMr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnMr.BackgroundImage = global::Presentacion.Properties.Resources.user;
            this.btnMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMr.FlatAppearance.BorderSize = 0;
            this.btnMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMr.ForeColor = System.Drawing.Color.White;
            this.btnMr.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnMr.IconColor = System.Drawing.Color.Black;
            this.btnMr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMr.Location = new System.Drawing.Point(19, 18);
            this.btnMr.Name = "btnMr";
            this.btnMr.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMr.Size = new System.Drawing.Size(133, 31);
            this.btnMr.TabIndex = 2;
            this.btnMr.Text = "    Registrar";
            this.btnMr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMr.UseVisualStyleBackColor = false;
            this.btnMr.Click += new System.EventHandler(this.btnMr_Click);
            // 
            // btnML
            // 
            this.btnML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnML.BackgroundImage = global::Presentacion.Properties.Resources.user;
            this.btnML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnML.FlatAppearance.BorderSize = 0;
            this.btnML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnML.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnML.ForeColor = System.Drawing.Color.White;
            this.btnML.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnML.IconColor = System.Drawing.Color.Black;
            this.btnML.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnML.Location = new System.Drawing.Point(19, 18);
            this.btnML.Name = "btnML";
            this.btnML.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnML.Size = new System.Drawing.Size(133, 31);
            this.btnML.TabIndex = 2;
            this.btnML.Text = "    Listar";
            this.btnML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnML.UseVisualStyleBackColor = false;
            this.btnML.Click += new System.EventHandler(this.btnML_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuario.IconColor = System.Drawing.Color.Black;
            this.btnUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(19, 18);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(133, 31);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "    Cliente";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // Mdpresupuesto
            // 
            this.Mdpresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Mdpresupuesto.BackgroundImage = global::Presentacion.Properties.Resources.module;
            this.Mdpresupuesto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mdpresupuesto.FlatAppearance.BorderSize = 0;
            this.Mdpresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mdpresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdpresupuesto.ForeColor = System.Drawing.Color.White;
            this.Mdpresupuesto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Mdpresupuesto.IconColor = System.Drawing.Color.White;
            this.Mdpresupuesto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mdpresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mdpresupuesto.Location = new System.Drawing.Point(19, 16);
            this.Mdpresupuesto.Name = "Mdpresupuesto";
            this.Mdpresupuesto.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Mdpresupuesto.Size = new System.Drawing.Size(164, 31);
            this.Mdpresupuesto.TabIndex = 2;
            this.Mdpresupuesto.Text = " Presupuesto";
            this.Mdpresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mdpresupuesto.UseVisualStyleBackColor = false;
            this.Mdpresupuesto.Click += new System.EventHandler(this.Mdpresupuesto_Click);
            // 
            // btnRegistrarp
            // 
            this.btnRegistrarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnRegistrarp.BackgroundImage = global::Presentacion.Properties.Resources.budget;
            this.btnRegistrarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrarp.FlatAppearance.BorderSize = 0;
            this.btnRegistrarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarp.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrarp.IconColor = System.Drawing.Color.Black;
            this.btnRegistrarp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarp.Location = new System.Drawing.Point(19, 18);
            this.btnRegistrarp.Name = "btnRegistrarp";
            this.btnRegistrarp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRegistrarp.Size = new System.Drawing.Size(133, 31);
            this.btnRegistrarp.TabIndex = 2;
            this.btnRegistrarp.Text = "    Registrar";
            this.btnRegistrarp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarp.UseVisualStyleBackColor = false;
            this.btnRegistrarp.Click += new System.EventHandler(this.btnRegistrarp_Click);
            // 
            // btnListarp
            // 
            this.btnListarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnListarp.BackgroundImage = global::Presentacion.Properties.Resources.budgeting;
            this.btnListarp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnListarp.FlatAppearance.BorderSize = 0;
            this.btnListarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarp.ForeColor = System.Drawing.Color.White;
            this.btnListarp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarp.IconColor = System.Drawing.Color.Black;
            this.btnListarp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarp.Location = new System.Drawing.Point(19, 18);
            this.btnListarp.Name = "btnListarp";
            this.btnListarp.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnListarp.Size = new System.Drawing.Size(133, 31);
            this.btnListarp.TabIndex = 2;
            this.btnListarp.Text = "    Listar";
            this.btnListarp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarp.UseVisualStyleBackColor = false;
            // 
            // icnmax
            // 
            this.icnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnmax.Image = global::Presentacion.Properties.Resources.maximize2;
            this.icnmax.Location = new System.Drawing.Point(1039, 3);
            this.icnmax.Name = "icnmax";
            this.icnmax.Size = new System.Drawing.Size(20, 20);
            this.icnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnmax.TabIndex = 4;
            this.icnmax.TabStop = false;
            this.icnmax.Click += new System.EventHandler(this.icnmax_Click);
            // 
            // icnmin
            // 
            this.icnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnmin.Image = global::Presentacion.Properties.Resources.minimize__1_;
            this.icnmin.Location = new System.Drawing.Point(1013, 3);
            this.icnmin.Name = "icnmin";
            this.icnmin.Size = new System.Drawing.Size(20, 20);
            this.icnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnmin.TabIndex = 4;
            this.icnmin.TabStop = false;
            this.icnmin.Click += new System.EventHandler(this.icnmin_Click);
            // 
            // icnrest
            // 
            this.icnrest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnrest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icnrest.Image = global::Presentacion.Properties.Resources.squares1;
            this.icnrest.Location = new System.Drawing.Point(1039, 3);
            this.icnrest.Name = "icnrest";
            this.icnrest.Size = new System.Drawing.Size(20, 20);
            this.icnrest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icnrest.TabIndex = 4;
            this.icnrest.TabStop = false;
            this.icnrest.Visible = false;
            this.icnrest.Click += new System.EventHandler(this.icnrest_Click);
            // 
            // icncerrar
            // 
            this.icncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icncerrar.Image = global::Presentacion.Properties.Resources.Cancel;
            this.icncerrar.Location = new System.Drawing.Point(1065, 3);
            this.icncerrar.Name = "icncerrar";
            this.icncerrar.Size = new System.Drawing.Size(20, 20);
            this.icncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icncerrar.TabIndex = 3;
            this.icncerrar.TabStop = false;
            this.icncerrar.Click += new System.EventHandler(this.icncerrar_Click);
            // 
            // ptbMenu
            // 
            this.ptbMenu.Image = global::Presentacion.Properties.Resources.Delicious;
            this.ptbMenu.Location = new System.Drawing.Point(6, 3);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(35, 35);
            this.ptbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMenu.TabIndex = 1;
            this.ptbMenu.TabStop = false;
            this.ptbMenu.Click += new System.EventHandler(this.ptbMenu_Click);
            // 
            // FrmIPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1088, 624);
            this.ControlBox = false;
            this.Controls.Add(this.pnelMenu);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MinimizeBox = false;
            this.Name = "FrmIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmIPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.FrmIPrincipal_SizeChanged);
            this.Resize += new System.EventHandler(this.FrmIPrincipal_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnelMenu.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            this.contUsuario.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlRegistrarU.ResumeLayout(false);
            this.pnlListarU.ResumeLayout(false);
            this.panelcliente.ResumeLayout(false);
            this.pContentPesupuesto.ResumeLayout(false);
            this.PMPresupuesto.ResumeLayout(false);
            this.pnlRpre.ResumeLayout(false);
            this.pnlLp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icnrest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private ReaLTaiizor.Controls.Panel panelhome;
        private FontAwesome.Sharp.IconButton btnUsuario;
        private ReaLTaiizor.Controls.Panel panelcliente;
        private System.Windows.Forms.FlowLayoutPanel contUsuario;
        private ReaLTaiizor.Controls.Panel pnlUser;
        private FontAwesome.Sharp.IconButton btnUs;
        private ReaLTaiizor.Controls.Panel pnlRegistrarU;
        private FontAwesome.Sharp.IconButton btnMr;
        private ReaLTaiizor.Controls.Panel pnlListarU;
        private FontAwesome.Sharp.IconButton btnML;
        private System.Windows.Forms.Timer menuTransicion;
        private System.Windows.Forms.Timer slidebarTrans;
        private System.Windows.Forms.PictureBox icncerrar;
        private System.Windows.Forms.PictureBox icnrest;
        private System.Windows.Forms.PictureBox icnmin;
        private System.Windows.Forms.PictureBox icnmax;
        private System.Windows.Forms.FlowLayoutPanel pContentPesupuesto;
        private ReaLTaiizor.Controls.Panel PMPresupuesto;
        private ReaLTaiizor.Controls.Panel pnlRpre;
        private FontAwesome.Sharp.IconButton btnRegistrarp;
        private ReaLTaiizor.Controls.Panel pnlLp;
        private FontAwesome.Sharp.IconButton btnListarp;
        private System.Windows.Forms.Timer Mpresupuesto;
        public FontAwesome.Sharp.IconButton Mdpresupuesto;
    }
}