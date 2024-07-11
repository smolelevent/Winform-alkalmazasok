using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UszoversenyKL
{
    public partial class InditoForm : Form
    {
        public InditoForm()
        {
            InitializeComponent();
        }

        private void versenyMenu_Click(object sender, EventArgs e)
        {
            versenyForm.Fogad(versenyzok);
            this.Hide();
            versenyForm.ShowDialog();
            this.Show();

            eredmenyMenuItem.Enabled = true;
            versenyMenuItem.Enabled = false;
            mentesMenuItem.Enabled = true;
            int tav = versenyForm.Tav;
            string uszasNem = versenyForm.UszasNem;
            eredmenyForm.EredmenyHirdetes(uszasNem, tav, versenyzok);
        }

        public class Versenyzo
        {
            public string Rajtszam { get; private set; }
            public string Nev { get; private set; }
            public string OrszagNev { get; private set; }
            public string ZaszloNev { get; private set; }
            public TimeSpan IdoEredmeny { get; private set; }

            public void Versenyez(TimeSpan idoEredmeny)
            {
                this.IdoEredmeny = idoEredmeny;
            }

            private static int sorSzam;

            public Versenyzo(string nev, string orszag, string zaszlo)
            {
                this.Nev = nev;
                this.OrszagNev = orszag;
                this.ZaszloNev = zaszlo;
                sorSzam++;
                this.Rajtszam = (sorSzam < 10) ? ("0" + sorSzam) : sorSzam.ToString();
            }

            public override string ToString()
            {
                return Nev;
            }
        }

        private List<Versenyzo> versenyzok = new List<Versenyzo>();
        private VersenyForm versenyForm = new VersenyForm();
        private EredmenyForm eredmenyForm = new EredmenyForm();



        private void AdatBeolvasas()
        {
            string sor;
            string[] tordelt;
            string nev, orszag, zaszlo;
            StreamReader olvasoCsatorna = new StreamReader("uszok.txt");

            while (!olvasoCsatorna.EndOfStream)
            {
                sor = olvasoCsatorna.ReadLine();
                if (sor != "")
                {
                    tordelt = sor.Split(';');
                    nev = tordelt[0];
                    orszag = tordelt[1];
                    zaszlo = tordelt[2];
                    versenyzok.Add(new Versenyzo(nev, orszag, zaszlo));
                }
            }
            olvasoCsatorna.Close();
        }

        private void eredmenyMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            eredmenyForm.ShowDialog();
            this.Show();
        }

        private void mentesMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader iroCsatorna = new StreamReader("uszok.txt");
            foreach(var versenyzo in versenyzok)
            {
                iroCsatorna.WriteLine(versenyzo.Rajtszam + ";" + versenyzo.Nev + ";" + versenyzo.OrszagNev + ";" + versenyzo.IdoEredmeny);
            }
        }

        private void nevjegyMenuItem_Click(object sender, EventArgs e)
        {
            string keszito = "Kiss " + "(Pék)" + " Levente";
            NevjegyForm about = new NevjegyForm(keszito);
            about.ShowDialog();
        }
    }
}
