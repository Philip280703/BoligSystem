using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    internal class MyValidator
    {
        // Person validation
        public bool ValidateFirstname(string firstname)
        {
            if (firstname.Length < 2 || firstname.Length > 25)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ValidateLastname(string lastname)
        {
            if (lastname.Length < 2 || lastname.Length > 25)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ValidateEmail(string Email)
        {
            if (Email.Length < 5 || !Email.Contains("@") || !Email.Contains("."))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePhonenumber (int Phonenumber)
        {
            if (Phonenumber < 10000000 || Phonenumber > 99999999)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // Bolig validation

        public bool ValidateAdDress(string Adresse)
        {
            if (Adresse.Length < 5 || Adresse.Length > 35)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool ValidateZipcode (int Zipcode)
        {
            if (Zipcode < 1000 ||  Zipcode > 10000)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool ValidatePriceOfHouse( int Price)
        {
            if (Price < 0 || Price > 10000000)
            {
                return false;
            }
            else 
            { 
                return true; 
            }
        }
        public bool ValidateSquareMeter (int SquareMeter)
        {
            if (SquareMeter < 30 || SquareMeter > 1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public bool ValidateHouseType( string HouseType)
        {
            if (HouseType == "Villa" || HouseType == "Rækkehus" || HouseType == "Andelsbolig" || HouseType == "Lejlighed")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateSalesDate( DateTime SalesDate)
        {
            if (SalesDate.Year < 1850 || SalesDate.Date > DateTime.Now.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
