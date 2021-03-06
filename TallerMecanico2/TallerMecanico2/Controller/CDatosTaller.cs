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
    //Entity Casa: Systa_taller1Entities2

    internal class CDatosTaller
    {

        Systa_taller2Entities3 db;
        public void Insert(Model.SYSTAS_TALLER Taller)
        {
            using (db = new Systa_taller2Entities3())
            {
                try
                {
                    db.SYSTAS_TALLER.Add(Taller);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }


        public List<SYSTAS_TALLER> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities3())
                {

                    return db.SYSTAS_TALLER.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(SYSTAS_TALLER Taller)
        {

            try
            {
                using (db = new Systa_taller2Entities3())
                {

                    db.Entry(Taller).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        public void Delete(int sID)
        {

            try
            {
                using (db = new Systa_taller2Entities3())
                {
                    db.SYSTAS_TALLER.Remove(db.SYSTAS_TALLER.Single(s => s.ID_taller == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<SYSTAS_TALLER> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities3())
                {

                    return db.SYSTAS_TALLER.Where(s => s.ID_taller == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<SYSTAS_TALLER> SearchName(String sName)
        {
            try
            {
                using (db = new Systa_taller2Entities3())
                {

                    return db.SYSTAS_TALLER.Where(s => s.Nombre_taller.Contains(sName)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

    }
}
