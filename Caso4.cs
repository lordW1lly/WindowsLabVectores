using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLabVectores
{
    public partial class Caso4 : Form
    {

        public struct Persona
        {
            public string Nombre;
            public int Edad;
        }
        public Caso4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona[] personas = new Persona[2];
            string Mayores = "";
            for (int i = 0; i < personas.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese su nombre");
                personas[i].Nombre = nombre;
                int edad =Convert.ToInt32( Interaction.InputBox("ingrese su edad"));
                personas[i].Edad = edad;
                if (personas[i].Edad >= 18)
                {
                    Mayores += ", "+ nombre;
                }
            }
            MessageBox.Show("Los mayores de edad son: "+ Mayores);
        }
    }
}
