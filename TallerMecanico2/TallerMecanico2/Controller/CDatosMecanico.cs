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
    //Entity Casa: Systa_taller2Entities

    internal class CDatosMecanico
    {
       Systa_taller2Entities4 db;

        public void Insert(SYSTAS_MECANICO Mecanico)
        {
            using (db = new Systa_taller2Entities4())
            {
                try
                {
                    db.SYSTAS_MECANICO.Add(Mecanico);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    

                }


            }


        }

        public List<SYSTAS_MECANICO> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_MECANICO.ToList();
                }
            }
            catch (Exception ex)
            {
               
                return null;
            }



        }


        public void update(SYSTAS_MECANICO Mecanico)
        {

            try
            {
                using (db = new Systa_taller2Entities4())
                {

                    db.Entry(Mecanico).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
               

            }

        }

        public void Delete(int sID)
        {

            try
            {
                using (db = new Systa_taller2Entities4())
                {
                    db.SYSTAS_MECANICO.Remove(db.SYSTAS_MECANICO.Single(s => s.ID_Mecanico == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                

            }


        }

        public List<SYSTAS_MECANICO> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_MECANICO.Where(s => s.ID_Mecanico == sID).ToList();
                }
            }
            catch (Exception ex)
            {
               
                return null;
            }

        }

        public List<Model.SYSTAS_MECANICO> SearchName(String sName)
        {
            try
            {
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_MECANICO.Where(s => s.nombre_mecanico.Contains(sName)).ToList();
                }
            }
            catch (Exception ex)
            {
                
                return null;
            }

        }

    }
}
