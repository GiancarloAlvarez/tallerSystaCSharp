using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace TallerMecanico2.Controller
{
    internal class CDatosCliente
    {
        Model.Systa_taller1Entities db;

        public void Insert(Model.SYSTAS_CLIENTES Cliente)
        {
            using (db = new Model.Systa_taller1Entities())
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

        public List<Model.SYSTAS_CLIENTES> Read()
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
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
        public void update(Model.SYSTAS_CLIENTES Cliente) {

            try
            {
                using (db = new Model.Systa_taller1Entities())
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
    }

    }
