﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico2.Controller
{
    internal class CDatosMecanico
    {
        Model.Systa_taller1Entities db;

        public void Insert(Model.SYSTAS_MECANICO Mecanico)
        {
            using (db = new Model.Systa_taller1Entities())
            {
                try
                {
                    db.SYSTAS_MECANICO.Add(Mecanico);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }

        public List<Model.SYSTAS_MECANICO> Read()
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_MECANICO.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }


        public void update(Model.SYSTAS_MECANICO Mecanico)
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    db.Entry(Mecanico).State = EntityState.Modified;
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
                    db.SYSTAS_MECANICO.Remove(db.SYSTAS_MECANICO.Single(s => s.ID_Mecanico == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<Model.SYSTAS_MECANICO> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_MECANICO.Where(s => s.ID_Mecanico == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<Model.SYSTAS_MECANICO> SearchName(String sName)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_MECANICO.Where(s => s.nombre_mecanico.Contains(sName)).ToList();
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