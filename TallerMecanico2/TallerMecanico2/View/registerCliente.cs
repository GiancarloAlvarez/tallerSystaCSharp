using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico2.Controller;
using TallerMecanico2.Model;

namespace TallerMecanico2.View
{
    //esto solo registra a un cliente y su vehiculo, solo disponible para user Mecanico
    public partial class registerCliente : Form
    {    CDatosCliente cliente= new CDatosCliente();
        CDatosVehiculo clienteVehiculo= new CDatosVehiculo();
        SYSTAS_CLIENTES clientes= new SYSTAS_CLIENTES();
        SYSTAS_VEHICULO clientesVehiculo= new SYSTAS_VEHICULO();
        public int ID;
        public registerCliente()
        {
            InitializeComponent();
        }

        

        public void CargarDatosClient()
        {
            clientes.ID_Cliente = ID;
            clientes.Nombre_Cliente = txtClienteN.Text;
            clientes.Apellido_Cliente = txtClienteA.Text;
            clientes.cedula=txtClienteC.Text;
            clientes.Direccion = txtClienteD.Text;
           
            clientes.telefono_Cliente =txtTelefono.Text;


        }

        public void CargarDatosVehiculo() {
         clientesVehiculo.ID_Vehiculo= ID;
         clientesVehiculo.Marca= txtVehiculoM.Text;
         clientesVehiculo.Modelo= txtModelo.Text;
         clientesVehiculo.Matricula=txtVehiculoMa.Text;
         clientesVehiculo.Color=txtVehiculoC.Text;
        
        }

        private void btnClienteG_Click(object sender, EventArgs e)
        {
            CargarDatosClient();
            cliente.Insert(clientes);
        }

        private void btnVehiculoG_Click(object sender, EventArgs e)
        {
            CargarDatosVehiculo();
            clienteVehiculo.Insert(clientesVehiculo);
        }
    }
}
