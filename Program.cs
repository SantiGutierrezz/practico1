using PRACTICO1_Pro2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parlamento parlamento = new Parlamento();
            bool continuarEjecucion = true;

            while (continuarEjecucion)
            {
                Console.WriteLine(" _______________________________________");
                Console.WriteLine("|________________Menú___________________|");
                Console.WriteLine("| 1. Agregar Senador                    |");
                Console.WriteLine("| 2. Agregar Diputado                   |");
                Console.WriteLine("| 3. Listar Cámaras de Trabajo          |");
                Console.WriteLine("| 4. Cantidad de Legisladores por Tipo  |");
                Console.WriteLine("| 5. Presentar Propuesta Legislativa    |");
                Console.WriteLine("| 6. Votar                              |");
                Console.WriteLine("| 7. Participar en el Debate            |");
                Console.WriteLine("| 8. Salir                              |");
                Console.WriteLine("| Seleccione una opción:                |");
                Console.WriteLine("|_______________________________________|");



                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        string partidoSenador = Validaciones.ValidarCadenaNoVacia("Partido: ");
                        string departamentoSenador = Validaciones.ValidarCadenaNoVacia("Departamento: ");
                        int numDespachoSenador = Validaciones.ValidarEntero("Número de Despacho: ");
                        string nombreSenador = Validaciones.ValidarCadenaNoVacia("Nombre: ");
                        string apellidoSenador = Validaciones.ValidarCadenaNoVacia("Apellido: ");
                        int edadSenador = Validaciones.ValidarEntero("Edad: ");
                        bool casadoSenador = Validaciones.ValidarBooleano("¿Casado (true o false): ");
                        int numAsientoSenador = Validaciones.ValidarEntero("Número de Asiento Cámara Alta: ");

                        Senador senador = new Senador(partidoSenador, departamentoSenador, numDespachoSenador, nombreSenador, apellidoSenador, edadSenador, casadoSenador, numAsientoSenador);
                        parlamento.registrarLegislador(senador);
                        break;

                    case "2":
                        string partidoDiputado = Validaciones.ValidarCadenaNoVacia("Partido: ");
                        string departamentoDiputado = Validaciones.ValidarCadenaNoVacia("Departamento: ");
                        int numDespachoDiputado = Validaciones.ValidarEntero("Número de Despacho: ");
                        string nombreDiputado = Validaciones.ValidarCadenaNoVacia("Nombre: ");
                        string apellidoDiputado = Validaciones.ValidarCadenaNoVacia("Apellido: ");
                        int edadDiputado = Validaciones.ValidarEntero("Edad: ");
                        bool casadoDiputado = Validaciones.ValidarBooleano("¿Casado (true o false): ");
                        int numAsientoDiputado = Validaciones.ValidarEntero("Número de Asiento Cámara Baja: ");

                        Diputado diputado = new Diputado(partidoDiputado, departamentoDiputado, numDespachoDiputado, nombreDiputado, apellidoDiputado, edadDiputado, casadoDiputado, numAsientoDiputado);
                        parlamento.registrarLegislador(diputado);
                        break;

                    case "3":
                        parlamento.listarCamaras();
                        break;

                    case "4":
                        parlamento.cantidadLegisladoresPorTipo();
                        break;

                    case "5":
                        int numDespachoPropuesta = Validaciones.ValidarEntero("Número de Despacho del Legislador: ");
                        Console.Write("Propuesta: ");
                        string propuesta = Console.ReadLine();

                        Legislador legisladorPropuesta = parlamento.buscarLegisladorPorNumDespacho(numDespachoPropuesta);

                        if (legisladorPropuesta != null)
                        {
                            legisladorPropuesta.presentarPropuestaLegislativa(propuesta);
                        }
                        else
                        {
                            Console.WriteLine("Legislador no encontrado.");
                        }
                        break;

                    case "6":
                        int numDespachoVoto = Validaciones.ValidarEntero("Número de Despacho del Legislador: ");
                        Console.Write("Decisión (A favor/En contra/Abstenerse): ");
                        string decision = Console.ReadLine();

                        Legislador legisladorVoto = parlamento.buscarLegisladorPorNumDespacho(numDespachoVoto);

                        if (legisladorVoto != null)
                        {
                            legisladorVoto.votar(decision);
                        }
                        else
                        {
                            Console.WriteLine("Legislador no encontrado.");
                        }
                        break;

                    case "7":
                        int numDespachoDebate = Validaciones.ValidarEntero("Número de Despacho del Legislador: ");
                        Console.Write("Tema del Debate: ");
                        string tema = Console.ReadLine();

                        Legislador legisladorDebate = parlamento.buscarLegisladorPorNumDespacho(numDespachoDebate);

                        if (legisladorDebate != null)
                        {
                            legisladorDebate.participarDebate(tema);
                        }
                        else
                        {
                            Console.WriteLine("Legislador no encontrado.");
                        }
                        break;

                    case "8":

                        continuarEjecucion = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

    }

}
