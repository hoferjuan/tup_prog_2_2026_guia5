using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class PatentesViejasCharValidador : Validador
    {
        public PatentesViejasCharValidador(string expresion) : base(expresion) { }
        public virtual string Validador()
        {
            return $"Formato Viejo de patente {base.VerMensaje()}";
        }
        public override bool Validar()
        {
            if (string.IsNullOrEmpty(expresion)) return false;

            // Separar letras y números ignorando espacios consecutivos
            string[] partes = expresion.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (partes.Length != 2) return false;

            string letras = partes[0];
            string numeros = partes[1];

            if (letras.Length != 3 || numeros.Length != 3) return false;

            foreach (char c in letras)
            {
                if (!char.IsLetter(c)) return false;
            }

            foreach (char c in numeros)
            {
                if (!char.IsDigit(c)) return false;
            }

            return true;
        }
    }
}
