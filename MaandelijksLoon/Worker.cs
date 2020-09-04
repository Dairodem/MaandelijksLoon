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
        public double Seniority { get; set; }
        public int WorkHours { get; set; }
        public Dictionary<string, double> FullPaycheck { get; set; }


        public Worker(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours)
        {
            Name = name;
            Gender = gender;
            Iban = iban;
            BirthDate = birthDate;
            StartDate = startDate;
            SocialNr = socialNr;
            Function = "Standaard";
            WorkHours = workHours;
            StartWage = SetStartWage(startWage, workHours);
            Seniority = GetSeniority(startWage);

        }
        private double SetStartWage(double wage, int workHours)
        {
            double result = wage * ((double)workHours / 38);

            return Math.Round(result,2);
        }
        public double GetSeniority(double wage)
        {
            TimeSpan span = DateTime.Now - StartDate;

            int result = span.Days / 365;

            double amount = wage;

            for (int i = 0; i < result; i++)
            {
                amount += amount * 0.01;
            }

            amount -= wage;

            return Math.Round(amount,2);
        }
        public double GetTaxes(double wage, double percent)
        {
            return Math.Round(wage * percent, 2);
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
                    $"\n";


            return info.ToUpper();
        }
        public virtual void FillPaycheck()
        {
            FullPaycheck = new Dictionary<string, double>();

            Seniority = GetSeniority(StartWage);

            FullPaycheck.Add("Startloon", StartWage);

            double result = StartWage + Seniority;
            if (result != StartWage)
            {
                FullPaycheck.Add("Anciënniteit", Seniority);
                FullPaycheck.Add("AfterSeniority", result);

            }

            FullPaycheck.Add("Sociale Zekerheid", 200.00d);

            result -= 200;
            FullPaycheck.Add("AfterSocial", result);
            FullPaycheck.Add("Bedrijfsvoorheffing", GetTaxes(result, 0.1368));

            result -= GetTaxes(result, 0.1368);
            FullPaycheck.Add("AfterTaxes", result);
            FullPaycheck.Add("Nettoloon", result);

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
