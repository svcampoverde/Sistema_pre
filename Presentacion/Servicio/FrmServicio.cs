using LogicDeNegocio.Dtos;
using LogicDeNegocio.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VPaged.WF;

namespace Presentacion.Servicio
{
    public partial class FrmServicio : Form
    {
        private readonly IServicioService _servicioServices;
        private VPagination pagination;

        public FrmServicio(IServicioService servicioServices)
        {
            _servicioServices = servicioServices;
            InitializeComponent();
            InitializePagination().GetAwaiter().GetResult();
        }

        private async Task InitializePagination()
        {
            // Crear una instancia de VPagination y configurarla
            pagination = new VPagination(this);
            pagination.PageIndex = 1;
            pagination.PageSize = 15;
            pagination.SelectDataMaster = async () => await LoadDataAsync(); // Método para cargar datos
            pagination.SelectCountMaster = () => _servicioServices.GetTotalServicios(); // Método para obtener el total de registros
            pagination.VPagRunOrRefresh(); // Iniciar o refrescar la paginación
        }

        private async void FrmServicio_Load(object sender, EventArgs e)
        {
         
        }

        private async Task LoadDataAsync()
        {
            try
            {
                string search = materialTextBox1.Text.Trim();
                int pageIndex = pagination.PageIndex;
                int pageSize = pagination.PageSize;
                var result = await _servicioServices.GetServicioPaginate(search, pageIndex, pageSize);
                dataGridViewServicio.DataSource = result.Items;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            pagination.PageIndex = 1; // Resetear a la primera página al realizar una búsqueda
            LoadDataAsync().GetAwaiter().GetResult(); // Actualizar los datos
        }

        private void dataGridViewServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Aquí puedes manejar eventos en el DataGridView si es necesario
        }
        public void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
