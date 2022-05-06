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
        CDatosMecanico mecanico = new CDatosMecanico();
        SYSTAS_MECANICO mecanicos = new SYSTAS_MECANICO();


        public registerMecanico()
        {
            InitializeComponent();


        }
        public void CargarDatosClient()
        {
           

        }

    }
}
