using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico1
{
    internal class Senador : Legislador
    {
        public int numAsientoCamaraBaja;

        public Senador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraBaja) : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {
            this.numAsientoCamaraBaja = numAsientoCamaraBaja;

        }
        public void setNumAsientoCamaraBaja(int numAsientoCamaraBaja) => this.numAsientoCamaraBaja = numAsientoCamaraBaja;
        public int getNumAsientoCamaraBaja() => numAsientoCamaraBaja;

        public override string getCamara()
        {
            return "Senador";
        }
        public override void presentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} presenta una propuesta legislativa en el Senado: {propuesta}");
        }

        public override void votar(string decision)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} emite un voto ({decision}) en una sesión legislativa del Senado");
        }

        public override void participarDebate(string tema)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} participa en un debate legislativo en el Senado sobre el tema: {tema}");
        }


    }
}
