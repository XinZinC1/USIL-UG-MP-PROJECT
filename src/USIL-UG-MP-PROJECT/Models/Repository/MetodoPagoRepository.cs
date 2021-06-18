using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USIL_UG_MP_PROJECT.Models.Interface;

namespace USIL_UG_MP_PROJECT.Models.Repository
{
    public class MetodoPagoRepository : MetodoPagoInterface
    {
        KinemaContext db = new KinemaContext();

        public void Add(MetodoPago metodoPago)
        {
            try
            {
                db.MetodoPagos.Add(metodoPago);
                db.SaveChanges(); // Update DB records
            }

            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public IEnumerable<MetodoPago> GetAllMetodosPago()
        {
            return db.MetodoPagos;
        }
    }
}
