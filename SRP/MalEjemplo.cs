using System;
public class MalEjemplo
{
    public void CrearUsuario(string nombre)
    {
        // Lógica para crear un usuario
        Console.WriteLine($"Usuario {nombre} creado.");

        // Lógica para guardar el usuario en un archivo
        GuardarUsuarioEnArchivo(nombre);
    }

    private void GuardarUsuarioEnArchivo(string nombre)
    {
        Console.WriteLine($"Usuario {nombre} guardado en archivo.");
    }
}
