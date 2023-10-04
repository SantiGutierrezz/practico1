using practico1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICO1_Pro2
{
    internal class Parlamento
    {

        private List<Legislador> legisladores;

        public Parlamento()
        {
            legisladores = new List<Legislador>();
        }

        public void registrarLegislador(Legislador legislador)
        {
            legisladores.Add(legislador);
        }

        public void listarCamaras()
        {
            foreach (var legislador in legisladores)
            {
                Console.WriteLine($"Nombre y apellido: {legislador.nombre}{legislador.apellido},  Número de Despacho: {legislador.numDespacho},  Cámara: {legislador.getCamara()}");
            }
        }

        public void cantidadLegisladoresPorTipo()
        {
            int senadores = 0;
            int diputados = 0;

            foreach (var legislador in legisladores)
            {
                if (legislador.getCamara() == "Senador")
                    senadores++;
                else if (legislador.getCamara() == "Diputado")
                    diputados++;
            }

            Console.WriteLine($"Cantidad de Senadores: {senadores}");
            Console.WriteLine($"Cantidad de Diputados: {diputados}");
        }

        public Legislador buscarLegisladorPorNumDespacho(int numDespacho)
        {
            foreach (var legislador in legisladores)
            {
                if (legislador.numDespacho == numDespacho)
                {
                    return legislador;
                }
            }
            return null;
        }

    }


}
