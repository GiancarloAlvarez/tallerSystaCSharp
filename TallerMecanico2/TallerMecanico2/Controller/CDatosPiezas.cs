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

    internal class CDatosPiezas
    {
        Model.Systa_taller2Entities4 db;

        public void Insert(Model.SYSTAS_INVENTARIO_REPUESTO Piezas)
        {
            using (db = new Model.Systa_taller2Entities4())
            {
                try
                {
                    db.SYSTAS_INVENTARIO_REPUESTO.Add(Piezas);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    

                }


            }


        }

        public List<Model.SYSTAS_INVENTARIO_REPUESTO> Read()
        {

            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.ToList();
                }
            
            


        }

        public void update(SYSTAS_INVENTARIO_REPUESTO Piezas)
        {

            
            
                using (db = new Systa_taller2Entities4())
                {

                    db.Entry(Piezas).State = EntityState.Modified;
                    db.SaveChanges();
                }
            
            

        }

        public void Delete(int sID)
        {

            
            
                using (db = new Systa_taller2Entities4())
                {
                    db.SYSTAS_INVENTARIO_REPUESTO.Remove(db.SYSTAS_INVENTARIO_REPUESTO.Single(s => s.ID_inventario == sID));
                    db.SaveChanges();

                }
            
           


        }

        public List<SYSTAS_INVENTARIO_REPUESTO> Search(int sID)
        {
            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.Where(s => s.ID_inventario == sID).ToList();
                }
            
            

        }

        public List<SYSTAS_INVENTARIO_REPUESTO> SearchName(String sName)
        {
            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.Where(s => s.nombre_pieza.Contains(sName)).ToList();
                }
            
           

        }

    }
}
