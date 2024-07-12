using LogicDeNegocio;
using Presentacion.ModuloPresupuesto;
using Presentacion.ModuloUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Unity;

namespace Presentacion
{
    public partial class FrmIPrincipal : Form
    {
        private Form activarForm = null;
        private readonly Dictionary<Type, Form> activeForms = new Dictionary<Type, Form>();
        private readonly IUnityContainer _container;

        public FrmIPrincipal(IUnityContainer container)
        {
            InitializeComponent();
            _container = container;
            mdiPro();
            // Establecer las propiedades del formulario
            this.FormBorderStyle = FormBorderStyle.Sizable; // Asegura que el formulario sea redimensionable
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Establece el área de trabajo disponible sin la barra de tareas

            // Agregar el evento Resize
            this.Resize += new EventHandler(FrmIPrincipal_Resize);
            this.SizeChanged += FrmIPrincipal_SizeChanged;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        bool expandir = false;
        private void mdiPro()
        {
            this.setBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(39, 51, 63); // Color de fondo del MdiClient
        }

        private void menuTransicion_Tick(object sender, EventArgs e)
        {
            if (expandir == false)
            {
                contUsuario.Height += 10;
                if (contUsuario.Height >= 241)
                {
                    menuTransicion.Stop();
                    expandir = true;
                }
            }
            else
            {
                contUsuario.Height -= 10;
                if (contUsuario.Height <= 62)
                {
                    menuTransicion.Stop();
                    expandir = false;
                }
            }
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            menuTransicion.Start();
        }

        private void Mpresupuesto_Tick(object sender, EventArgs e)
        {
            if (expandir == false)
            {
                pContentPesupuesto.Height += 10;
                if (pContentPesupuesto.Height >= 241)
                {
                    Mpresupuesto.Stop();
                    expandir = true;
                }
            }
            else
            {
                pContentPesupuesto.Height -= 10;
                if (pContentPesupuesto.Height <= 62)
                {
                    Mpresupuesto.Stop();
                    expandir = false;
                }
            }
        }

        private void Mdpresupuesto_Click(object sender, EventArgs e)
        {
            Mpresupuesto.Start();
        }

        bool expandirslider = true;
        private void slidebarTrans_Tick(object sender, EventArgs e)
        {
            if (expandirslider)
            {
                pnelMenu.Width -= 18;
                if (pnelMenu.Width <= 72)
                {
                    expandirslider = false;
                    slidebarTrans.Stop();
                    AdjustMenuControls();
                }
            }
            else
            {
                pnelMenu.Width += 18;
                if (pnelMenu.Width >= 197)
                {
                    expandirslider = true;
                    slidebarTrans.Stop();
                    AdjustMenuControls();
                }
            }
        }

        private void AdjustMenuControls()
        {
            foreach (Control control in pnelMenu.Controls)
            {
                control.Width = pnelMenu.Width - control.Margin.Left - control.Margin.Right;
                control.Invalidate(); // Redibuja el control para reflejar el nuevo tamaño
            }
        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {
            slidebarTrans.Start();
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        public void OpenChildForm<T>(Action<T> configureForm = null, Point? location = null, Size? size = null) where T : Form
        {
            // Cerrar el formulario activo actual si existe
            if (activarForm != null)
            {
                activarForm.Close();
            }

            // Crear una nueva instancia del formulario si no está activa
            if (!activeForms.ContainsKey(typeof(T)))
            {
                var form = _container.Resolve<T>();
                activeForms[typeof(T)] = form;
                form.MdiParent = this;
                form.FormClosed += (sender, e) => activeForms.Remove(typeof(T));
            }

            // Activar el formulario y configurarlo si se especifica
            activarForm = activeForms[typeof(T)];
            configureForm?.Invoke((T)activarForm);
            // Ajustar la posición y el tamaño personalizado del formulario hijo si se especifican
            if (location.HasValue)
            {
                activarForm.Location = location.Value;
            }
            if (size.HasValue)
            {
                activarForm.Size = size.Value;
            }
            // Obtener el tamaño y la ubicación de los paneles
            int leftPanelWidth = pnelMenu.Width;
            int topPanelHeight = panelHeader.Height;

            // Ajustar el formulario hijo para que no se superponga con los paneles
            activarForm.Location = new Point(leftPanelWidth, topPanelHeight);
            activarForm.Size = new Size(this.ClientSize.Width - leftPanelWidth, this.ClientSize.Height - topPanelHeight);

            activarForm.FormBorderStyle = FormBorderStyle.None;
            activarForm.ControlBox = false;
            activarForm.MinimizeBox = false;
            activarForm.MaximizeBox = false;
            activarForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {

            OpenChildForm<Home>();
        }

        private void btnMr_Click(object sender, EventArgs e)
        {
            // Resuelve la instancia de FrmRegistrarUsuario usando Unity
            OpenChildForm<FrmRegistrarUsuario>();
        }

        private void btnML_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmBuscarUsuario>();
        }

        private void btnRegistrarp_Click(object sender, EventArgs e)
        {
            OpenChildForm<FrmRegistrarPresupuesto>();
        }

        private void FrmIPrincipal_SizeChanged(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    AdjustMdiSize(childForm);
                }
            }
        }

        private void AdjustMdiSize(Form childForm)
        {
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;

            if (this.WindowState == FormWindowState.Maximized)
            {
                childForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Restablecer el estado del formulario secundario
                childForm.WindowState = FormWindowState.Normal;
                this.ClientSize = new Size(this.ClientSize.Width + 20, ClientSize.Height + 50);
            }
            PositionMdiChild(childForm);
        }

        private void PositionMdiChild(Form childForm)
        {
            // Asegurar que el formulario secundario no esté maximizado antes de calcular la posición
            childForm.WindowState = FormWindowState.Normal;

            // Establecer la posición del formulario secundario
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(80, 10);
        }

        private void FrmIPrincipal_Load(object sender, EventArgs e)
        {
            // Inicialización adicional si es necesario
        }

        private void icncerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void icnmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icnrest.Visible = true;
            icnmax.Visible = false;
        }

        private void icnrest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icnrest.Visible = false;
            icnmax.Visible = true;
        }

        private void icnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmIPrincipal_Resize(object sender, EventArgs e)
        {
            // Verificar si el formulario está maximizado
            if (this.WindowState == FormWindowState.Maximized)
            {
                // Ajustar el tamaño del formulario para que no cubra la barra de tareas
                this.MaximumSize = Screen.FromHandle(this.Handle).WorkingArea.Size;
            }
            else
            {
                // Restablecer el tamaño máximo cuando el formulario no está maximizado
                this.MaximumSize = new Size(0, 0);
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            // Implementación para el botón Usuario si es necesario
        }
    }
}
