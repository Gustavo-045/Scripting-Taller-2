using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ClubFacade
    {
        private ServicioReserva _servicioReserva;
        private ServicioMusica _servicioMusica;
        private ServicioMeseros _servicioMeseros;

        public ClubFacade(ServicioReserva servicioReserva, ServicioMusica servicioMusica, ServicioMeseros servicioBailarinas)
        {
            _servicioReserva = servicioReserva;
            _servicioMusica = servicioMusica;
            _servicioMeseros = servicioBailarinas;
        }

        public void OrganizarNocheDeFiesta(int mesaNumero, string pista, string nombreMesero)
        {
            Console.WriteLine("Organizando una noche de fiesta en el club...");
            _servicioReserva.ReservarMesa(mesaNumero);
            _servicioMusica.IniciarMusica(pista);
            _servicioMeseros.LlamarMesero(nombreMesero);
        }

        public void TerminarNocheDeFiesta(int mesaNumero, string nombreMesero)
        {
            Console.WriteLine("Terminando la noche de fiesta en el club...");
            _servicioMeseros.DespedirMesero(nombreMesero);
            _servicioMusica.DetenerMusica();
            _servicioReserva.CancelarReserva(mesaNumero);
        }
    }

}
