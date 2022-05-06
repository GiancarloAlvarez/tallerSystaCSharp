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

    internal class CDatosPiezas
    {
        Model.Systa_taller2Entities1 db;

        public void Insert(Model.SYSTAS_INVENTARIO_REPUESTO Piezas)
        {
            using (db = new Model.Systa_taller2Entities1())
            {
                try
                {
                    db.SYSTAS_INVENTARIO_REPUESTO.Add(Piezas);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }

        public List<Model.SYSTAS_INVENTARIO_REPUESTO> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(SYSTAS_INVENTARIO_REPUESTO Piezas)
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    db.Entry(Piezas).State = EntityState.Modified;
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
                    db.SYSTAS_INVENTARIO_REPUESTO.Remove(db.SYSTAS_INVENTARIO_REPUESTO.Single(s => s.ID_inventario == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<SYSTAS_INVENTARIO_REPUESTO> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.Where(s => s.ID_inventario == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<SYSTAS_INVENTARIO_REPUESTO> SearchName(String sName)
        {
            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_INVENTARIO_REPUESTO.Where(s => s.nombre_pieza.Contains(sName)).ToList();
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
