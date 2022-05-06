﻿using System;
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

    internal class CDatosServicio
    {

        Model.Systa_taller2Entities1 db;
        public void Insert(Model.SYSTAS_SERVICIO Servicio)
        {
            using (db = new Model.Systa_taller2Entities1())
            {
                try
                {
                    db.SYSTAS_SERVICIO.Add(Servicio);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }


        public List<Model.SYSTAS_SERVICIO> Read()
        {

            try
            {
                using (db = new Model.Systa_taller2Entities1())
                {

                    return db.SYSTAS_SERVICIO.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(Model.SYSTAS_SERVICIO Servicio)
        {

            try
            {
                using (db = new Model.Systa_taller2Entities1())
                {

                    db.Entry(Servicio).State = EntityState.Modified;
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
                    db.SYSTAS_SERVICIO.Remove(db.SYSTAS_SERVICIO.Single(s => s.id_servicio == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<Model.SYSTAS_SERVICIO> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller2Entities1())
                {

                    return db.SYSTAS_SERVICIO.Where(s => s.id_servicio == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<Model.SYSTAS_SERVICIO> SearchName(String sName)
        {
            try
            {
                using (db = new Model.Systa_taller2Entities1())
                {

                    return db.SYSTAS_SERVICIO.Where(s => s.nombre_servicio.Contains(sName)).ToList();
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
