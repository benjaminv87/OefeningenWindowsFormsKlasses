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
    public partial class Oefening3 : Form
    {
        public Oefening3()
        {
            InitializeComponent();
        }
        public Raport mijnRaport = new Raport();
        private void btnVakToevoegen_Click(object sender, EventArgs e)
        {
            Vak nieuwVak = new Vak(tbVakNaam.Text);
            mijnRaport.raportLijst.Add(nieuwVak);
            tbVakNaam.Clear();
            UpdateComboBox();
        }
        public void UpdateComboBox()
        {
            cbVakken.Items.Clear();
            foreach (var item in mijnRaport.raportLijst)
            {
                cbVakken.Items.Add(item.ToString());
            }
        }
        public void UpdateListBox()
        {
            lbLijst.Items.Clear();
            if (cbVakken.SelectedIndex != -1)
            {
                foreach (var item in mijnRaport.raportLijst[cbVakken.SelectedIndex].Punten)
                {
                    lbLijst.Items.Add(item);
                }
            }
            if (mijnRaport.raportLijst[cbVakken.SelectedIndex].Punten.Count == 0) lblGemiddelde.Text = "Gemiddelde :";
            else lblGemiddelde.Text = $"Gemiddelde {mijnRaport.raportLijst[cbVakken.SelectedIndex].Naam}: {mijnRaport.raportLijst[cbVakken.SelectedIndex].Gemiddelde()}";
            
        }
        private void cbVakken_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
        private void btnPuntenToevoegen_Click(object sender, EventArgs e)
        {
            if (cbVakken.SelectedIndex != -1)
            {
                mijnRaport.raportLijst[cbVakken.SelectedIndex].Punten.Add(Convert.ToInt32(numPunten.Value));
            }
            numPunten.Value = 0;
            UpdateListBox();
        }
        private void btnVerwijderPunt_Click(object sender, EventArgs e)
        {
            mijnRaport.raportLijst[cbVakken.SelectedIndex].Punten.RemoveAt(lbLijst.SelectedIndex);
            UpdateListBox();
            btnVerwijderPunt.Visible = false;
        }
        private void lbLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnVerwijderPunt.Visible = true;
        }
    }

    public class Raport
    {
        public List<Vak> raportLijst = new List<Vak>(); 
    }
    public class Vak
    {
        public string Naam { get; }
        public Vak(string naam)
        {
            Naam = naam;
        }
        public List<int> Punten = new List<int>();
        public double Gemiddelde()
        {
            double gemiddelde=0;
            foreach (var item in Punten)
            {
                gemiddelde += item;
            }
            gemiddelde /= Punten.Count;
            return Math.Round(gemiddelde,2) ;
        }
        public override string ToString()
        {
            return Naam;
        }

    }
}
