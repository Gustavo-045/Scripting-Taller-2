using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Citizen: IObserver
    {
        private string nombre;

        public Citizen(string nombre)
        {
            this.nombre = nombre;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{nombre} ha recibido la notificación: {message}");
        }
    }
}
