using BoligSystem.DataAccess;
using BoligSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoligSystem.Forms
{
    public partial class OpdaterBoligForm : Form
    {
        public OpdaterBoligForm(int MæglerId, string Adresse, int BoligId, int PostNr, int Udbudspris, int Kvadratmeter, string BoligType, bool aktiv)
        {
            InitializeComponent();
            BoligIdTextBox.Text = "" + BoligId;
            AdresseTextbox.Text = Adresse;
            PostNrTextbox.Text = "" + PostNr;
            UdbudsprisTextbox.Text = $"{Udbudspris:C0}";
            KvadratmeterTextbox.Text = "" + Kvadratmeter;
            try
            {
                double kvmpris = Udbudspris / Kvadratmeter;
                KvmPrisTextBox.Text = $"{kvmpris:C0}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
            BoligTypeTextbox.Text = BoligType;
            AktivTextbox.Text = "" + aktiv;
            MaglerIdTextbox.Text = "" + MæglerId;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbHandler db = new DbHandler();
            int boligiid = int.Parse(BoligIdTextBox.Text);
            int nyudbudspris = int.Parse(textboxNypris.Text);
            db.UpdateBolig(new Bolig { UdbudsPris = nyudbudspris }, boligiid);
            MessageBox.Show("Boligens Udbudspris er opdateret");
            this.Hide();
            
        }
    }
}
