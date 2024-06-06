using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    internal class Kunde
    {
        int kid;
        public int KId 
        {
            get { return kid; }
            set 
            {  
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("ID is out of range");
                }
                kid = value;
            }
        }

  
        string kfname;
        public string KFname
        {
            get
            {
                return kfname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Firstname is out of range");
                }
                kfname = value;
            }
        }

        string klname;
        public string KLname
        {
            get
            {
                return klname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Lastname is out of range");
                }
                klname = value;
            }
        }
        

        int kboligid;
        public int KBoligId 
        {
            get { return kboligid; }
            set
            { 
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("BoligID is out of range");
                }
                kboligid = value;
            }
        }


        string kemail;
        public string KEmail
        {
            get { return kemail; }
            set
            {
                if (value.Length < 5 || !value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentException("Email is not valid");
                }
                kemail = value;
            }
        }

        int ktlfnr;
        public int KTlfNr
        {
            get { return ktlfnr; }
            set
            {
                if (value < 10000000 || value >= 99999999)
                {
                    throw new ArgumentException("Phonenumber is out of range");
                }
                ktlfnr = value;
            }
        }
    }
}
