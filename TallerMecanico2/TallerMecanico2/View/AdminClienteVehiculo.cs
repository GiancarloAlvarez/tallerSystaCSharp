using System;
using System.Windows.Forms;
using TallerMecanico2.Controller;
using TallerMecanico2.Model;

namespace TallerMecanico2.View
{
    public partial class AdminClienteVehiculo : Form
    {
        CDatosCliente cliente = new CDatosCliente();
        CDatosVehiculo clienteVehiculo = new CDatosVehiculo();
        SYSTAS_CLIENTES clientes = new SYSTAS_CLIENTES();
        SYSTAS_VEHICULO clientesVehiculo = new SYSTAS_VEHICULO();
        public int idCliente;
        public int idClienteVehiculo;
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

        public void CargarDatosClient()
        {
            clientes.ID_Cliente = idClienteVehiculo;
            clientes.Nombre_Cliente = tbNombre.Text;
            clientes.Apellido_Cliente = tbApellido.Text;
            clientes.cedula = tbCedula.Text;
            clientes.Direccion = tbDireccion.Text;
           
            clientes.telefono_Cliente = txtTelefono.Text;



        }

        public void CargarDatosVehiculo()
        {
            clientesVehiculo.ID_Vehiculo = idClienteVehiculo;
            clientesVehiculo.Marca = tBMarca.Text;
            clientesVehiculo.Modelo = tBModelo.Text;
            clientesVehiculo.Matricula = tBMatricula.Text;
            clientesVehiculo.Color = tBColor.Text;
            clientesVehiculo.Cliente_id = idClienteVehiculo;
        }

        public void limpiar()
        {
            idClienteVehiculo = 0;
            tbNombre.Text = String.Empty;
            tbApellido.Text = String.Empty;
            tbCedula.Text = String.Empty;
            tbDireccion.Text = String.Empty;
            txtTelefono.Text = String.Empty;

        }
        public void limpiarVehiculo()
        {
            idClienteVehiculo = 0;
            tBMarca.Text = String.Empty;
            tBModelo.Text = String.Empty;
            tBMatricula.Text = String.Empty;
            tBColor.Text = String.Empty;


        }

        private void AdminClienteVehiculo_Load(object sender, EventArgs e)
        {
            CargarGridVehiculo();
            CargarGridClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarDatosClient();
            CargarDatosVehiculo();
            cliente.Insert(clientes);
            clienteVehiculo.Insert(clientesVehiculo);
            limpiar();
            limpiarVehiculo();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarGridVehiculo();
            CargarGridClient();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarVehiculo();
        }

        private void dgCliente_DoubleClick(object sender, EventArgs e)
        {
            idClienteVehiculo = int.Parse(dgCliente.CurrentRow.Cells[0].Value.ToString());
            tbNombre.Text = dgCliente.CurrentRow.Cells["Nombre_Cliente"].Value.ToString();
            tbApellido.Text = dgCliente.CurrentRow.Cells["Apellido_Cliente"].Value.ToString();
            tbCedula.Text = dgCliente.CurrentRow.Cells["cedula"].Value.ToString();
            tbDireccion.Text = dgCliente.CurrentRow.Cells["Direccion"].Value.ToString();
            txtTelefono.Text = dgCliente.CurrentRow.Cells["telefono_cliente"].Value.ToString();

        }

        private void dgVehiculo_DoubleClick(object sender, EventArgs e)
        {
            idClienteVehiculo = (int)Convert.ToInt64(dgVehiculo.CurrentRow.Cells["ID_Vehiculo"].Value.ToString());
            tBMarca.Text = dgVehiculo.CurrentRow.Cells["Marca"].Value.ToString();
            tBModelo.Text = dgVehiculo.CurrentRow.Cells["Modelo"].Value.ToString();
            tBMatricula.Text = dgVehiculo.CurrentRow.Cells["Matricula"].Value.ToString();
            tBColor.Text = dgVehiculo.CurrentRow.Cells["Color"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CargarDatosClient();
            CargarDatosVehiculo();
            cliente.update(clientes);
            clienteVehiculo.update(clientesVehiculo);
           
            limpiar();
            limpiarVehiculo();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            var lst = cliente.Search(Convert.ToInt32(txtBuscarId.Text));
            dgCliente.DataSource = lst;

            var lst2 = clienteVehiculo.Search(Convert.ToInt32(txtBuscarId.Text));
            dgVehiculo.DataSource = lst2;
        }

        private void txtBuscarN_TextChanged(object sender, EventArgs e)
        {
          
        }
    }



}
