using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLabVectores
{
    public partial class Caso1 : Form
    {
        public struct Alumno
        {
            public string Nombre;
            public int[] notas;
        }
        public Caso1()
        {
            InitializeComponent();
        }

        private void Caso1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            int mayornota = 0;
            Alumno[] alumnos = new Alumno[4];
            for(int i = 0; i < alumnos.Length; i++)
            {
                string nombre = Interaction.InputBox("Nombre");
                alumnos[i].Nombre = nombre;
                alumnos[i].notas = new int[3];
                for(int j = 0; j < alumnos[i].notas.Length; j++)
                {
                    int nota = Convert.ToInt32(Interaction.InputBox("Nota"));
                    alumnos[i].notas[j] = nota;
                }

                foreach (var nota in alumnos[i].notas)
                {   if(nota > mayornota)
                    {
                        mayornota = nota;
                    }
                    suma += Convert.ToDecimal(nota);
                    
                }
                MessageBox.Show("el promedio fue: " + Convert.ToString(suma /alumnos[i].notas.Length));
                MessageBox.Show("La mayor nota fue: "+ mayornota.ToString());
                if(suma / alumnos[i].notas.Length < 4)
                {
                    MessageBox.Show("Debe ir a recuperatorio");
                    
                } else if(suma / alumnos[i].notas.Length > 4 && suma / alumnos[i].notas.Length < 7)
                {
                    MessageBox.Show("Bien!");
                } else if( suma / alumnos[i].notas.Length > 7)
                {
                    MessageBox.Show("Muy bien!!");
                }
            }
        }
    }
}
