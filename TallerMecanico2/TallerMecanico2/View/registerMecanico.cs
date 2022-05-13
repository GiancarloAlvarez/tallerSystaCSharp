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

    public partial class registerMecanico : Form
    {
        int mecanicoID;
        CDatosMecanico mecanico = new CDatosMecanico();
        SYSTAS_MECANICO mecanicos = new SYSTAS_MECANICO();


        public registerMecanico()
        {
            InitializeComponent();


        }
        public void CargarDatosMecanico()
        {
            mecanicos.ID_Mecanico = mecanicoID;
            mecanicos.nombre_mecanico = txtMecanicoN.Text;
            mecanicos.apellido_mecanico = txtMecanicoA.Text;
            mecanicos.cedula_mecanico = txtMecanicoC.Text;
            mecanicos.fecha_nac = txtFecha.Text;

        }
        public void CargarGridMecanico() {
            var lista = mecanico.Read();
            dgMecanico.DataSource = lista;
        
        }
          public void  limpiar() 
            {
            mecanicoID = 0; ;
            txtMecanicoN.Text= String.Empty;
           txtMecanicoA.Text=String.Empty;
           txtMecanicoC.Text=String.Empty;
            txtFecha.Text=String.Empty;

        }

        private void registerMecanico_Load(object sender, EventArgs e)
        {
            CargarGridMecanico();
        }

        private void btnMecaG_Click(object sender, EventArgs e)
        {
            CargarDatosMecanico();
            mecanico.Insert(mecanicos);
            CargarGridMecanico();

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void btnMecaS_Click(object sender, EventArgs e)
        {
            CargarGridMecanico();
        }

        private void dgMecanico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mecanicoID = (int)Convert.ToInt64(dgMecanico.CurrentRow.Cells[0].Value.ToString());
            txtMecanicoN.Text = dgMecanico.CurrentRow.Cells[1].Value.ToString();
            txtMecanicoA.Text = dgMecanico.CurrentRow.Cells[2].Value.ToString();
            txtMecanicoC.Text = dgMecanico.CurrentRow.Cells[3].Value.ToString();
            txtFecha.Text = dgMecanico.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnMecaE_Click(object sender, EventArgs e)
        {
            CargarDatosMecanico();
            mecanico.update(mecanicos);
            limpiar();
        }

        private void btnMecaD_Click(object sender, EventArgs e)
        {
            CargarDatosMecanico();
            mecanico.Delete(mecanicos.ID_Mecanico);
            limpiar();
        }
    }
}
