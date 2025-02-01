using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TacticaGuerraDeGuerillas : ITactica
    {
        public void EjecutarTactica()
        {
            Console.WriteLine("Usando tácticas de guerra de guerrillas: ataques rápidos y sorpresivos.");
        }
    }

    public class TacticaOfensivaConvencional : ITactica
    {
        public void EjecutarTactica()
        {
            Console.WriteLine("Usando tácticas ofensivas convencionales: bombardeos y asaltos directos.");
        }
    }

    public class TacticaDefensiva : ITactica
    {
        public void EjecutarTactica()
        {
            Console.WriteLine("Usando tácticas defensivas: fortificaciones y emboscadas.");
        }
    }

}
