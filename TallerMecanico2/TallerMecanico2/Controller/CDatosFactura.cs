using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico2.Controller
{
    //Entity INFOTEP: Systa_taller1Entities
    //Entity Casa: Systa_taller1Entities2
    internal class CDatosFactura
    {
        Model.Systa_taller1Entities db;

        public void Insert(Model.SYSTAS_FACTURA Factura)
        {
            using (db = new Model.Systa_taller1Entities())
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

        public List<Model.SYSTAS_FACTURA> Read()
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
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


        public void update(Model.SYSTAS_FACTURA Factura)
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
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
                using (db = new Model.Systa_taller1Entities())
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

        public List<Model.SYSTAS_FACTURA> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
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
