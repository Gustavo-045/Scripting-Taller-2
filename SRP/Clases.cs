using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // Usuario.cs
    public class Usuario
    {
        public string Nombre { get; private set; }

        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void CrearUsuario()
        {
            Console.WriteLine($"Usuario {Nombre} creado.");
        }
    }

    // Almacenamiento.cs
    public class Almacenamiento
    {
        public void GuardarUsuario(string nombre)
        {
            Console.WriteLine($"Usuario {nombre} guardado en archivo.");
        }
    }

}

