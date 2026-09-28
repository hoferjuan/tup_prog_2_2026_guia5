using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        string[] apellidos = { "Hernandez", "Saavedra", "Acosta", "Jacob", "Heinze", "Fischer", "Campos" };
        string[] nombres = {
            "Adriana", "Elizabeth", "José", "María",
            "Ernesto", "Sebastian", "Julio", "Ester",
            "Ariel", "Betiana", "Silvina", "Ana",
            "Leandro", "Ayelen", "Daniela", "Miguel"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10000; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                string apellido = apellidos[random.Next(apellidos.Length)];

                sb.AppendLine(nombre + ", " + apellido);
            }
            rtbListado.Text = sb.ToString();
        }
    }
}
