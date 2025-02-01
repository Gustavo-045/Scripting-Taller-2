using Facade;

class Program
{
    static void Main(string[] args)
    {
        ServicioReserva servicioReserva = new ServicioReserva();
        ServicioMusica servicioMusica = new ServicioMusica();
        ServicioMeseros servicioMeseros = new ServicioMeseros();

        ClubFacade clubBailarinas = new ClubFacade(servicioReserva, servicioMusica, servicioMeseros);

        // Organizar una noche de fiesta
        clubBailarinas.OrganizarNocheDeFiesta(5, "Música Generica", "Mesero1");

        // Terminar la noche de fiesta
        clubBailarinas.TerminarNocheDeFiesta(5, "Mesero1");
    }
}
