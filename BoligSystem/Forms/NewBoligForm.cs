using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoligSystem.Models;
using BoligSystem.DataAccess;
using BoligSystem.Forms;
using BoligSystem;

namespace BoligSystem.Forms
{
    public partial class NewBoligForm : Form
    {
        DbHandler db;
        MyValidator validator;
        public NewBoligForm(List<int> MIdList)
        {
            InitializeComponent();
            comboBoxMidList.DataSource = MIdList;
            db = new DbHandler();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                validator = new MyValidator();
         
                string Adresse;
                if (validator.ValidateAdDress(AdresseTextbox.Text))
                {
                    Adresse = AdresseTextbox.Text;
                }
                else
                {
                    throw new Exception("Non valid Adresse");
                }

                int postNr;
                if (validator.ValidateZipcode(int.Parse(comboBoxPostNr.Text)))
                {
                    postNr = int.Parse(comboBoxPostNr.Text);
                }
                else
                {
                    throw new Exception("Postnummer not validated propperly");
                }

                int udbudspris;
                if (validator.ValidatePriceOfHouse(int.Parse(UdbudsprisTextbox.Text)))
                {
                    udbudspris = int.Parse(UdbudsprisTextbox.Text);
                }
                else
                {
                    throw new Exception("UdbudsPris is false");
                }

                int kvadratmeter;
                if (validator.ValidateSquareMeter(int.Parse(KvadratmeterTextbox.Text)))
                {
                    kvadratmeter = int.Parse(KvadratmeterTextbox.Text);
                }
                else
                {
                    throw new Exception("Kvadratmeter is false");
                }

                string boligtype;
                if (validator.ValidateHouseType(comboBoxBoligType.Text))
                {
                    boligtype = comboBoxBoligType.Text;
                }
                else
                {
                    throw new Exception("Housetype not valid");
                }

                int maeglerid = int.Parse(comboBoxMidList.Text);
           
           

                string fornavn;
                if (validator.ValidateFirstname(textBoxFornavn.Text))
                {   
                    fornavn = textBoxFornavn.Text;
                }
                else
                {
                    throw new Exception("fornavn not valid");
                }

                string efternavn;
                if (validator.ValidateLastname(textBoxEfternavn.Text))
                {
                    efternavn = textBoxEfternavn.Text;
                }
                else { throw new Exception("Lastname not valid"); }

                string email;
                if (validator.ValidateEmail(textBoxEmail.Text))
                { email = textBoxEmail.Text; }
                else { throw new Exception("Email not valid"); }

                int tlfnr;
                if(validator.ValidatePhonenumber(int.Parse(textBoxTlf.Text)))
                {
                    tlfnr = int.Parse(textBoxTlf.Text);
                }
                else
                {
                    throw new Exception("Telefonnummer not valid");
                }

                db.CreateBolig(new Bolig { Adresse = Adresse, PostNr = postNr, UdbudsPris = udbudspris, Kvadratmeter = kvadratmeter, BoligType = boligtype, MaeglerId = maeglerid});
            
                db.CreateSaelger(new Saelger { SFname = fornavn, SLname = efternavn, SEmail = email, STlfNr = tlfnr });

                MessageBox.Show("Bolig er nu sat til salg");
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Udfyld alle felter og prøv igen / Fejl i oprettelse af ny bolig: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
