using SemesterProjekt.DataAccess;
using SemesterProjekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SemesterProjekt.Forms
{
    public partial class EjendomsmæglerForm : Form
    {
        DbHandler db;

        //Variabler der kan/skal gemmes (Mægler)
        int row = -10;
        int MaeglerId;
        string MFname;
        string MLname;
        bool MAktiv;
        string MEmail;
        int MTlfNr;
        int Afdeling;

        //Variabler der skal gemmes (Sælger)
        int BoligIid;
        string Adresse;
        int PostNr;
        int Udbudspris;
        int Kvadratmeter;
        string BoligType;
        bool Aktiv;




        public EjendomsmæglerForm()
        {
            InitializeComponent();
            db = new DbHandler();
            Dgv_Mægler.DataSource = db.GetAllEjendomsMaegler();

            // navngivning af kolonne header
            Dgv_Mægler.Columns["MId"].HeaderText = "ID";
            Dgv_Mægler.Columns["MFname"].HeaderText = "Fornavn";
            Dgv_Mægler.Columns["MLname"].HeaderText = "Efternavn";
            Dgv_Mægler.Columns["MAktiv"].HeaderText = "Aktiv";
            Dgv_Mægler.Columns["MEmail"].HeaderText = "Email";
            Dgv_Mægler.Columns["MTlfNr"].HeaderText = "Telefon nr.";


            // Alternating rows farver, ændres dynamisk
            this.Dgv_Mægler.RowsDefaultCellStyle.BackColor = Color.White;
            this.Dgv_Mægler.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e3e6e4");


            // Alternating rows farver, ændres dynamisk
            this.Dgv_Aktive_Boliger.RowsDefaultCellStyle.BackColor = Color.White;
            this.Dgv_Aktive_Boliger.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e3e6e4");


            // Alternating rows farver, ændres dynamisk
            this.Dgv_Inaktive_Boliger.RowsDefaultCellStyle.BackColor = Color.White;
            this.Dgv_Inaktive_Boliger.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e3e6e4");

        }

        private void Dgv_Mægler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if (row < 0)
            {
                Dgv_Mægler.ClearSelection();
            }

            try
            {
                DataGridViewRow data = Dgv_Mægler.Rows[row];
                MaeglerId = (int)data.Cells["MId"].Value;
                MFname = (string)data.Cells["MFname"].Value;
                MLname = (string)data.Cells["MLname"].Value;
                MAktiv = (bool)data.Cells["MAktiv"].Value;
                MEmail = (string)data.Cells["MEmail"].Value;
                MTlfNr = (int)data.Cells["MTlfNr"].Value;
                Afdeling = (int)data.Cells["Afdeling"].Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Viser alle aktive boliger i Aktiv DGV
            List<Bolig> Boliger = db.GetAllBolig();
            Dgv_Aktive_Boliger.DataSource = Boliger.Where(b => b.MaeglerId == MaeglerId && b.SalgsPris < 1).ToList();
            Dgv_Aktive_Boliger.ClearSelection();

            //Viser alle inaktive boliger i inaktiv DGV
            Dgv_Inaktive_Boliger.DataSource = Boliger.Where(b => b.MaeglerId == MaeglerId && b.SalgsPris > 1).ToList();
            Dgv_Inaktive_Boliger.ClearSelection();
        }

        private void Dgv_Aktive_Boliger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            try
            {
                DataGridViewRow Data = Dgv_Aktive_Boliger.Rows[row];
                MaeglerId = (int)Data.Cells["MaeglerId"].Value;
                Adresse = (string)Data.Cells["Adresse"].Value;
                BoligIid = (int)Data.Cells["BoligId"].Value;
                PostNr = (int)Data.Cells["PostNr"].Value;
                Udbudspris = (int)Data.Cells["UdbudsPris"].Value;
                Kvadratmeter = (int)Data.Cells["Kvadratmeter"].Value;
                BoligType = (string)Data.Cells["BoligType"].Value;
                Aktiv = (bool)Data.Cells["Aktiv"].Value;
                this.Dgv_Aktive_Boliger.Columns["UdbudsPris"].DefaultCellStyle.Format = "C0";
                this.Dgv_Aktive_Boliger.Columns["SalgsPris"].DefaultCellStyle.Format = "C0";
                this.Dgv_Aktive_Boliger.Columns["KvmPris"].DefaultCellStyle.Format = "C0";

                // Navngivning af kolonne header
                Dgv_Aktive_Boliger.Columns["BoligId"].HeaderText = "Bolig ID";
                Dgv_Aktive_Boliger.Columns["PostNr"].HeaderText = "Post nr.";
                Dgv_Aktive_Boliger.Columns["UdbudsPris"].HeaderText = "Udbudspris";
                Dgv_Aktive_Boliger.Columns["KvmPris"].HeaderText = "Kvm. pris";
                Dgv_Aktive_Boliger.Columns["BoligType"].HeaderText = "Boligtype";
                Dgv_Aktive_Boliger.Columns["SalgsPris"].HeaderText = "Salgspris";
                Dgv_Aktive_Boliger.Columns["SalgsDato"].HeaderText = "Salgsdato";
                Dgv_Aktive_Boliger.Columns["MaeglerId"].HeaderText = "Mægler ID";



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Saelger sa = db.GetSingleSaelgerBasedOfBoligId(BoligIid);
            TxtBox_Sælger_Navn.Text = sa.SFname + " " + sa.SLname;
            TxtBox_Sælger_Email.Text = sa.SEmail;
            TxtBox_Sælger_TlfNr.Text = "" + sa.STlfNr;

            TxtBox_Køber_TlfNr.Text = "";
            TxtBox_Køber_Navn.Text = "";
            TxtBox_Køber_Email.Text = "";

        }

        private void Dgv_Inaktive_Boliger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            try
            {
                DataGridViewRow Data = Dgv_Inaktive_Boliger.Rows[row];
                MaeglerId = (int)Data.Cells["MaeglerId"].Value;
                Adresse = (string)Data.Cells["Adresse"].Value;
                BoligIid = (int)Data.Cells["BoligId"].Value;
                PostNr = (int)Data.Cells["PostNr"].Value;
                Udbudspris = (int)Data.Cells["UdbudsPris"].Value;
                Kvadratmeter = (int)Data.Cells["Kvadratmeter"].Value;
                BoligType = (string)Data.Cells["BoligType"].Value;
                Aktiv = (bool)Data.Cells["Aktiv"].Value;
                this.Dgv_Inaktive_Boliger.Columns["UdbudsPris"].DefaultCellStyle.Format = "C0";
                this.Dgv_Inaktive_Boliger.Columns["SalgsPris"].DefaultCellStyle.Format = "C0";
                this.Dgv_Inaktive_Boliger.Columns["KvmPris"].DefaultCellStyle.Format = "C0";

                // Navngivning af kolonne header
                Dgv_Inaktive_Boliger.Columns["BoligId"].HeaderText = "Bolig ID";
                Dgv_Inaktive_Boliger.Columns["PostNr"].HeaderText = "Post nr.";
                Dgv_Inaktive_Boliger.Columns["UdbudsPris"].HeaderText = "Udbudspris";
                Dgv_Inaktive_Boliger.Columns["KvmPris"].HeaderText = "Kvm. pris";
                Dgv_Inaktive_Boliger.Columns["BoligType"].HeaderText = "Boligtype";
                Dgv_Inaktive_Boliger.Columns["SalgsPris"].HeaderText = "Salgspris";
                Dgv_Inaktive_Boliger.Columns["SalgsDato"].HeaderText = "Salgsdato";
                Dgv_Inaktive_Boliger.Columns["MaeglerId"].HeaderText = "Mægler ID";



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Saelger sa = db.GetSingleSaelgerBasedOfBoligId(BoligIid);
            TxtBox_Sælger_Navn.Text = sa.SFname + " " + sa.SLname;
            TxtBox_Sælger_Email.Text = sa.SEmail;
            TxtBox_Sælger_TlfNr.Text = "" + sa.STlfNr;

            Kunde ku = db.GetSingleKundeBasedOfBoligId(BoligIid);
            TxtBox_Køber_Email.Text = ku.KEmail;
            TxtBox_Køber_Navn.Text = ku.KFname + " " + ku.KLname;
            TxtBox_Køber_TlfNr.Text = "" + ku.KTlfNr;
        }

        private void EjendomsmæglerForm_Load(object sender, EventArgs e)
        {
            //Gør så Der ikke automatisk vælges 1 row i DGV 
            Dgv_Mægler.ClearSelection();
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            NewMaeglerform newMaeglerform = new NewMaeglerform();
            newMaeglerform.Show();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                OpdaterMaeglerForm opdaterMaegler = new OpdaterMaeglerForm(MaeglerId, MFname, MLname, MEmail, MTlfNr, Afdeling);
                opdaterMaegler.Show();
            }
            else
            {
                MessageBox.Show("Ingen mægler valgt", "Fejl", MessageBoxButtons.OK);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                var updater = MessageBox.Show("Ejendomsmægler inaktiv", "Vil du gøre denne Ejendomsmægler inaktiv", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (updater == DialogResult.Yes)
                {
                    db.UpdateEjendomsMaeglerAktivitet(new EjendomsMaegler { MAktiv = false }, MaeglerId);
                    MessageBox.Show("Ejendomsmægler aktivitet er nu opdateret");
                }
                if (updater == DialogResult.No)
                {
                    db.UpdateEjendomsMaeglerAktivitet(new EjendomsMaegler { MAktiv = true }, MaeglerId);
                    MessageBox.Show("Ejendomsmægler aktivitet er nu opdateret");
                }
                if (updater == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("Ingen Ejendomsmægler valgt", "Fejl", MessageBoxButtons.OK);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Dgv_Mægler.DataSource = db.GetAllEjendomsMaegler();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            var AreyouSure = MessageBox.Show("Er du sikker på at du vil slette denne Ejendomsmægler permanent?", "", MessageBoxButtons.YesNo);

            if (AreyouSure == DialogResult.Yes)
            {
                db.HardDeleteEjendomsMaeglerFromDB(MaeglerId);
                MessageBox.Show("Boligen er nu solgt");
            }
        }
    }
}
