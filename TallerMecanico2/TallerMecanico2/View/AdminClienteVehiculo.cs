using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico2.Model;
using TallerMecanico2.Controller;

namespace TallerMecanico2.View
{
    public partial class AdminClienteVehiculo : Form
    {
        CDatosCliente cliente = new CDatosCliente();
        CDatosVehiculo clienteVehiculo = new CDatosVehiculo();
        SYSTAS_CLIENTES clientes = new SYSTAS_CLIENTES();
        SYSTAS_VEHICULO clientesVehiculo = new SYSTAS_VEHICULO();
        public AdminClienteVehiculo()
        {
            InitializeComponent();
        }
        public void CargarGridClient()
        {
            var listC = cliente.Read();
            dgCliente.DataSource = listC;

        }

        public void CargarGridVehiculo()
        {
            var listV = clienteVehiculo.Read();
            dgVehiculo.DataSource = listV;

        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminClienteVehiculo_Load(object sender, EventArgs e)
        {
            CargarGridClient();
            CargarGridVehiculo();
        }
    }
}
