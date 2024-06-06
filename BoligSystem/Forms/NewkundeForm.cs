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
    public partial class NewkundeForm : Form
    {
        DbHandler db;
        MyValidator validator;
        public NewkundeForm()
        {
            InitializeComponent();
            db = new DbHandler();
            validator = new MyValidator();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void buttonVidere_Click(object sender, EventArgs e)
        {
           
            string fornavn;
            if (validator.ValidateFirstname(textBoxFornavn.Text))
            {
                fornavn = textBoxFornavn.Text;
            }
            else
            {
                throw new Exception("Firstname not validated");
            }

            string efternavn;
            if (validator.ValidateLastname(textBoxEfternavn.Text))
            {
                efternavn = textBoxEfternavn.Text;
            }
            else
            {
                throw new Exception("Lastname not validated");
            }

            string email;
            if (validator.ValidateEmail(textBoxEmail.Text))
            {
                email = textBoxEmail.Text;
            }
            else
            {
                throw new Exception("Email not validated");
            }

            int tlf;
            if (validator.ValidatePhonenumber(int.Parse(textBoxTlf.Text)))
            {
                tlf = int.Parse(textBoxTlf.Text);
            }
            else
            {
                throw new Exception("Phonenumber not valid");
            }


            db.CreateKunde(new Kunde { KFname = fornavn, KLname = efternavn, KEmail = email, KTlfNr = tlf });
            MessageBox.Show("Ny kunde er oprettet");
            this.Hide();

            KundeForm Update = new KundeForm();
            Update.UpdateKundeData();

        }

     
    }
}
