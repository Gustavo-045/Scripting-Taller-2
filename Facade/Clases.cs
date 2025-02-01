using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ServicioReserva
    {
        public void ReservarMesa(int mesaNumero)
        {
            Console.WriteLine($"Mesa {mesaNumero} reservada.");
        }

        public void CancelarReserva(int mesaNumero)
        {
            Console.WriteLine($"Reserva de la mesa {mesaNumero} cancelada.");
        }
    }

    public class ServicioMusica
    {
        public void IniciarMusica(string pista)
        {
            Console.WriteLine($"Iniciando la música: {pista}");
        }

        public void DetenerMusica()
        {
            Console.WriteLine("Deteniendo la música.");
        }
    }

    public class ServicioMeseros
    {
        public void LlamarMesero(string nombre)
        {
            Console.WriteLine($"Llamando al mesero: {nombre}");
        }

        public void DespedirMesero(string nombre)
        {
            Console.WriteLine($"Despedir al mesero2: {nombre}");
        }
    }

}
