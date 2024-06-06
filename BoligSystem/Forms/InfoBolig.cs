using SemesterProjekt.DataAccess;
using SemesterProjekt.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SemesterProjekt.Forms
{
    public partial class InfoBolig : Form
    {
        AdvanceInfoBolig aib;
        DbHandler db;
        int BoligIid;
        string Adresse;
        int PostNr;
        int Udbudspris;
        int Kvadratmeter;
        string BoligType;
        bool Aktiv;
        int MæglerId;
        int row;
        int BoligId;




        public InfoBolig()
        {
            InitializeComponent();
            db = new DbHandler();
            aib = new AdvanceInfoBolig();
            DGVBolig.DataSource = null;
            DGVBolig.DataSource = db.GetAllBolig();

            // Navngivning af kolonne header
            DGVBolig.Columns["BoligId"].HeaderText = "Bolig ID";
            DGVBolig.Columns["PostNr"].HeaderText = "Post nr.";
            DGVBolig.Columns["UdbudsPris"].HeaderText = "Udbudspris";
            DGVBolig.Columns["KvmPris"].HeaderText = "Kvm. pris";
            DGVBolig.Columns["BoligType"].HeaderText = "Boligtype";
            DGVBolig.Columns["SalgsPris"].HeaderText = "Salgspris";
            DGVBolig.Columns["SalgsDato"].HeaderText = "Salgsdato";
            DGVBolig.Columns["MaeglerId"].HeaderText = "Mægler ID";



            // Formaterer de columns med de givende titler med formatet "N0"
            // som betyder Tusinde seperator uden tal til højre for 0
            this.DGVBolig.Columns["UdbudsPris"].DefaultCellStyle.Format = "C0";
            this.DGVBolig.Columns["SalgsPris"].DefaultCellStyle.Format = "C0";
            this.DGVBolig.Columns["KvmPris"].DefaultCellStyle.Format = "C0";

            // Alternating rows farver, ændres dynamisk
            this.DGVBolig.RowsDefaultCellStyle.BackColor = Color.White;
            this.DGVBolig.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e3e6e4");

            int gns = AveragePrice();
            textBoxGns.Text = $"{gns:C0}";
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }

        private void comboBoxBoligType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }
        private void comboBoxPostNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }

        private void comboBoxPris_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }

        private void comboxSortering_SelectedIndexChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }
        private void Aktiv_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }
        private void checkBoxSolgt_CheckedChanged(object sender, EventArgs e)
        {
            BoligSorting();
        }

        // Bolig Sorteringsmetode
        private void BoligSorting()
        {
            try
            {
                // først laves en liste af alle boliger i databasen, som gemmes i variablen boligListe
                List<Bolig> boligListe = db.GetAllBolig();

                // Søgbar ændring
                if (!string.IsNullOrEmpty(txtSearchbar.Text))
                {
                    boligListe = boligListe.Where(b => b.Adresse.Contains(txtSearchbar.Text)).ToList();

                }

                // Boligtype ændring
                if (ComboBoxBoligtype.Text != "BoligType" && !string.IsNullOrEmpty(ComboBoxBoligtype.Text))
                {
                    boligListe = boligListe.Where(b => b.BoligType == ComboBoxBoligtype.Text).ToList();
                }

                // postnummer ændring
                if (comboBoxPostNr.Text != "PostNr" && int.TryParse(comboBoxPostNr.Text, out var postNr))
                {
                    boligListe = boligListe.Where(b => b.PostNr == postNr).ToList();
                }

                // pris ændring
                if (comboBoxPris.Text != "Pris" && !string.IsNullOrEmpty(comboBoxPris.Text))
                {
                    var prisen = comboBoxPris.Text.Split("-");
                    if (prisen.Length == 2 && int.TryParse(prisen[0], out int minimumPris) && int.TryParse(prisen[1], out int maximumPris))
                    {
                        boligListe = boligListe.Where(b => b.UdbudsPris >= minimumPris && b.UdbudsPris <= maximumPris).ToList();
                    }
                    else
                    {
                        throw new ArgumentException("Invalid price range format");
                    }
                }

                // aktiv checkbox ændring
                if (Aktiv_checkbox.Checked)
                {
                    boligListe = boligListe.Where(b => b.Aktiv == true).ToList();
                }

                // Solgt checkbox ændret
                if (checkBoxSolgt.Checked)
                {
                    boligListe = boligListe.Where(b => b.Aktiv == false && b.SalgsPris > 0).ToList();
                }

                // sorteringsdropdown menu ændring
                if (!string.IsNullOrEmpty(comboxSortering.Text) && comboxSortering.Text != "Sortering")
                {
                    switch (comboxSortering.Text)
                    {
                        case "Adresse (alfabetisk)": boligListe = boligListe.OrderBy(b => b.Adresse).ToList(); break;

                        case "Udbudspris (lav - høj)": boligListe = boligListe.OrderBy(b => b.UdbudsPris).ToList(); break;

                        case "Udbudspris (høj - lav)": boligListe = boligListe.OrderByDescending(b => b.UdbudsPris).ToList(); break;

                        case "Kvm (lav - høj)": boligListe = boligListe.OrderBy(b => b.Kvadratmeter).ToList(); break;

                        case "Kvm (høj - lav)": boligListe = boligListe.OrderByDescending(b => b.Kvadratmeter).ToList(); break;

                        case "Kvadratmeterpris (lav - høj)": boligListe = boligListe.OrderBy(b => b.KvmPris).ToList(); break;

                        case "Kvadratmeterpris (høj - lav)": boligListe = boligListe.OrderByDescending(b => b.KvmPris).ToList(); break;

                        case "Salgspris (lav - høj)": boligListe = boligListe.OrderBy(b => b.SalgsPris).ToList(); break;

                        case "Salgspris (høj - lav)": boligListe = boligListe.OrderByDescending(b => b.SalgsPris).ToList(); break;

                        default: throw new ArgumentException("Invalid sorting option");
                    }

                }

                // Hvis ingen søgninger matcher med minimum en bolig, udskrives denne besked
                if (boligListe.Count == 0)
                {
                    MessageBox.Show("Ingen bolig matcher søgningen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // hvis der er mere end 0 boliger i listen kaldes metoden AveragePrice(), som gemmes i en variable og udskrives
                DGVBolig.DataSource = boligListe;
                if (boligListe.Count > 0)
                {
                    int gns = AveragePrice();
                    textBoxGns.Text = $"{gns:C0}";
                }
                
                // Fjerner selection for at undgå bruger forvirring
                DGVBolig.ClearSelection();
            }
            // catch hvis noget går galt og udskriv til brugeren den givende fejl
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridViewBolig_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Henter info omkring ejendomsmægler som er koblet til bolig
            row = e.RowIndex;
            try
            {
                DataGridViewRow data = DGVBolig.Rows[row];

                MæglerId = (int)data.Cells["MaeglerId"].Value;
                Adresse = (string)data.Cells["Adresse"].Value;
                BoligIid = (int)data.Cells["BoligId"].Value;
                PostNr = (int)data.Cells["PostNr"].Value;
                Udbudspris = (int)data.Cells["UdbudsPris"].Value;
                Kvadratmeter = (int)data.Cells["Kvadratmeter"].Value;
                BoligType = (string)data.Cells["BoligType"].Value;
                Aktiv = (bool)data.Cells["Aktiv"].Value;
                BoligId = (int)data.Cells["BoligId"].Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Tilføjer informationer over i Sælger kassen
            Saelger sa = db.GetSingleSaelgerBasedOfBoligId(BoligId);
            Txtbox_SaelgerNavn.Text = sa.SFname + " " + sa.SLname;
            Txtbox_SælgerTlfnr.Text = "" + sa.STlfNr;
            Txtbox_SaelgerEmail.Text = sa.SEmail;

            //Tilføjer information over i Mægler kassen
            EjendomsMaegler em = db.GetSingleEjendomsMaegler(MæglerId);
            textbox_MaeglerNavn.Text = em.MFname + " " + em.MLname;
            Txtbox_MaeglerTlf.Text = "" + em.MTlfNr;
            Txtbox_MaeglerEmail.Text = em.MEmail;

            // Henter info omkring Sælger som er tilkoblet Bolig

        }


        private int AveragePrice()
        {
            // Beregn gennemsnit
            int sum = 0;
            for (int i = 0; i < DGVBolig.Rows.Count; i++)
            {
                sum += Convert.ToInt32(DGVBolig.Rows[i].Cells[5].Value);
            }
            int countRow = DGVBolig.Rows.Count;
            int gns = 0;
            try
            {
                gns = sum / countRow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in calculation of average price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return gns;



        }
        private void buttonSaelgBolig_Click(object sender, EventArgs e)
        {
            if (Aktiv == true)
            {
                AdvanceInfoBolig aib = new AdvanceInfoBolig(MæglerId, Adresse, BoligIid, PostNr, Udbudspris, Kvadratmeter, BoligType, Aktiv);
                try
                {
                    aib.Show();
                }
                catch (Exception ex)
                {

                }

            }
            else
            {
                MessageBox.Show("Boligen er solgt i forvejen","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonOpdaterBolig_Click(object sender, EventArgs e)
        {
           
            if (Aktiv == true)
            {
                if (row > 0)
                {
                    OpdaterBoligForm updateBolig = new OpdaterBoligForm(MæglerId, Adresse, BoligIid, PostNr, Udbudspris, Kvadratmeter, BoligType, Aktiv);

                    try
                    {
                        updateBolig.Show();
                    }
                    catch (Exception ex) { }

                }
                else
                {
                    MessageBox.Show("Ingen bolig er valgt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boligen er ikke til salg", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            DGVBolig.DataSource = db.GetAllBolig();
            txtSearchbar.Text = "";
            ComboBoxBoligtype.Text = "BoligType";
            comboBoxPostNr.Text = "PostNr";
            comboBoxPris.Text = "Pris";
            Aktiv_checkbox.Checked = false;
            checkBoxSolgt.Checked = false;
            comboxSortering.Text = "Sortering";
            Txtbox_SaelgerNavn.Text = "";
            Txtbox_SælgerTlfnr.Text = "";
            Txtbox_SaelgerEmail.Text = "";
            textbox_MaeglerNavn.Text = "";
            Txtbox_MaeglerTlf.Text = "";
            Txtbox_MaeglerEmail.Text = "";
            DGVBolig.ClearSelection();
        }

        private void buttonNyBolig_Click(object sender, EventArgs e)
        {
            List<int> MIdList = db.MaeglerIDInDB();
           
            NewBoligForm newBoligForm = new NewBoligForm(MIdList);
            newBoligForm.Show();
        }



        private void Sletbolig_button_Click(object sender, EventArgs e)
        {
            var AreyouSure = MessageBox.Show("Er du sikker på at du vil slette denne bolig permanent?", "", MessageBoxButtons.YesNo);

            if (AreyouSure == DialogResult.Yes)
            {
                db.HardDeleteSaelgerFromDB(BoligIid);
                db.HardDeleteBoligFromDB(BoligIid);
                MessageBox.Show("Boligen er nu solgt");
            }

        }

        private void InfoBolig_Load(object sender, EventArgs e)
        {
            //Gør så Der ikke automatisk vælges 1 row i DGV når formen loades
            DGVBolig.ClearSelection();
        }

        private void btn_ExportToCSV_Click(object sender, EventArgs e)
        {
            var ExporttoCsv = MessageBox.Show("vil du eksportere alle boliger til en CSV fil?", "Export to csv", MessageBoxButtons.YesNo);
            if (ExporttoCsv == DialogResult.Yes)
            {
                try
                {
                    db.GetCSVAllBoligActive();
                    MessageBox.Show("Liste af alle aktive boliger er nu exporteret til din computer under mappen csv");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Not able to Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonExportThisPostnr_Click(object sender, EventArgs e)
        {
            var ExportThistoCsv = MessageBox.Show("vil du eksportere alle boliger med dette postnummer til en CSV fil?", "Export to csv", MessageBoxButtons.YesNo);
            if (ExportThistoCsv == DialogResult.Yes)
            {
                try
                {
                    db.GetCSVEverything(int.Parse(comboBoxPostNr.Text));
                    MessageBox.Show("Listen er nu eksporteret til din mappe 'csv' ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Not able to Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
