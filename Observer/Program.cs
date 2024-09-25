using Observer;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia del dictador
        Dictador dictador = new Dictador();

        // Crear ciudadanos
        Citizen ciudadano1 = new Citizen("Juan");
        Citizen ciudadano2 = new Citizen("Maria");

        // Suscribir ciudadanos al dictador
        dictador.Subscribe(ciudadano1);
        dictador.Subscribe(ciudadano2);

        // Cambiar el mensaje y notificar a los ciudadanos
        dictador.ChangeMensaje("¡El dictador ha declarado la ley marcial!");

        // Un ciudadano se desuscribe
        dictador.Unsubscribe(ciudadano1);

        // Cambiar el mensaje nuevamente
        dictador.ChangeMensaje("¡El dictador ha impuesto nuevas restricciones!");


    }
}
