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
    internal class CDatosFactura
    {
        Systa_taller2Entities1 db;

        public void Insert(SYSTAS_FACTURA Factura)
        {
            using (db = new Systa_taller2Entities1())
            {
                try
                {
                    db.SYSTAS_FACTURA.Add(Factura);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }

        public List<SYSTAS_FACTURA> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_FACTURA.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }


        public void update(SYSTAS_FACTURA Factura)
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    db.Entry(Factura).State = EntityState.Modified;
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
                using (db = new Systa_taller2Entities1())
                {
                    db.SYSTAS_FACTURA.Remove(db.SYSTAS_FACTURA.Single(s => s.ID_Factura == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<SYSTAS_FACTURA> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_FACTURA.Where(s => s.ID_Factura == sID).ToList();
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
