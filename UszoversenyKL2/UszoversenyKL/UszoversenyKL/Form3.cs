using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UszoversenyKL
{
    public partial class VersenyForm : Form
    {
        public VersenyForm()
        {
            InitializeComponent();
            datumValaszto.Value = alap;
            uszasNemValaszto.SelectedIndex = 0;
        }

        public List<Versenyzo> Versenyzok { get; private set; }
        public string UszasNem { get; private set; }
        public int Tav { get; private set; }

        private DateTime alap = new DateTime(2000, 01, 01, 0, 0, 0);
        private int sorSzam;

        internal void Fogad()
        {
            Versenyzok = versenyzok;
        }

        private void btnVerseny_Click(object sender, EventArgs e)
        {
            UszasNem = uszasNemValaszto.Text;
            Tav = int.Parse(tavValaszto.Value);
            btnKovi.Enabled = true;
            tavValaszto.Enabled = false;
            uszasNemValaszto.Enabled = false;
            btnVerseny.Enabled = false;
            txtVersenyzo.Enabled = false;
        }

        private void btnKovi_Click(object sender, EventArgs e)
        {
            TimeSpan idoEredmeny = datumValaszto.Value - alap;
            Versenyzok[sorSzam].Versenyez(idoEredmeny);
            sorSzam++;
            VersenyzoBeallitas();
        }

        private void VersenyzoBeallitas()
        {
            datumValaszto.Value = alap;
            if (sorSzam < Versenyzok.Count)
            {
                txtVersenyzo.Text = Versenyzok[sorSzam].ToString();
            }
            else
            {
                this.Close();
            }
        }


    }
}
