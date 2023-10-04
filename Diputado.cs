using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico1
{
    internal class Diputado : Legislador
    {
        public int numAsientoCamaraAlta;
        public Diputado(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado, int numAsientoCamaraAlta) : base(partidoPolitico, departamentoQueRepresenta, numDespacho, nombre, apellido, edad, casado)
        {
            this.numAsientoCamaraAlta = numAsientoCamaraAlta;

        }
        //SETTERS Y GETTERS//

        public void setNumAsientoCamaraAlta(int numAsientoCamaraAlta) => this.numAsientoCamaraAlta = numAsientoCamaraAlta;
        public int getNumAsientoCamaraAlta() => numAsientoCamaraAlta;

        public override string getCamara()
        {
            return "Diputado";
        }
        public override void presentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} presenta una propuesta legislativa en la Cámara de Diputados: {propuesta}");
        }

        public override void votar(string decision)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} emite un voto ({decision}) en una sesión legislativa de la Cámara de Diputados");
        }

        public override void participarDebate(string tema)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} participa en un debate legislativo en la Cámara de Diputados sobre el tema: {tema}");
        }

    }
}