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
    public partial class AdminRPiezas : Form
    {
        int idInventario;
        CDatosPiezas piezas= new CDatosPiezas();
        SYSTAS_INVENTARIO_REPUESTO inventario_Piezas = new SYSTAS_INVENTARIO_REPUESTO();
        
        public AdminRPiezas()
        {
            InitializeComponent();
        }

        public void CargarGridPiezas()
        {
            var listV = piezas.Read();
            dgPiezas.DataSource = listV;

        }
        public void CargarDatosPiezas()
        {
           inventario_Piezas.ID_inventario= idInventario;
           inventario_Piezas.nombre_pieza = txtPNombre.Text;
           int cantidad = int.Parse(nTCantidad.Value.ToString());
           inventario_Piezas.cantidad_pieza = cantidad;
           float precio= float.Parse(tbPrecio.Text.ToString());
           inventario_Piezas.precio_pieza= precio;
            int estado = int.Parse(nEstadoN.Value.ToString());
            if (estado == 0)
            {
                int estado1 = 1;
                //bool e = bool.Parse(estado.ToString());
                //bool e1 = bool.Parse(estado1.ToString());

                inventario_Piezas.pieza_nueva = false;
                inventario_Piezas.pieza_usada = true;


            }
            else if (estado == 1) {
               int estado1 = 0;
                //bool e = bool.Parse(estado.ToString());
                //bool e1 = bool.Parse(estado1.ToString());

                inventario_Piezas.pieza_nueva = true;
                inventario_Piezas.pieza_usada = false;

            }


           
        }
        public void limpiarPiezas()
        {
            idInventario = 0;
            txtPNombre.Text = String.Empty;
            nTCantidad.Text = String.Empty;
            tbPrecio.Text = String.Empty;
            



        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
        }
        private void AdminRPiezas_Load(object sender, EventArgs e)
        {
            CargarGridPiezas();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

            CargarDatosPiezas();

            piezas.update(inventario_Piezas);

            limpiarPiezas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPiezas();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarGridPiezas();
        }

        private void dgPiezas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idInventario = (int)Convert.ToInt64(dgPiezas.CurrentRow.Cells["ID_Inventario"].Value.ToString());
            txtPNombre.Text = dgPiezas.CurrentRow.Cells["nombre_pieza"].Value.ToString();
            nTCantidad.Text =dgPiezas.CurrentRow.Cells["cantidad_pieza"].Value.ToString();
            tbPrecio.Text = dgPiezas.CurrentRow.Cells["precio_pieza"].Value.ToString();
            nEstadoN.Text = dgPiezas.CurrentRow.Cells["pieza_nueva"].Value.ToString();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var lst = piezas.Search(Convert.ToInt32(tBuscarId.Text));
            dgPiezas.DataSource = lst;
        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CargarDatosPiezas();

            piezas.Insert(inventario_Piezas);

            limpiarPiezas();
        }
    }
}
