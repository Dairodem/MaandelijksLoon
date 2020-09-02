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
        
        public Programmer(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours, bool hasCar) : base(socialNr,name, gender,iban,birthDate,startDate,startWage,workHours)
        {
            HasCar = hasCar;
            Function = "Programmeur";
        }
        public override string GetInfo()
        {
            string haveCar;
            if (HasCar)
                haveCar = "Ja";
            else
                haveCar = "Nee";

            Seniority = GetSeniority();

            string info = "";
            info += $"{Name}\n" +
                    $"{Gender}\n" +
                    $"{BirthDate:dd MMMM yyyy}\n" +
                    $"{SocialNr}\n\n" +
                    $"{StartDate:dd MMMM yyyy}\n" +
                    $"{Function}\n" +
                    $"{WorkHours}/38\n" +
                    $"{haveCar}\n" +
                    $"{Seniority}";


            return info.ToUpper();
        }
    }
}
