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
using System.Windows.Forms.VisualStyles;

namespace UszoversenyKL
{
    public partial class EredmenyForm : Form
    {
        class Versenyzo
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

        public EredmenyForm()
        {
            InitializeComponent();
        }

        List<Versenyzo> versenyzok = new List<Versenyzo>();

        private void EredmenyHirdetes(string uszasNem, int tav, List<Versenyzo> versenyzok)
        {
            lblCim.Text = tav + " méteres " + uszasNem + " eredménye: ";
            this.versenyzok = versenyzok;
            foreach (Versenyzo versenyzo in versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }
        
        private void lstVersenyzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Versenyzo versenyzo = (Versenyzo)lstVersenyzok.SelectedItem;
                txtRajtszam.Text = versenyzo.Rajtszam;
                txtOrszag.Text = versenyzo.OrszagNev;
                txtIdoEredmeny.Text = new DateTime(versenyzo.IdoEredmeny.Ticks).ToString("mm:ss");
            } catch (Exception)
            {
                MessageBox.Show("Hibás választás", "Hiba");
            }
        }

        private void btnBezar_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép?", "Megerősítés", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }
        
        private void nevSorSzerint_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = true;
        }

        private void eredmenySzerint_CheckedChanged(object sender, EventArgs e)
        {
            lstVersenyzok.Sorted = false;
            lstVersenyzok.Items.Clear();
            Versenyzo temp;
            for (int i = 0; i < versenyzok.Count - 1; i++)
            {
                for (int j = i + 1; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].IdoEredmeny > versenyzok[j].IdoEredmeny)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }
            foreach (Versenyzo versenyzo in versenyzok)
            {
                lstVersenyzok.Items.Add(versenyzo);
            }
        }

        private void btnResztvevoOrszagok_Click(object sender, EventArgs e)
        {
            ZaszloForm zaszloForm = new ZaszloForm();
            zaszloForm.Fogad(versenyzok);
            zaszloForm.ShowDialog();
        }
    }
}
