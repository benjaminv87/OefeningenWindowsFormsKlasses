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
    public partial class Oefening2 : Form
    {
        public Oefening2()
        {
            InitializeComponent();
        }
        public TV mijnTV = new TV();

        private void btnZenderVerhoog_Click(object sender, EventArgs e)
        {
            mijnTV.ZenderVerhoog();
            lblZender.Text = mijnTV.zenderLijst[mijnTV.zender];
            numZender.Value = mijnTV.zender+1;
        }

        private void btnZenderVerlaag_Click(object sender, EventArgs e)
        {
            mijnTV.ZenderVerlaag();
            lblZender.Text = mijnTV.zenderLijst[mijnTV.zender];
            numZender.Value = mijnTV.zender+1;
        }

        private void btnVolumeVerhoog_Click(object sender, EventArgs e)
        {
            mijnTV.VolumeVerhoog();
            lblVolume.Text = mijnTV.volume.ToString();
        }

        private void btnVolumeVerlaag_Click(object sender, EventArgs e)
        {
            mijnTV.VolumeVerlaag();
            lblVolume.Text = mijnTV.volume.ToString();
        }

        private void btnStelZenderIn_Click(object sender, EventArgs e)
        {
            mijnTV.zender = Convert.ToInt32(numZender.Value-1);
            lblZender.Text = mijnTV.zenderLijst[mijnTV.zender];
        }

        private void Oefening2_Load(object sender, EventArgs e)
        {
            mijnTV.volume = 7;
            lblVolume.Text = mijnTV.volume.ToString();
            mijnTV.zender = 0;
            lblZender.Text = mijnTV.zenderLijst[mijnTV.zender];

            numZender.Value = mijnTV.zender+1;
            numZender.Maximum = mijnTV.zenderLijst.Count();
            numZender.Minimum = 1;
            numZender.Controls[0].Visible = false;
        }
    }
    public class TV
    {
        public int volume { get; set; }
        public int zender { get; set; }

        public List<string> zenderLijst = new List<string> { "één", "Canvas", "VTM", "Vier", "Vijf", "Q2", "Vitaya", "CAZ", "Studio 100","Focus","Ketnet" };


        public void VolumeVerhoog()
        {
            if (volume < 15) volume++;
        }
        public void VolumeVerlaag()
        {
            if (volume > 0) volume--;
        }
        public void ZenderInstellen(int inTeStellen)
        {
            zender = inTeStellen;
        }
        public void ZenderVerhoog()
        {
            if (zender < zenderLijst.Count - 1) zender++;
            else zender = 0;
        }
        public void ZenderVerlaag()
        {
            if (zender > 0) zender--;
            else zender = zenderLijst.Count-1; 
        }
    }
}
