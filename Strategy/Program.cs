using Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Crear el comandante con una táctica inicial
        Comandante comandante = new Comandante(new TacticaGuerraDeGuerillas());

        // Ejecutar operación con táctica de guerrillas
        comandante.EjecutarOperacion();

        // Cambiar a táctica ofensiva convencional
        comandante.EstablecerTactica(new TacticaOfensivaConvencional());
        comandante.EjecutarOperacion();

        // Cambiar a táctica defensiva
        comandante.EstablecerTactica(new TacticaDefensiva());
        comandante.EjecutarOperacion();
    }
}
