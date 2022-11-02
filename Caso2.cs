using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsLabVectores
{
    public partial class Caso2 : Form
    {
        public struct Producto
        {
            public string Nombre;
            public decimal Precio;
        }
        public Caso2()
        {
            InitializeComponent();
        }

        private void cargar_productos(object sender, EventArgs e)
        {
            decimal suma = 0;
            Producto [] productos = new Producto[8];
            for(int i = 0; i < productos.Length; i++)
            {
                decimal precio = Convert.ToDecimal(Interaction.InputBox("ingresa precio"));
                string nombre = Interaction.InputBox("ingresa nombre");
                productos[i].Nombre = nombre;
                productos[i].Precio = precio;
                suma += productos[i].Precio;
            };
            MessageBox.Show("el total es" + suma);
        }
    }
}
