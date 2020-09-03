using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    class Support : Worker
    {
        double bonus = 50;
        public Support(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours) : base(socialNr, name, gender, iban, birthDate, startDate, startWage, workHours)
        {
        }
        public double WorkAtHomeBonus(double wage)
        {
            FullPaycheck.Add("Thuiswerk", bonus);
            FullPaycheck.Add("AfterHome", wage + bonus);

            return wage + bonus;
        }
    }
}
