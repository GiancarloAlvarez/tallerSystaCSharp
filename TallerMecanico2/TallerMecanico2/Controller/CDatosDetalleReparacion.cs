using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico2.Controller
{
    internal class CDatosDetalleReparacion
    {

        Model.Systa_taller1Entities db;
        public void Insert(Model.SYSTAS_DETALLE_REPARACION DetalleReparacion)
        {
            using (db = new Model.Systa_taller1Entities())
            {
                try
                {
                    db.SYSTAS_DETALLE_REPARACION.Add(DetalleReparacion);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }


        public List<Model.SYSTAS_DETALLE_REPARACION> Read()
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_DETALLE_REPARACION.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(Model.SYSTAS_DETALLE_REPARACION DetalleReparacion)
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    db.Entry(DetalleReparacion).State = EntityState.Modified;
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
                    db.SYSTAS_DETALLE_REPARACION.Remove(db.SYSTAS_DETALLE_REPARACION.Single(s => s.ID_Detalle == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<Model.SYSTAS_DETALLE_REPARACION> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_DETALLE_REPARACION.Where(s => s.ID_Detalle == sID).ToList();
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
