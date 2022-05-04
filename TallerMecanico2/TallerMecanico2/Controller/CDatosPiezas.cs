﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico2.Controller
{
    internal class CDatosPiezas
    {
        Model.Systa_taller1Entities db;

        public void Insert(Model.SYSTAS_INVENTARIO_REPUESTO Piezas)
        {
            using (db = new Model.Systa_taller1Entities())
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
                using (db = new Model.Systa_taller1Entities())
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

        public void update(Model.SYSTAS_INVENTARIO_REPUESTO Piezas)
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
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
                using (db = new Model.Systa_taller1Entities())
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

        public List<Model.SYSTAS_INVENTARIO_REPUESTO> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
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

        public List<Model.SYSTAS_INVENTARIO_REPUESTO> SearchName(String sName)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
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