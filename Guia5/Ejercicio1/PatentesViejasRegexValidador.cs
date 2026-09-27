using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio1
{
    internal class PatentesViejasRegexValidador : PatentesViejasCharValidador
    {
        public PatentesViejasRegexValidador(string expresion) : base(expresion) { }
        public override string VerMensaje()
        {
            return $"Formato Viejo de patente {base.VerMensaje()}";
        }
        public override bool Validar()
        {
            if (string.IsNullOrEmpty(expresion)) return false;
            // 3 letras + 1 o más espacios + 3 números
            return Regex.IsMatch(expresion, @"^[a-zA-Z]{3}\s+[0-9]{3}$");
        }
    }
}
