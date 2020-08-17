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
    public partial class Oefening5 : Form
    {
        public Oefening5()
        {
            InitializeComponent();
        }

        private void btnMaakKlas_Click(object sender, EventArgs e)
        {
            enableMaakKlas(true);
        }
        private void btnMaakLeerling_Click(object sender, EventArgs e)
        {
            enableMaakLeerling(true);
        }
        private void btnLeerlingAnnuleren_Click(object sender, EventArgs e)
        {
            enableMaakLeerling(false);
        }
        private void btnKlasAnnuleren_Click(object sender, EventArgs e)
        {
            enableMaakKlas(false);

        }
        private void enableMaakKlas(bool b)
        {
            if (b) gbMaakKlas.Text = "Maak een nieuwe klas";
            else gbMaakKlas.Text = "Gegevens klas";
            gbMaakKlas.Enabled = b;
            btnKlasAnnuleren.Visible = b;
            btnKlasToevoegen.Visible = b;
            tbKlasJaar.Clear();
            tbKlasNaam.Clear();
        }
        private void enableMaakLeerling(bool b)
        {
            if (b) gbMaakLeerling.Text = "Maak een nieuwe Leerling";
            else gbMaakLeerling.Text = "Gegevens Leerling";
            gbMaakLeerling.Enabled = b;
            btnLeerlingAnnuleren.Visible = b;
            btnVoegLeerlingToe.Visible = b;
            tbLeerlingNaam.Clear();
        }
        private void Oefening5_Load(object sender, EventArgs e)
        {
            enableMaakKlas(false);
            enableMaakLeerling(false);
            Klas testKlas = new Klas("TestJaar", "Test richting");
            mijnSchool.MijnKlassenLijst.Add(testKlas);
            updateComboBox();
        }
        
        public School mijnSchool = new School();

        private void btnKlasToevoegen_Click(object sender, EventArgs e)
        {
            if (tbKlasJaar.Text != "" && tbKlasJaar.Text != "")
            {
                Klas mijnKlas = new Klas(tbKlasJaar.Text, tbKlasNaam.Text);
                mijnSchool.MijnKlassenLijst.Add(mijnKlas);
                updateComboBox();
                enableMaakKlas(false);
            }
            else MessageBox.Show("Geef de richting en het jaar.");

        }
        public void updateComboBox()
        {
            cbKlas.DataSource = null;
            cbKlasLeerling.DataSource = null;
            cbKlas.DataSource = mijnSchool.MijnKlassenLijst;
            cbKlasLeerling.DataSource = mijnSchool.MijnKlassenLijst;
            cbKlas.SelectedIndex = -1;
        }
        public void updateListbox()
        {
            lbLeerlingen.DataSource = null;
            if (cbKlas.SelectedIndex!=-1)
            {
                lbLeerlingen.DataSource = mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].leerlingen;
            }
        }

        private void cbKlas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKlas.DataSource != null && cbKlas.SelectedIndex!=-1)
            {
                tbKlasJaar.Text = mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].Jaar;
                tbKlasNaam.Text = mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].Richting;
            }
            updateListbox();
        }

        private void btnVoegLeerlingToe_Click(object sender, EventArgs e)
        {
            if (tbLeerlingNaam.Text != "") 
            {
                string geslacht;
                if (rbMan.Checked) geslacht = rbMan.Text;
                else geslacht = rbVrouw.Text;
                Leerling mijnLeerling = new Leerling(tbLeerlingNaam.Text,dateTimePicker1.Value,geslacht);
                mijnSchool.MijnKlassenLijst[cbKlasLeerling.SelectedIndex].leerlingen.Add(mijnLeerling);
            }
            updateListbox();
            enableMaakLeerling(false);
        }

        private void lbLeerlingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLeerlingen.SelectedIndex != -1)
            {
                int index = lbLeerlingen.SelectedIndex;
                tbLeerlingNaam.Text = mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].leerlingen[index].Naam;
                dateTimePicker1.Value = mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].leerlingen[index].VerjaarDag;
                if (mijnSchool.MijnKlassenLijst[cbKlas.SelectedIndex].leerlingen[index].Geslacht.ToLower() == "man") rbMan.Checked = true;
                else rbVrouw.Checked = true;
            }
        }
    }
    public class School
    {
        public List<Klas> MijnKlassenLijst = new List<Klas>();
    }
    public class Klas
    {
        public string Jaar;
        public string Richting;
        public Klas(string jaar,string richting)
        {
            Jaar = jaar;
            Richting = richting;
        }
        public override string ToString()
        {
            return $"{Jaar} - {Richting}";
        }
        public List<Leerling> leerlingen = new List<Leerling>();
    }
    public class Leerling
    {
        public string Naam;
        public DateTime VerjaarDag;
        public string Geslacht;

        public override string ToString()
        {
            return Naam;
        }
        public Leerling(string naam, DateTime verjaardag, string geslacht)
        {
            Naam = naam;
            Geslacht = geslacht;
            VerjaarDag = verjaardag;
        }
    }
}
