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
    public partial class Sælgerform : Form
    {
        DbHandler db;
        int row;

        //Gemmer Alle Værdier i sælger modellen
        int Id;
        string Firstname;
        string Lastname;
        string Email;
        int TlfNr;

        public Sælgerform()
        {
            db = new DbHandler();
            InitializeComponent();
            DGVSælger.DataSource = db.GetAllSaelger();

            // navngivning af kolonne header
            DGVSælger.Columns["Id"].HeaderText = "ID";
            DGVSælger.Columns["Firstname"].HeaderText = "Fornavn";
            DGVSælger.Columns["Lastname"].HeaderText = "Efternavn";
            DGVSælger.Columns["Email"].HeaderText = "Email";
            DGVSælger.Columns["TlfNr"].HeaderText = "Telefon nr.";


            // Alternating rows farver, ændres dynamisk
            this.DGVSælger.RowsDefaultCellStyle.BackColor = Color.White;
            this.DGVSælger.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e3e6e4");

        }

        private void Sælgerform_Load(object sender, EventArgs e)
        {
            DGVSælger.ClearSelection();
        }

        private void TxtSearchbar_TextChanged(object sender, EventArgs e)
        {
            List<Person> FiltreretSaelger = db.SearchbarSælger(TxtSearch.Text);
            DGVSælger.DataSource = FiltreretSaelger;
            DGVSælger.ClearSelection();
        }

        private void DGVSælger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
           
            try
            {
                DataGridViewRow data = DGVSælger.Rows[row];
                Id = (int)data.Cells["Id"].Value;
                Firstname = (string)data.Cells["Firstname"].Value;
                Lastname = (string)data.Cells["Lastname"].Value;
                Email = (string)data.Cells["Email"].Value;
                TlfNr = (int)data.Cells["TlfNr"].Value;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Filtrere så boligens id matcher med det boligid som er koblet på sælgeren
            List<Bolig> Boliger = db.GetAllBolig();
            DGV_Saelger_Bolig.DataSource = Boliger.Where(b => b.BoligId == BoligId).ToList();
            this.DGV_Saelger_Bolig.Columns["UdbudsPris"].DefaultCellStyle.Format = "C0";
            this.DGV_Saelger_Bolig.Columns["SalgsPris"].DefaultCellStyle.Format = "C0";
            this.DGV_Saelger_Bolig.Columns["KvmPris"].DefaultCellStyle.Format = "C0";
            // Navngivning af kolonne header
            DGV_Saelger_Bolig.Columns["BoligId"].HeaderText = "Bolig ID";
            DGV_Saelger_Bolig.Columns["PostNr"].HeaderText = "Post nr.";
            DGV_Saelger_Bolig.Columns["UdbudsPris"].HeaderText = "Udbudspris";
            DGV_Saelger_Bolig.Columns["KvmPris"].HeaderText = "Kvm. pris";
            DGV_Saelger_Bolig.Columns["BoligType"].HeaderText = "Boligtype";
            DGV_Saelger_Bolig.Columns["SalgsPris"].HeaderText = "Salgspris";
            DGV_Saelger_Bolig.Columns["SalgsDato"].HeaderText = "Salgsdato";
            DGV_Saelger_Bolig.Columns["MaeglerId"].HeaderText = "Mægler ID";
            DGV_Saelger_Bolig.ClearSelection();
        }

        private void Btn_Sorter_Solgt_Click(object sender, EventArgs e)
        {
            List<Bolig> BoligSolgt = db.GetAllBolig();
            DGV_Saelger_Bolig.DataSource = BoligSolgt.Where(b => b.SagId == 0).ToList();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            OpdaterSælgerForm os = new OpdaterSælgerForm(Id, Firstname + " " + Lastname, Email, TlfNr);
            os.Show();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            DGVSælger.DataSource = db.GetAllSaelger();
            DGVSælger.ClearSelection();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Er du sikker på du gerne vil slette Sælgeren. Den tilknyttede bolig vil også blive slettet", "Advarsel", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.HardDeleteSaelgerFromDB(SBoligId);
                db.HardDeleteBoligFromDB(SBoligId);
            }
            else
            {
            }
        }
    }
}
