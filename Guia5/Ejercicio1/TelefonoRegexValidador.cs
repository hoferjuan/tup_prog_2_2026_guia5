using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class TelefonoRegexValidador :TelefonoCharValidador
    {
        public TelefonoRegexValidador(string expresion) : base(expresion) { }
        public override string VerMensaje()
        {
            return $"Número de teléfono {base.VerMensaje()}";
        }
        public override bool Validar()
        {
            if (string.IsNullOrEmpty(expresion)) return false;
            // Valida dígitos + guión + dígitos
            return Regex.IsMatch(expresion, @"^\d+-\d+$");
        }
    }
}
