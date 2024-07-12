using LogicDeNegocio.Interfaces;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Windows.Forms;

namespace Presentacion.ModuloEmpleado
{
    public partial class FrmEmpleado : Form
    {
        private readonly IEmpleadoService _empleadoService;
        public FrmEmpleado(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
            InitializeComponent();
        }

        private async void LlenarDataGrid()
        {

        }

    }
}
