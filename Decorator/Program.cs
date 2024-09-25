// Program.cs
using Decorator;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un tanque básico
        Tanque tanque = new Tanque();
        Console.WriteLine($"{tanque.Descripcion()} - Costo: ${tanque.Costo()}");

        // Decorar el tanque con blindaje
        Tanque tanqueBlindado = new TanqueConBlindaje(tanque);
        Console.WriteLine($"{tanqueBlindado.Descripcion()} - Costo: ${tanqueBlindado.Costo()}");
    }
}
