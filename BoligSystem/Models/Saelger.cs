using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    internal class Saelger
    {
        
        int sid;
        public int SId 
        {
            get
            {
                return sid;
            }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("ID is out of range");
                }
                sid = value;
            }
        }

        string sfname;
        public string SFname
        {
            get
            {
                return sfname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Firstname is out of range");
                }
                sfname = value;
            }
        }

        string slname;
        public string SLname
        {
            get
            {
                return slname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Lastname is out of range");
                }
                slname = value;
            }
        }
       
        int sboligid;
        public int SBoligId
        {
            get
            {
                return sboligid;
            }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("ID is out of range");
                }
                sboligid = value;
            }
        }


        string semail;
        public string SEmail
        {
            get { return semail; }
            set
            {
                if (value.Length < 5 || !value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentException("Email is not valid");
                }
                semail = value;
            }
        }
      
        int stlfnr;
        public int STlfNr
        {
            get { return stlfnr; }
            set
            {
                if (value < 10000000 || value > 99999999)
                {
                    throw new ArgumentException("Phonenumber is out of range");
                }
                stlfnr = value;
            }
        }
    }
}
