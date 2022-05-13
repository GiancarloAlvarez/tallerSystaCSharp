using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico2.Model;



namespace TallerMecanico2.Controller
{//Entity INFOTEP: Systa_taller1Entities
 //Entity Casa: Systa_taller2Entities

    internal class CDatosVehiculo
    {   
        Systa_taller2Entities db;
        public void Insert(SYSTAS_VEHICULO Vehiculo)
        {
            using (db = new Systa_taller2Entities())
            {
                try
                {
                    db.SYSTAS_VEHICULO.Add(Vehiculo);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }


        public List<SYSTAS_VEHICULO> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities())
                {

                    return db.SYSTAS_VEHICULO.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(Model.SYSTAS_VEHICULO Vehiculo)
        {

            try
            {
                using (db = new Systa_taller2Entities())
                {

                    db.Entry(Vehiculo).State = EntityState.Modified;
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
                using (db = new Systa_taller2Entities())
                {
                    db.SYSTAS_VEHICULO.Remove(db.SYSTAS_VEHICULO.Single(s => s.ID_Vehiculo == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<SYSTAS_VEHICULO> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities())
                {

                    return db.SYSTAS_VEHICULO.Where(s => s.ID_Vehiculo == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<SYSTAS_VEHICULO> SearchName(String sName)
        {
            try
            {
                using (db = new Systa_taller2Entities())
                {

                    return db.SYSTAS_VEHICULO.Where(s => s.Marca.Contains(sName)).ToList();
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
