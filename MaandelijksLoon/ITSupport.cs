using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    class ITSupport : Support
    {
        public ITSupport(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours) : base(socialNr, name, gender, iban, birthDate, startDate, startWage, workHours)
        {
        }
    }
}
