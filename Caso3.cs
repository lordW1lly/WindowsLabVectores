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
    public partial class Caso3 : Form
    {
        public struct Operario  {
             public string Nombre;
             public int[] Sueldos;
            public int totalPercibido;
    }
        public Caso3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operario [] operarios = new Operario[4];
            string mejorEmpleado = "";
                int TotalPagado = 0;
                int elMayorPercibido = 0;
            for(int i = 0; i < operarios.Length; i++)
            {
                int sumaTotal = 0;
                string nombre = Interaction.InputBox("Ingrese Nombre de Operario");
                operarios[i].Nombre = nombre;
                operarios[i].Sueldos = new int[3];
                for( int j = 0; j < operarios[i].Sueldos.Length; j++)
                {
                    int sueldoMensual = Convert.ToInt32(Interaction.InputBox("Ingrese sueldo de este mes"));
                    operarios[i].Sueldos[j] = sueldoMensual;
                    sumaTotal += sueldoMensual;
                }
                MessageBox.Show("el total acumulado es de : $ " + sumaTotal);
                    TotalPagado += sumaTotal;
                operarios[i].totalPercibido = sumaTotal;
                
                if(operarios[i].totalPercibido > elMayorPercibido)
                {
                    elMayorPercibido = operarios[i].totalPercibido;
                    mejorEmpleado = nombre;

                }
            MessageBox.Show("el total pagado de sueldos a operarios asciende a $ "+ TotalPagado);
            }
            MessageBox.Show("el empleado que mas percibio fue:" + mejorEmpleado);
        }
    }
}
