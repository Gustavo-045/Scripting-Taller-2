using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorDinosaurio : IPajaro
    {
        private Dinosaurio _dinosaurio;

        public AdaptadorDinosaurio(Dinosaurio dinosaurio)
        {
            _dinosaurio = dinosaurio;
        }

        public void Cantar()
        {
            _dinosaurio.Rugir();
        }
    }

}
