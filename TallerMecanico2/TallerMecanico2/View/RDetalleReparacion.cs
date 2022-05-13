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
    public partial class RDetalleReparacion : Form
    {
        CDatosDetalleReparacion reparacion = new CDatosDetalleReparacion();
        SYSTAS_DETALLE_REPARACION Reparacion = new SYSTAS_DETALLE_REPARACION();
        



        #region
        CDatosCliente cliente = new CDatosCliente();
        SYSTAS_CLIENTES Cliente = new SYSTAS_CLIENTES();

        CDatosMecanico mecanico = new CDatosMecanico();
        SYSTAS_MECANICO Mecanico = new SYSTAS_MECANICO();

        CDatosVehiculo vehiculo = new CDatosVehiculo();
        SYSTAS_VEHICULO Vehiculo = new SYSTAS_VEHICULO();

        CListas list = new CListas();


        #endregion
        int IdReparacion;
        DateTime fecha;
        double manoO;
        public void sMecanicos() {
            var Lista = list.ComboMecanico();
            if (Lista.Count > 0) {

                comboMec.DisplayMember = "nombre_mecanico";
                comboMec.ValueMember = "ID_mecanico";

                comboMec.DataSource = Lista;

            }
        
        
        
        }

        public void sPiezas()
        {
            var List = list.ComboPieza();
            if (List.Count > 0)
            {

                cbPiezas.DisplayMember = "nombre_pieza";
                cbPiezas.ValueMember = "ID_inventario";

                cbPiezas.DataSource = List;

            }



        }

        public void CargarGridReparacion() {
            var lista = reparacion.Read();
            dgDetalleRep.DataSource = lista;
        
        }

        public void CargarDatosReparacion() {
            Reparacion.ID_Detalle = IdReparacion;
            DateTime fecha_Fac = fechaDet.Value;

            Reparacion.Estado_Vehiculo = tDVehiculo.Text;
            Reparacion.fecha_registro= fecha;

            manoO= double.Parse(tManoO.Text.ToString());
            Reparacion.mano_obra = manoO;

            Reparacion.mecanico_asignado= comboMec.Text.ToString();
            float precio= float.Parse(tbCosto.Text.ToString());
            Reparacion.precio_piezas=precio;
        }

        public void Limpiar() {
            IdReparacion = 0;
            tDVehiculo.Text = String.Empty;
            cbPiezas.Text = String.Empty;
            tbCosto.Text = String.Empty;
            tManoO.Text = String.Empty;
            fechaDet.Text = String.Empty;


        }

        public RDetalleReparacion()
        {
            InitializeComponent();
        }

        private void RDetalleReparacion_Load(object sender, EventArgs e)
        {
            CargarGridReparacion();
            sMecanicos();
            sPiezas();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            CargarDatosReparacion();
            reparacion.Insert(Reparacion);
            CargarGridReparacion();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            CargarDatosReparacion();
            reparacion.update(Reparacion);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CargarDatosReparacion();
            reparacion.Delete(Reparacion.ID_Detalle);
        }

        private void dgDetalleRep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdReparacion = (int)Convert.ToInt64(dgDetalleRep.CurrentRow.Cells[0].Value.ToString());
            tDVehiculo.Text= dgDetalleRep.CurrentRow.Cells[1].Value.ToString();
            //cbPiezas.SelectedItem= dgDetalleRep.CurrentRow.Cells[2].Value.ToString();
            tbCosto.Text=dgDetalleRep.CurrentRow.Cells[5].Value.ToString();
            tManoO.Text=dgDetalleRep.CurrentRow.Cells[4].Value.ToString();
            //fechaDet=dgDetalleRep.CurrentRow.Cells[5].Value.ToString();
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            CargarGridReparacion();
        }

        private void dgDetalleRep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
