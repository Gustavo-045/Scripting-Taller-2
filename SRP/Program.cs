using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    // Program.cs
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Juan";
            Usuario usuario = new Usuario(nombre);
            usuario.CrearUsuario();

            Almacenamiento almacenamiento = new Almacenamiento();
            almacenamiento.GuardarUsuario(nombre);
        }
    }

}
