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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnOef1_Click(object sender, EventArgs e)
        {
            var oef = new Oefening1();
            oef.Show();
        }

        private void btnOef2_Click(object sender, EventArgs e)
        {
            var oef = new Oefening2();
            oef.Show();
        }

        private void btnOef3_Click(object sender, EventArgs e)
        {
            var oef = new Oefening3();
            oef.Show();
        }

        private void btnOef4_Click(object sender, EventArgs e)
        {
            var oef = new Oefening4();
            oef.Show();
        }

        private void brnOef5_Click(object sender, EventArgs e)
        {
            var oef = new Oefening5();
            oef.Show();
        }
    } 
}
