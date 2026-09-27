using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal abstract class Validador
    {
        protected string expresion;
        public Validador(string expresion)
        {
            this.expresion = expresion;
        }
        public virtual string VerMensaje()
        {
            return Validar() ? "Correcto" : "Incorrecto";
        }
        public abstract bool Validar();
    }
}
