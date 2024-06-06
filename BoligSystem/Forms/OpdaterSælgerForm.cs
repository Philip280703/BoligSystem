using BoligSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoligSystem.Forms
{
    public partial class OpdaterSælgerForm : Form
    {
        int tlfnr;
        int forrigetlfnr;

        public OpdaterSælgerForm(int sælgerId, string SælgerNavn, int BoligId, string SælgerEmail, int SælgerTlfNr)
        {
            InitializeComponent();
            Txt_BoligId.Text = "" + BoligId;
            Txt_SælgerEmail.Text = SælgerEmail;
            Txt_SælgerNavn.Text = SælgerNavn;
            Txt_SælgerTlfNr.Text = "" + SælgerTlfNr;
            Txt_SælgerId.Text = "" + sælgerId;
        }

        //Opdater Sælgeren
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DbHandler db = new DbHandler();

            //Gemmere Forrige tlfnr så der kan sikres at bruger ikke indtaster det samme telefon nummer som allerede står der
            forrigetlfnr = int.Parse(Txt_SælgerTlfNr.Text);

            //Validere om inputtet er den korrekte længde, som er 8 i danmark
            if (Txt_NytTlfNr.Text.Length < 7 || Txt_NytTlfNr.Text.Length > 9)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_NytTlfNr.Text = "";
            }
            else
            {
                //Prøver nu at konvertere Inputtet, hvis det slår fejl så kommer der en error message op.
                try
                {
                    tlfnr = int.Parse(Txt_NytTlfNr.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Tjekker om Tlf Nr er det samme som originalt
                if (forrigetlfnr != tlfnr)
                {
                    db.UpdateSaelger(new Models.Saelger { STlfNr = tlfnr }, int.Parse(Txt_SælgerId.Text));
                    MessageBox.Show("Tlf Nr er opdateret", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tlf Nr er det samme som originalt", "Error", MessageBoxButtons.OK);
                }
            }

        }
    }
}
