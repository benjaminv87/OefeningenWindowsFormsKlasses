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
    public partial class Oefening1 : Form
    {
        public Oefening1()
        {
            InitializeComponent();
        }
        public Teller mijnTeller = new Teller();
        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            mijnTeller.TellerVerhogen();
        }

        private void btnLees_Click(object sender, EventArgs e)
        {
            mijnTeller.TellerTonen();
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            mijnTeller.TellerVerlagen();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mijnTeller.TellerReset();
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class Teller
    {
        private int waarde;

        public void TellerVerhogen()
        {
            waarde++;
        }
        public void TellerVerlagen()
        {
            waarde--;
        }
        public void TellerReset()
        {
            waarde = 0;
        }
        public void TellerTonen()
        {
            MessageBox.Show(waarde.ToString());
        }

    }
}
