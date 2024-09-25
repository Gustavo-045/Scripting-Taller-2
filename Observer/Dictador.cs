using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Observer;

public class Dictador
{
    private List<IObserver> ciudadanos = new List<IObserver>();
    private string mensaje;

    // Método para agregar ciudadanos
    public void Subscribe(IObserver ciudadano)
    {
        ciudadanos.Add(ciudadano);
    }

    // Método para eliminar ciudadanos
    public void Unsubscribe(IObserver ciudadano)
    {
        ciudadanos.Remove(ciudadano);
    }

     public void Notify()
    {
        foreach (var ciudadano in ciudadanos)
        {
            ciudadano.Update(mensaje);
        }
    }

    // Método para cambiar el mensaje
    public void ChangeMensaje(string newMessage)
    {
        mensaje = newMessage;
        Notify(); // Notificar a todos los ciudadanos
    }

  
  
}
