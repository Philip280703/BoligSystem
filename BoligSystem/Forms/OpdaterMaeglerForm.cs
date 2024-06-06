using BoligSystem.DataAccess;
using BoligSystem.Models;
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
    public partial class OpdaterMaeglerForm : Form
    {
        public OpdaterMaeglerForm(int MaeglerId, string MFname, string MLname, string MEmail, int MTlfNr, int Afdeling)
        {
            InitializeComponent();
            textBoxId.Text = MaeglerId.ToString();
            textBoxFornavn.Text = MFname;
            textBoxEfternavn.Text = MLname;
            textBoxEmail.Text = MEmail;
            textBoxTlf.Text = MTlfNr.ToString();
            textBoxAfdeling.Text = Afdeling.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonVidere_Click(object sender, EventArgs e)
        {
            DbHandler db = new DbHandler();
            int afdelingNy = int.Parse(comboBoxNyAfdeling.Text);
            int id = int.Parse(textBoxId.Text);
            db.UpdateEjendomsMaegler(new EjendomsMaegler { Afdeling = afdelingNy }, id);
            MessageBox.Show("Ny Ejendomsmægler er nu oprettet");
            this.Hide();

        }
    }
}
