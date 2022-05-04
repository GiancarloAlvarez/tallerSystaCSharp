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

        public void CargarGrid() {
            
        
        }
    }
}
