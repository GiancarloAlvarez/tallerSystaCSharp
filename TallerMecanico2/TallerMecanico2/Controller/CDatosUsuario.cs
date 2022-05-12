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

    internal class CDatosUsuario
    {

        Model.Systa_taller1Entities db;
        public void Insert(Model.SYSTAS_USUARIO Usuario)
        {
            using (db = new Model.Systa_taller1Entities())
            {
                try
                {
                    db.SYSTAS_USUARIO.Add(Usuario);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }


            }

        }


        public List<Model.SYSTAS_USUARIO> Read()
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_USUARIO.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }



        }

        public void update(Model.SYSTAS_USUARIO Usuario)
        {

            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    db.Entry(Usuario).State = EntityState.Modified;
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
                    db.SYSTAS_USUARIO.Remove(db.SYSTAS_USUARIO.Single(s => s.ID_Usuario == sID));
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        public List<Model.SYSTAS_USUARIO> Search(int sID)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_USUARIO.Where(s => s.ID_Usuario == sID).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public List<Model.SYSTAS_USUARIO> SearchName(String sName)
        {
            try
            {
                using (db = new Model.Systa_taller1Entities())
                {

                    return db.SYSTAS_USUARIO.Where(s => s.nombre_usuario.Contains(sName)).ToList();
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
