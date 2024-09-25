using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // TanqueConBlindaje.cs
    public class TanqueConBlindaje : Tanque
    {
        private Tanque _tanque;

        public TanqueConBlindaje(Tanque tanque)
        {
            _tanque = tanque;
        }

        public override string Descripcion()
        {
            return _tanque.Descripcion() + ", con blindaje adicional";
        }

        public override double Costo()
        {
            return _tanque.Costo() + 5000; // Costo adicional por el blindaje
        }
    }


}
