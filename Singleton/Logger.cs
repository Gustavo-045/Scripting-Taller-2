using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger

    {
        private static Logger _Instance;
        private string logFilePath = "log.txt"; // Ruta del archivo de log



        public static Logger Instance 
        {
            get
            { 
                if (_Instance == null)
                {
                    _Instance = new Logger();
                } 
                return _Instance;
            } 
        }
        private Logger()
        {
        }

        // Método para escribir mensajes en el archivo de log
        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }




    }

}





