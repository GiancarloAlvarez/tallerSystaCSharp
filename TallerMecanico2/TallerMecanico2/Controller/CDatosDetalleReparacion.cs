using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico2.Model;

namespace TallerMecanico2.Controller
{
    //Entity INFOTEP: Systa_taller1Entities
    //Entity Casa: Systa_taller2Entities2

    internal class CDatosDetalleReparacion
    {

        Systa_taller2Entities4 db;
        public void Insert(Model.SYSTAS_DETALLE_REPARACION DetalleReparacion)
        {
            using (db = new Model.Systa_taller2Entities4())
            {
                
                    db.SYSTAS_DETALLE_REPARACION.Add(DetalleReparacion);
                    db.SaveChanges();
                }
               


            }

        


        public List<Model.SYSTAS_DETALLE_REPARACION> Read()
        {

            
            
                using (db = new Model.Systa_taller2Entities4())
                {

                    return db.SYSTAS_DETALLE_REPARACION.ToList();
                }
        }
            


        

        public void update(Model.SYSTAS_DETALLE_REPARACION DetalleReparacion)
        {

            
            
                using (db = new Model.Systa_taller2Entities4())
                {

                    db.Entry(DetalleReparacion).State = EntityState.Modified;
                    db.SaveChanges();
                }
            
           

        }


        public void Delete(int sID)
        {

            
            
                using (db = new Model.Systa_taller2Entities4())
                {
                    db.SYSTAS_DETALLE_REPARACION.Remove(db.SYSTAS_DETALLE_REPARACION.Single(s => s.ID_Detalle == sID));
                    db.SaveChanges();

                }
            
            


        }

        public List<Model.SYSTAS_DETALLE_REPARACION> Search(int sID)
        {
            
            
                using (db = new Model.Systa_taller2Entities4())
                {

                    return db.SYSTAS_DETALLE_REPARACION.Where(s => s.ID_Detalle == sID).ToList();
                }
            
           

        }


    }
}
