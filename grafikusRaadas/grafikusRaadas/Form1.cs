using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikusRaadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private DateTime ma;

        private void Form1_Load(object sender, EventArgs e)
        {
            ma = DateTime.Now;
            lblAktualis.Text = ma.ToString("g");
        }

        private void btnErtekel_Click(object sender, EventArgs e)
        {
            DateTime datum, ido, talalkozo;
            datum = dtTmPckrDatum.Value;
            ido = dtTmPckrIdo.Value;
            talalkozo = datum.Date + ido.TimeOfDay;

            lblTalalkozo.Text = datum.ToShortDateString() + " " + ido.ToShortDateString();
            if(talalkozo < ma)
            {
                lblErtekeles.Text = "Ezt lekésted";
            } else
            {
                TimeSpan hatralevo = talalkozo - ma;
                lblErtekeles.Text = "Még " + hatralevo.Days + " nap " + hatralevo.Hours + " óra " + hatralevo.Seconds + " perc.";
            }

        }
    }
}
