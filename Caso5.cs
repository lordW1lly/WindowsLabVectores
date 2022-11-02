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
    public partial class Caso5 : Form
    {
        public struct Provincia
        {
            public string Nombre;
            public decimal[] TempMediaMensuales;
            public decimal TempMediaTrimestral;
            
        }
        public Caso5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Provincia[] provincias = new Provincia[2];
            decimal tempMasAlta = 0;
            string ProvinciaMasCalurosa = "";
            for(int i = 0; i < provincias.Length; i++)
            {
                string nombre = Interaction.InputBox("Ingrese Provincia");
                provincias[i].Nombre = nombre;
                provincias[i].TempMediaMensuales = new decimal[3];
                decimal tempAcumulada = 0;
                for(int j = 0; j < provincias[i].TempMediaMensuales.Length; j++)
                {
                decimal mediaMensual = Convert.ToDecimal(Interaction.InputBox("Ingrese la Temp media mensual"));
                   provincias[i].TempMediaMensuales[j] = mediaMensual;
                    tempAcumulada += mediaMensual;

                }
                provincias[i].TempMediaTrimestral = tempAcumulada / provincias[i].TempMediaMensuales.Length;
                if (provincias[i].TempMediaTrimestral > tempMasAlta)
                {
                    tempMasAlta = provincias[i].TempMediaTrimestral;
                    ProvinciaMasCalurosa = provincias[i].Nombre;
                }
                
                MessageBox.Show("La temperatura media de esta provincia fue: " + Convert.ToString(provincias[i].TempMediaTrimestral));
            }
                MessageBox.Show("La Provincia con la media mas alta fue: " + ProvinciaMasCalurosa + " con una temperatura media de " + tempMasAlta);

        }
    }
}
