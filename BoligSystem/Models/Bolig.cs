using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    internal class Bolig
    {
        private int boligId;
        public int BoligId
        {
            get
            {
                return boligId;
            }
            set
            {
                if (value <= 0 || value > 100001)
                {
                    throw new ArgumentException("BoligId is out of range");
                }
                boligId = value;
            }
        }
        public string Adresse { get; set; }

        int postnr;
        public int PostNr
        {
            get
            {
                return postnr;
            }
            set
            {
                if (value < 1000 || value > 10000 )
                {
                    throw new ArgumentException("Postalcode is out of range");
                }
                postnr = value;
            }
        }

        int udbudspris;
        public int UdbudsPris
        {
            get
            {
                return udbudspris;
            }
            set
            {
                if (value < 0 || value > 1000000001)
                {
                    throw new ArgumentException("Price is out of range");
                }
                udbudspris = value;
            }
        }
        int kvadratmeter;
        public int Kvadratmeter
        {
            get
            {
                return kvadratmeter;
            }
            set
            {
                if (value < 30 || value > 1000)
                {
                    throw new ArgumentException("Square meter is out of range");
                }
                kvadratmeter = value;
            }
        }

        int kvmpris;
        public int KvmPris 
        {  
            get { return kvmpris;}
            set
            {
                if (value < 1000 || value > 250000)
                {
                    throw new ArgumentException("Kvadratmeter pris is not valid");
                }
                kvmpris = value;
            }
        }
        int vaerelser;
        public int Vaerelser
        {
            get { return vaerelser;}
            set
            {
                if ( value < 1 || value > 20)
                {
                    throw new ArgumentException("non valid amount af værelser");
                }
                vaerelser = value;
            }
        }
 
        public string BoligType { get; set; }
     


        public bool Aktiv {  get; set; }

        public bool Solgt {  get; set; }

        DateTime daten;
        public DateTime UdbudsDato
        {
            get { return daten; }
            set
            {
                if (value < new DateTime(2010, 01, 01) || value > new DateTime(2025, 01, 01))
                {
                    throw new ArgumentException("Date is out of range");
                }
                daten = value;
            }
        }

        int salgspris;
        public int SalgsPris
        {
            get
            {
                return salgspris;
            }
            set
            {
                if (value < 0 || value > 1000000001)
                {
                    throw new ArgumentException("Price is out of range");
                }
                salgspris = value;
            }
        }
  

        DateTime date;
        public DateTime SalgsDato
        {
            get { return date; }
            set
            {
                if (value <  new DateTime(1850,01,01) || value > new DateTime(2050,01,01))
                {
                    throw new ArgumentException("Date is out of range");
                }
                date = value;
            }
        }
        int sagId;
        public int SagId 
        {
            get { return sagId; }
            set
            {
                if ((value < 0) || (value > 1000))
                {
                    throw new ArgumentException("MaeglerId is out of range");
                }
                sagId = value;
            }
        }
    }
}
