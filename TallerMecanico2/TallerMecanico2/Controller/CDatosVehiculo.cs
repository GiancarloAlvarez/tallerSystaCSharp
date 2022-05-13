using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico2.Model;



namespace TallerMecanico2.Controller
{//Entity INFOTEP: Systa_taller2Entities4
 //Entity Casa2: Systa_taller2Entities1
 //Entity Casa: Systa_taller2Entities3

    internal class CDatosVehiculo
    {
        Systa_taller2Entities4 db;
        public void Insert(SYSTAS_VEHICULO Vehiculo)
        {
            using (db = new Systa_taller2Entities4())
            {
                
                
                    db.SYSTAS_VEHICULO.Add(Vehiculo);
                    db.SaveChanges();
                
                


            }

        }


        public List<SYSTAS_VEHICULO> Read()
        {

            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_VEHICULO.ToList();
                }
            
           



        }

        public void update(Model.SYSTAS_VEHICULO Vehiculo)
        {

            
            
                using (db = new Systa_taller2Entities4())
                {

                    db.Entry(Vehiculo).State = EntityState.Modified;
                    db.SaveChanges();
                }
            
            

        }

        public void Delete(int sID)
        {

            
            
                using (db = new Systa_taller2Entities4())
                {
                    db.SYSTAS_VEHICULO.Remove(db.SYSTAS_VEHICULO.Single(s => s.ID_Vehiculo == sID));
                    db.SaveChanges();

                }
           


        }

        public List<SYSTAS_VEHICULO> Search(int sID)
        {
            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_VEHICULO.Where(s => s.ID_Vehiculo == sID).ToList();
                }
            
            
            

        }

        public List<SYSTAS_VEHICULO> SearchName(String sName)
        {
            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_VEHICULO.Where(s => s.Marca.Contains(sName)).ToList();
                }
            
           
        }



    }
}
