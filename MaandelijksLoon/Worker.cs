using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    public class Worker
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Iban { get; set; }
        public string SocialNr { get; set; }
        public string Function { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public double StartWage { get; set; }
        public double Wage { get; set; }
        public double WorkHours { get; set; }

        public Worker(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate)
        {
            Name = name;
            Gender = gender;
            Iban = iban;
            BirthDate = birthDate;
            StartDate = startDate;
            SocialNr = socialNr;
            StartWage = 1900.00d;
            Wage = StartWage;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
