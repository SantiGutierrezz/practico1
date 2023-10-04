using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico1
{
    internal class Legislador
    {
        protected string partidoPolitico;
        protected string departamentoQueRepresenta;
        public int numDespacho;
        public string nombre;
        public string apellido;
        protected int edad;
        protected bool casado;

        public Legislador(string partidoPolitico, string departamentoQueRepresenta, int numDespacho, string nombre, string apellido, int edad, bool casado)
        {
            this.partidoPolitico = partidoPolitico;
            this.departamentoQueRepresenta = departamentoQueRepresenta;
            this.numDespacho = numDespacho;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.casado = casado;
        }
        //SETTERS Y GETTERS//
        public void setPartidoPolitico(string partidoPolitico) => this.partidoPolitico = partidoPolitico;
        public string getPartidoPolitico() => partidoPolitico;

        public void setDepartamentoQueRepresenta(string departamentoQueRepresenta) => this.departamentoQueRepresenta = departamentoQueRepresenta;
        public string getDepartamentoQueRepresenta() => departamentoQueRepresenta;

        public void setNumDespacho(int numDespacho) => this.numDespacho = numDespacho;
        public int getNumDespacho() => numDespacho;

        public void setNombre(string nombre) => this.nombre = nombre;
        public string getNombre() => nombre;

        public void setApellido(string apellido) => this.apellido = apellido;
        public string getApellido() => apellido;

        public void setEdad(int edad) => this.edad = edad;
        public int getEdad() => edad;

        public void setCasado(bool casado) => this.casado = casado;
        public bool getCasado() => casado;



        //METODOS//
        public virtual string getCamara()
        {
            return "Desconocida";
        }

        public virtual void presentarPropuestaLegislativa(string propuesta)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} presenta una propuesta legislativa en la cámara de {getCamara()}: {propuesta}");
        }

        public virtual void votar(string decision)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} emite un voto ({decision}) en una sesión legislativa de {getCamara()}");
        }

        public virtual void participarDebate(string tema)
        {
            Console.WriteLine($"{getNombre()} {getApellido()} participa en un debate legislativo en la cámara de {getCamara()} sobre el tema: {tema}");
        }

    }
}


