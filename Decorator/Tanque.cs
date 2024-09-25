using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Tanque.cs
    public class Tanque
    {
        public virtual string Descripcion()
        {
            return "Tanque de la Segunda Guerra Mundial";
        }

        public virtual double Costo()
        {
            return 10000; // Costo base del tanque
        }
    }


}
