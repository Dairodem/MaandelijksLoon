using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    class Programmer : Worker
    {
        public bool HasCar { get; set; }
        public string HaveCar;

        public Programmer(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours, bool hasCar) : base(socialNr,name, gender,iban,birthDate,startDate,startWage,workHours)
        {
            HasCar = hasCar;
            Function = "Programmeur";
        }
        public override string GetInfo()
        {
            if (HasCar)
                HaveCar = "Ja";
            else
                HaveCar = "Nee";

            Seniority = GetSeniority(StartWage);

            string info = "";
            info += $"{Name}\n" +
                    $"{Gender}\n" +
                    $"{BirthDate:dd MMMM yyyy}\n" +
                    $"{SocialNr}\n\n" +
                    $"{StartDate:dd MMMM yyyy}\n" +
                    $"{Function}\n" +
                    $"{WorkHours}/38\n" +
                    $"{HaveCar}\n" +
                    $"{Seniority}";


            return info.ToUpper();
        }

        public override void FillPaycheck()
        {
            FullPaycheck = new Dictionary<string, double>();

            Seniority = GetSeniority(StartWage);

            FullPaycheck.Add("Startloon", StartWage);
            FullPaycheck.Add("Anciëniteit", Seniority);

            double result = StartWage + Seniority;
            FullPaycheck.Add("AfterSeniority", result);
            FullPaycheck.Add("Sociale Zekerheid", 200);

            result -= 200;
            FullPaycheck.Add("AfterSocial", result);
            double percent = 0.1368;

            if (HasCar)
            {
                percent = 0.1730;
            }
            FullPaycheck.Add("Bedrijfsvoorheffing", GetTaxes(result,percent));

            result -= GetTaxes(result,percent);
            FullPaycheck.Add("AfterTaxes", result);
            FullPaycheck.Add("Nettoloon", result);

        }
    }
}
