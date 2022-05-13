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
    //Entity Casa: Systa_taller2Entities2
    internal class CDatosFactura
    {
        Systa_taller2Entities4 db;

        public void Insert(SYSTAS_FACTURA Factura)
        {
            using (db = new Systa_taller2Entities4())
            {
                
                
                    db.SYSTAS_FACTURA.Add(Factura);
                    db.SaveChanges();
                
                


            }


        }

        public List<SYSTAS_FACTURA> Read()
        {

            
            
                using (db = new Systa_taller2Entities4())
                {

                    return db.SYSTAS_FACTURA.ToList();
                }
            
           



        }

       /* public List<SYSTAS_FACTURA> Read2() {

            using (db = new Systa_taller2Entities3())
            {
                int sID = 0;
                 var consulta = (from factura in db.SYSTAS_FACTURA
                                where factura.ID_Factura == sID
                                select new
                                {

                                    factura.ID_Factura,
                                    factura.Fecha_Factura,
                                    factura.cantidad_usada,
                                    factura.costo_servicio,
                                    factura.servicio,
                                    factura.subtotal_piezas,
                                    factura.total,

                                }).ToList();

                return consulta.ToList;
            }
            


        }
       */
       


        public void update(SYSTAS_FACTURA Factura)
        {

            
                using (db = new Systa_taller2Entities4())
                {

                    db.Entry(Factura).State = EntityState.Modified;
                    db.SaveChanges();
                }
            
            

        }

        public void Delete(int sID)
        {

            
           
                using (db = new Systa_taller2Entities4())
                {
                    db.SYSTAS_FACTURA.Remove(db.SYSTAS_FACTURA.Single(s => s.ID_Factura == sID));
                    db.SaveChanges();

                }
            
           


        }

        public List<SYSTAS_FACTURA> Search(int sID)
        {
            
            
                using (db = new Systa_taller2Entities4())
                {
                   

                    return db.SYSTAS_FACTURA.Where(s => s.ID_Factura == sID).ToList();
                }
            
            

        }

      

    }
}
