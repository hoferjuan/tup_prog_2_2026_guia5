using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class TelefonoCharValidador : Validador
    {
        public TelefonoCharValidador(string expresion) : base(expresion)
        {
        }

        public override string VerMensaje()
        {
            return $"Número de teléfono {base.VerMensaje()}";
        }
        public override bool Validar()
        {
            if (string.IsNullOrEmpty(expresion)) return false;

            string[] partes = expresion.Split('-');
            if (partes.Length != 2) return false;

            foreach (string parte in partes)
            {
                if (string.IsNullOrEmpty(parte)) return false;
                foreach (char c in parte)
                {
                    if (!char.IsDigit(c)) return false;
                }
            }
            return true;
        }
    }
}
