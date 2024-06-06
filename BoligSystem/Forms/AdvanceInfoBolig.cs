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
    public partial class AdvanceInfoBolig : Form
    {
        DbHandler db;
        MyValidator validator;
        int row;
        int KId;

        public AdvanceInfoBolig()
        {
            InitializeComponent();

        }

        public AdvanceInfoBolig(int MæglerId, string Adresse, int BoligId, int PostNr, int Udbudspris, int Kvadratmeter, string BoligType, bool aktiv)
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
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            BoligTypeTextbox.Text = BoligType;
            AktivTextbox.Text = "" + aktiv;
            MaglerIdTextbox.Text = "" + MæglerId;
            db = new DbHandler();
            List<Kunde> KundeListe = db.GetAllKunder();
            DGVKunder.DataSource = KundeListe.Where(k => k.KBoligId == 0).ToList();

            
        }


        private void btn_Tilbage_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DGVKunder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            row = e.RowIndex;
            try
            {
                DataGridViewRow data = DGVKunder.Rows[row];

                KId = (int)data.Cells["Kid"].Value;
                textBoxKundeId.Text = KId.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void SælgBolig_Click(object sender, EventArgs e)
        {
            validator = new MyValidator();
            DateTime salgsdatoen;
            try
            {
                int boligiid = int.Parse(BoligIdTextBox.Text);
                
                if (validator.ValidateSalesDate(Salgsdato.Value))
                {
                     salgsdatoen = Salgsdato.Value;
                }
                else
                {
                    throw new Exception("Date Not valid");
                }

                db.MarkBoligAsSold(new Models.Bolig { Aktiv = false, SalgsDato = salgsdatoen, SalgsPris = int.Parse(Salgspris.Text) }, boligiid);


                db.UpdateKundeVedSalg(new Models.Kunde { KBoligId = boligiid }, KId);
                MessageBox.Show("Bolig er nu solgt!","Hurra!", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Hide();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

    }
}
