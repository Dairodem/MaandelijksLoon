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
        public double Seniority { get; set; }
        public int WorkHours { get; set; }

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
            Seniority = GetSeniority();

        }
        private double SetStartWage(double wage, int workHours)
        {
            double result = wage * ((double)workHours / 38);

            return Math.Round(result,2);
        }
        public double GetSeniority()
        {
            TimeSpan span = DateTime.Now - StartDate;

            int result = span.Days / 365;

            double amount = StartWage;

            for (int i = 0; i < result; i++)
            {
                amount += amount * 0.01;
            }

            amount -= StartWage;

            return Math.Round(amount,2);
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
                    $"\n" +
                    $"{Seniority}";


            return info.ToUpper();
        }
        public override string ToString()
        {
            return Name;
        }
        public virtual string ShowPaycheck()
        {
            string paycheck = "";
            Seniority = GetSeniority();

            paycheck += $"€ {StartWage:0.00}\n" +
                        $"€ {Seniority}\n";

            double result = StartWage + Seniority;
            paycheck += $"€ {result}\n" +
                        $"€ 200.00\n";

            result -= 200;
            paycheck += $"€ {result}\n";




            return paycheck;
        }
    }
}
