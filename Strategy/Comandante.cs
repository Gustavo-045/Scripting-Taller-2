using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Comandante
    {
        private ITactica _tactica;

        public Comandante(ITactica tactica)
        {
            _tactica = tactica;
        }

        public void EstablecerTactica(ITactica tactica)
        {
            _tactica = tactica;
        }

        public void EjecutarOperacion()
        {
            _tactica.EjecutarTactica();
        }
    }

}
