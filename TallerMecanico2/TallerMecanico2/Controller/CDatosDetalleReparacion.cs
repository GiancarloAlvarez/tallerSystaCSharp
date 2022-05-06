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

    internal class CDatosDetalleReparacion
    {

        Systa_taller2Entities1 db;
        public void Insert(Model.SYSTAS_DETALLE_REPARACION DetalleReparacion)
        {
            using (db = new Model.Systa_taller2Entities1())
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
                using (db = new Model.Systa_taller2Entities1())
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
                using (db = new Model.Systa_taller2Entities1())
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
                using (db = new Model.Systa_taller2Entities1())
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
                using (db = new Model.Systa_taller2Entities1())
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
