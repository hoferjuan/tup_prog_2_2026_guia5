using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbarChar_Click(object sender, EventArgs e)
        {
            listBoxChar.Items.Clear();
            List<string> telefonos = new List<string>()
            {
                "2324-2456556", "343-4817427", "2324-245a556",
                "343--4817427", "343--4817427-34", "2324-a-2456556"
            };
            listBoxChar.Items.Add("Validación de telefonos.");
            foreach (string t in telefonos)
            {
                Validador v = new TelefonoCharValidador(t);
                listBoxChar.Items.Add($"{t}, resultado: {v.VerMensaje()}");
            }

            listBoxChar.Items.Add("");
            List<string> patentesViejas = new List<string>()
            {
                "ABC 123", "ABC123", "123 ABC", "ABC1 123",
                "ABC 123 1", "ABCA 123", "ABCA 123 B"
            };

            listBoxChar.Items.Add("Validación de patentes - formato viejo.");
            foreach (string p in patentesViejas)
            {
                Validador v = new PatentesViejasCharValidador(p);
                listBoxChar.Items.Add($"{p}, resultado: {v.VerMensaje()}");
            }
        }

        private void btnProbarRegex_Click(object sender, EventArgs e)
        {
            listBoxRegex.Items.Clear();

            List<string> telefonos = new List<string>()
            {
                "2324-2456556", "343-4817427", "2324-245a556",
                "343--4817427", "343--4817427-34", "2324-a-2456556"
            };

            listBoxRegex.Items.Add("Validación de telefonos.");
            foreach (string t in telefonos)
            {
                Validador v = new TelefonoRegexValidador(t);
                listBoxRegex.Items.Add($"{t}, resultado: {v.VerMensaje()}");
            }

            listBoxRegex.Items.Add("");

            List<string> patentesViejas = new List<string>()
            {
                "ABC 123", "ABC123", "123 ABC", "ABC1 123",
                "ABC 123 1", "ABCA 123", "ABCA 123 B"
            };

            listBoxRegex.Items.Add("Validación de patentes - formato viejo.");
            foreach (string p in patentesViejas)
            {
                Validador v = new PatentesViejasRegexValidador(p);
                listBoxRegex.Items.Add($"{p}, resultado: {v.VerMensaje()}");
            }
        }
    }
    
}
