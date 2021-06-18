using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USIL_UG_MP_PROJECT.Models.Interface
{
    public interface UbicacionInterface
    {
        IEnumerable<Ubicacion> GetAllUbicaciones();
        void Add(Ubicacion ubicacion);
        void Remove(int code);
        Ubicacion Edit(int code);
        void EditDetails(Ubicacion ubicacion);
    }
}
