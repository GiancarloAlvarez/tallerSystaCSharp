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
    public partial class RegisterServicio : Form
    {
        public RegisterServicio()
        {
            InitializeComponent();
        }
        int ServicioId;
        CDatosServicio servicio = new CDatosServicio();
        SYSTAS_SERVICIO Servicios = new SYSTAS_SERVICIO();


        public void CargarGridServicios() {
            var Lista = servicio.Read();
            dgServicio.DataSource = Lista;
        
        
        }

        public void CargarDatosServicio() {
            Servicios.id_servicio = ServicioId;
            Servicios.nombre_servicio = tbNombreS.Text;
            Servicios.tipo_servicio = tbTipo.Text;
            float ServiciosCosto = float.Parse(tbCostoS.Text.ToString());
            Servicios.costo = ServiciosCosto;


        }
        public void limpiar() {
            ServicioId=0;
             tbNombreS.Text= String.Empty;
            tbTipo.Text= string.Empty;
            tbCostoS.Text= String.Empty;
           


        }

        
        private void RegisterServicio_Load(object sender, EventArgs e)
        {
            CargarGridServicios();
        }

        private void dgServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgServicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ServicioId= (int)Convert.ToInt64(dgServicio.CurrentRow.Cells[0].Value.ToString());
            tbNombreS.Text = dgServicio.CurrentRow.Cells[1].Value.ToString();
            tbTipo.Text = dgServicio.CurrentRow.Cells[2].Value.ToString();
            tbCostoS.Text = dgServicio.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnServicioG_Click(object sender, EventArgs e)
        {
            
                CargarDatosServicio();
                servicio.Insert(Servicios);
                limpiar();
                CargarGridServicios();
            

        }

        private void btnServicioE_Click(object sender, EventArgs e)
        {
            CargarDatosServicio();
            servicio.update(Servicios);
            limpiar();
            CargarGridServicios();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarGridServicios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnSD_Click(object sender, EventArgs e)
        {
            CargarDatosServicio();
            servicio.Delete(Servicios.id_servicio);
            limpiar();
            CargarGridServicios();
        }
    }
}
