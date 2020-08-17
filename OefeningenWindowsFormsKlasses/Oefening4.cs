using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OefeningenWindowsFormsKlasses
{
    public partial class Oefening4 : Form
    {
        public Oefening4()
        {
            InitializeComponent();
        }

        private void btnBerekenInhoud_Click(object sender, EventArgs e)
        {
            if (numLengte.Value != 0 && numBreedte.Value != 0 && numHoogte.Value != 0)
            {
                double lengte = Convert.ToDouble(numLengte.Value);
                double breedte = Convert.ToDouble(numBreedte.Value);
                double hoogte = Convert.ToDouble(numHoogte.Value);
                Zwembad mijnZwembad = new Zwembad(lengte, breedte, hoogte);
                lblInhoud.Text = $"Het zwembad bevat {mijnZwembad.Volume().ToString()} liter water";
            }
            else MessageBox.Show("Gelieve overal een waarde groter dan 0 in te geven");

        }

        private void Oefening4_Load(object sender, EventArgs e)
        {
            lblInhoud.Text = "Geef de afmetingen van het zwembad in meters";

        }
    }
    public class Zwembad
    {
        public double Lengte, Breedte, Hoogte;
        public Zwembad(double lengte,double breedte,double hoogte)
        {
            Lengte = lengte;
            Breedte = breedte;
            Hoogte = hoogte;
        }

        public double Volume()
        {
            double volume = Lengte * Breedte * Hoogte*1000;
            return Math.Round(volume,2);
        }
    }
}
