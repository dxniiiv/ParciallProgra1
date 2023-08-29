using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParciallProgra1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cboxDe, cboxA;
            double cantidad, respuesta;

            cboxDe = combode.SelectedIndex;
            cboxA = comboa.SelectedIndex;

            cantidad = double.Parse(textocantidad.Text);
            // Pie Cuadrado, Vara Cuadrada, Yarda Cuadrada, Metro Cuadrado, Tareas, Manzanas, Hectareas
            double[] medida = { 0.09290304, 0.698896, 0.836127, 1, 438, 7000, 10000 };
            respuesta = medida[cboxDe] / medida[cboxA] * cantidad;
            labelRespuestas.Text = "La respuesta de la conversion es: " + Math.Round(respuesta, 3);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
