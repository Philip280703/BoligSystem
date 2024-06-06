using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligSystem.Models
{
    internal class EjendomsMaegler : Person
    {
        
        int afdeling;
        public int Afdeling
        {
            get { return afdeling; }
            set
            {
                if (value < 0 || value >= 20)
                {
                    throw new ArgumentException("Afdeling number is not between 0 and 20");
                }
                afdeling = value;
            }
        }
    }
}
