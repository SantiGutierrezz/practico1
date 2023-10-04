using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace practico1
{
    internal class Validaciones
    {
        public static string ValidarCadenaNoVacia(string mensaje)
        {
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error: La cadena no puede estar vacía o contener solo espacios en blanco. Intente nuevamente.");
                }
            } while (string.IsNullOrWhiteSpace(entrada));
            return entrada;
        }

        public static int ValidarEntero(string mensaje)
        {
            int resultado;
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if (!int.TryParse(entrada, out resultado))
                {
                    Console.WriteLine("Error: Ingrese un número entero válido.");
                }
            } while (!int.TryParse(entrada, out resultado));
            return resultado;
        }

        public static bool ValidarBooleano(string mensaje)
        {
            bool resultado;
            string entrada;
            do
            {
                Console.Write(mensaje);
                entrada = Console.ReadLine();
                if (!bool.TryParse(entrada, out resultado))
                {
                    Console.WriteLine("Error: Ingrese 'true' o 'false' para un valor booleano.");
                }
            } while (!bool.TryParse(entrada, out resultado));
            return resultado;
        }
    }
}
