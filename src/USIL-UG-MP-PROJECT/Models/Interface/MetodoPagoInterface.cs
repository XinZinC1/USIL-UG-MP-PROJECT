using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USIL_UG_MP_PROJECT.Models.Interface
{
    public interface MetodoPagoInterface
    {
        IEnumerable<MetodoPago> GetAllMetodosPago();
        void Add(MetodoPago metodoPago);
    }
}
