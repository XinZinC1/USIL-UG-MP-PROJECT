using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USIL_UG_MP_PROJECT.Models.Interface;

namespace USIL_UG_MP_PROJECT.Models.Repository
{
    public class UbicacionRepository : UbicacionInterface
    {
        KinemaContext db = new KinemaContext();
        public void Add(Ubicacion ubicacion)
        {
            try
            {
                db.Ubicacions.Add(ubicacion);
                db.SaveChanges(); // Update DB records
            }

            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        public Ubicacion Edit(int code)
        {
            throw new NotImplementedException();
        }

        public void EditDetails(Ubicacion ubicacion)
        {
            try
            {
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public IEnumerable<Ubicacion> GetAllUbicaciones()
        {
            return db.Ubicacions;
        }

        public void Remove(int code)
        {
            throw new NotImplementedException();
        }
    }
}
