using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    class Support : Worker
    {
        public Support(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate) : base(socialNr, name, gender, iban, birthDate, startDate )
        {
        }
    }
}
