using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    public class Person
    {
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("ID is out of range");
                }
                id = value;
            }
        }

        string firstname;
        public string Fname
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Firstname is out of range");
                }
                firstname = value;
            }
        }

        string lastname;
        public string Lname
        {
            get
            {
                return lastname;
            }
            set
            {
                if (value.Length < 2 || value.Length > 25)
                {
                    throw new ArgumentException("Lastname is out of range");
                }
                lastname = value;
            }
        }

        string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length < 5 || !value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentException("Email is not valid");
                }
                email = value;
            }
        }
        int tlf;
        public int TlfNr
        {
            get { return tlf; }
            set
            {
                if (value < 10000000 || value > 99999999)
                {
                    throw new ArgumentException("Phonenumber is not valid");
                }
                tlf = value;
            }
        }
    }
}
