using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMecanico2.Model;

namespace TallerMecanico2.Controller
{
    
    class CListas
    {
        /// <summary>
        /// Entity de Infotep: Systa_taller2Entities3
        /// Entity de casa: Systa_taller2Entities4
        /// </summary>

        Systa_taller2Entities4 db;
        public List<SYSTAS_MECANICO> ComboMecanico() {
            using ( db = new Systa_taller2Entities4()){
                
                
               return db.SYSTAS_MECANICO.ToList();
            }

                


            }

        public List<SYSTAS_INVENTARIO_REPUESTO> ComboPieza()
        {
            using (db = new Systa_taller2Entities4())
            {

                return db.SYSTAS_INVENTARIO_REPUESTO.ToList();


            }


        }

        public List<SYSTAS_VEHICULO> ComboVehiculo()
        {
            using (db = new Systa_taller2Entities4())
            {

                return db.SYSTAS_VEHICULO.ToList();


            }


        }
        public List<SYSTAS_CLIENTES> ComboClientes()
        {
            using (db = new Systa_taller2Entities4())
            {

                return db.SYSTAS_CLIENTES.ToList();


            }


        }



        public List<SYSTAS_SERVICIO> ComboServicio()
        {
            using (db = new Systa_taller2Entities4())
            {

                return db.SYSTAS_SERVICIO.ToList();


            }


        }

    }



}

