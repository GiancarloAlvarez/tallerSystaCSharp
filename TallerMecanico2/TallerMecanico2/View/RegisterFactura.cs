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
    

    public partial class RegisterFactura : Form
    { CDatosFactura factura = new CDatosFactura();
      SYSTAS_FACTURA Factura = new SYSTAS_FACTURA();
        CListas CListas = new CListas();
        int id_Factura;
        DateTime fecha_factura;
       
        public void sServicio()
        {
            var List = CListas.ComboServicio();
            if (List.Count > 0)
            {

                cbServicio.DisplayMember = "nombre_servicio";
                cbServicio.ValueMember = "id_servicio";

                cbServicio.DataSource = List;

            }



        }

        public void SPiezas()
        {
            var list= CListas.ComboPieza();
            if (list.Count > 0)
            {
                cbPrecioPiezas.DisplayMember = "precio_pieza";
                cbPrecioPiezas.ValueMember = "ID_inventario";

                cbPrecioPiezas.DataSource= list;
            
            
            }
        
        
        }

        public void SPiezasN()
        {
            var listN = CListas.ComboPieza();
            if (listN.Count > 0)
            {
                cbPieza.DisplayMember = "nombre_pieza";
                cbPieza.ValueMember = "ID_inventario";

                cbPieza.DataSource = listN;


            }


        }

        public void SCostoS() {
            var listaC = CListas.ComboServicio();
            if (listaC.Count > 0)
            {
                CbCostoServicio.DisplayMember = "costo";
                CbCostoServicio.ValueMember = "id_servicio";

                CbCostoServicio.DataSource= listaC;


            }
        
        }

        public void CargarGridFactura() {
            var list = factura.Read();
            dgFactura.DataSource = list;
        
        }

        

        public RegisterFactura()
        {
            InitializeComponent();
        }

        public void CargarDatosFactura() {

            Factura.ID_Factura=  id_Factura;
            DateTime fecha_Fac = fechaDet.Value;
            Factura.Fecha_Factura = fecha_Fac;

            int cantidad_usada= int.Parse(tbCantidad.Text.ToString());
            Factura.cantidad_usada= cantidad_usada;


            Factura.servicio=cbServicio.Text;
            string combo = CbCostoServicio.SelectedValue.ToString();


            float costo_servicio = float.Parse(combo);
            Factura.costo_servicio=costo_servicio;


            float subtotal = float.Parse(tbSubtotal.Text.ToString());
            Factura.subtotal_piezas = subtotal;


            float total=float.Parse(tbTotal.Text.ToString());
            Factura.total=total;

            
        }

        public void Limpiar() {
             id_Factura= 0;
            CbCostoServicio.Text =String.Empty;
            tbSubtotal.Text = String.Empty;
            tbTotal.Text = String.Empty;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RegisterFactura_Load(object sender, EventArgs e)
        {
            
            
            
            
            SPiezasN();
            SPiezas();
            sServicio();
            CargarGridFactura();
            SCostoS();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            CargarDatosFactura();
            factura.Insert(Factura);
            CargarGridFactura();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            CargarDatosFactura();
            factura.update(Factura);
            CargarGridFactura();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            CargarGridFactura();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CargarDatosFactura();
            factura.Delete(Factura.ID_Factura);
            CargarGridFactura();
        }

        private void dgFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Factura = (int)Convert.ToInt64(dgFactura.CurrentRow.Cells[0].Value.ToString());
            fecha_factura=(DateTime)(dgFactura.CurrentRow.Cells[1].Value);
            cbServicio.Text = dgFactura.CurrentRow.Cells[9].Value.ToString();
            tbCantidad.Text= dgFactura.CurrentRow.Cells[8].Value.ToString();
            CbCostoServicio.Text =dgFactura.CurrentRow.Cells[10].Value.ToString();
            tbSubtotal.Text =dgFactura.CurrentRow.Cells[11].Value.ToString();
            tbTotal.Text =dgFactura.CurrentRow.Cells[12].Value.ToString();
            
            
        }
    }
}
