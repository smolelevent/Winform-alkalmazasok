using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonkonyvKL
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        class Ember
        {
            public string Nev;
            public string Cim;
            public string ApjaNeve;
            public string AnyjaNeve;
            public long TelefonSzam;
            public string Nem;
            public string Email;
            public string PolgariSzam;

            public Ember(string nev, string cim, string apjaNeve, string anyjaNeve, long telefonSzam, string nem, string email, string polgariSzam)
            {
                Nev = nev;
                Cim = cim;
                ApjaNeve = apjaNeve;
                AnyjaNeve = anyjaNeve;
                TelefonSzam = telefonSzam;
                Nem = nem;
                Email = email;
                PolgariSzam = polgariSzam;
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
        }

        private void btnListaz_Click(object sender, EventArgs e)
        {
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
