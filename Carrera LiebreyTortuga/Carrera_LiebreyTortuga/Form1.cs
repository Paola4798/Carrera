using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_LiebreyTortuga
{
    public partial class Form1 : Form
    {
        Tortuga_ Turtle = new Tortuga_();
        Liebre Rabbit = new Liebre();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompetir_Click(object sender, EventArgs e)
        {
            Turtle.CarreraTortuga();
            Rabbit.CarreraLiebre();

            txtCarrera.Text += Turtle.ToString() + Environment.NewLine;
            txtCarrera.Text += Rabbit.ToString() + Environment.NewLine;

            if(Rabbit.Dormir == 0)
            {
                txtCarrera.Text = "Tortuga ganadora, la liebre está dormida";
            }
            else if(Turtle.Tortuga == "Ganador" && Rabbit.Liebre1 == "Ganador" )
            {
                txtCarrera.Text = "Empate, nadie gana";
            }
            else if (Turtle.PasosRapidos > Rabbit.SaltosGrandes && Turtle.PasosLentos > Rabbit.SaltoPequeño && Turtle.Resbalon < Rabbit.ResbalonGrande && Turtle.Resbalon < Rabbit.ResbalonPequeño)
            {
                txtCarrera.Text = "Tortuga ganadora";
            }
            else
                txtCarrera.Text = "Liebre ganadora";

        }
    }
}
