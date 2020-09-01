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
        public int WorkHours { get; set; }
        public int Seniority { get; set; }

        public Worker(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate)
        {
            Name = name;
            Gender = gender;
            Iban = iban;
            BirthDate = birthDate;
            StartDate = startDate;
            SocialNr = socialNr;
            Function = "Standaard";
            StartWage = 1900.00d;
            WorkHours = 38;
            Wage = StartWage;
        }
        public Worker(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours)
        {
            Name = name;
            Gender = gender;
            Iban = iban;
            BirthDate = birthDate;
            StartDate = startDate;
            SocialNr = socialNr;
            Function = "Standaard";
            StartWage = startWage;
            WorkHours = workHours;
        }
        public virtual string GetInfo()
        {
            string info = "";
            info += $"{Name}\n" +
                    $"{Gender}\n" +
                    $"{BirthDate:dd MMMM yyyy}\n" +
                    $"{SocialNr}\n\n" +
                    $"{StartDate:dd MMMM yyyy}\n" +
                    $"{Function}\n" +
                    $"{WorkHours}/38\n" +
                    $"Nee";


            return info.ToUpper();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
