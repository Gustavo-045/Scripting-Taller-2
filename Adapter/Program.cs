using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinosaurio dino = new Dinosaurio();
            IPajaro pajaroAdaptado = new AdaptadorDinosaurio(dino);

            // El dinosaurio puede "cantar" (rugir) a través del adaptador
            pajaroAdaptado.Cantar(); // Salida: ¡Ruuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu!
        }
    }
}

