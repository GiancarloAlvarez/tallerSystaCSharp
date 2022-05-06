﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using TallerMecanico2.Model;
namespace TallerMecanico2.Controller
{
    internal class CDatosCliente
    {   //Entity INFOTEP: Systa_taller1Entities
        //Entity Casa2: Systa_taller2Entities1
        //Entity Casa: Systa_taller2Entities
        Systa_taller2Entities1 db;
        SYSTAS_CLIENTES cliente = new SYSTAS_CLIENTES();
        SYSTAS_VEHICULO vehiculo = new SYSTAS_VEHICULO();
            
        public void Insert(SYSTAS_CLIENTES Cliente)
        {

            using (db = new Systa_taller2Entities1())
            {
                try
                {
                    db.SYSTAS_CLIENTES.Add(Cliente);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }


        }

        public List<SYSTAS_CLIENTES> Read()
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_CLIENTES.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }


        public void update(SYSTAS_CLIENTES Cliente)
        {

            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    db.Entry(Cliente).State = EntityState.Modified;
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
                    db.SYSTAS_CLIENTES.Remove(db.SYSTAS_CLIENTES.Single(s => s.ID_Cliente == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        internal static void Insert()
        {
            throw new NotImplementedException();
        }

        public List<SYSTAS_CLIENTES> Search(int sID)
        {
            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_CLIENTES.Where(s => s.ID_Cliente == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<SYSTAS_CLIENTES> SearchName(String sName)
        {
            try
            {
                using (db = new Systa_taller2Entities1())
                {

                    return db.SYSTAS_CLIENTES.Where(s => s.Nombre_Cliente.Contains(sName)).ToList();
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
