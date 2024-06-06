using BoligSystem.DataAccess;
using BoligSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoligSystem.Forms
{
    public partial class NewMaeglerform : Form
    {
        DbHandler db;
        MyValidator validator;
        public NewMaeglerform()
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
          
            if (string.IsNullOrEmpty(textBoxFornavn.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxEfternavn.Text) || string.IsNullOrEmpty(textBoxTlf.Text))
            {
                MessageBox.Show("Nogle af kasserne er ikke udfyldt, venligst udfyld dem før du går videre", "Fejl", MessageBoxButtons.OK);
            }
            else
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
                else { throw new Exception("Lastname not valid"); }

                string email;
                if (validator.ValidateEmail(textBoxEmail.Text))
                {
                    email = textBoxEmail.Text;
                }
                else { throw new Exception("Email not valid"); }

                int tlf;
                if (validator.ValidatePhonenumber(int.Parse(textBoxTlf.Text)))
                {
                    tlf = int.Parse(textBoxTlf.Text);
                }
                else
                {
                    throw new Exception("Phonenumber not valid");
                }

                int afdeling = int.Parse(comboBoxAfdeling.Text);


                db.CreateMaegler(new EjendomsMaegler { Firstname = fornavn, Lastname = efternavn, Email = email, TlfNr = tlf, Afdeling = afdeling, Aktiv = true });

                MessageBox.Show("Nye ejendomsmæglerne er nu oprettet");
                this.Hide();
            }
        }
    }
}
