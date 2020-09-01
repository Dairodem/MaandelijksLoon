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
        
        public Programmer(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, bool hasCar) : base(socialNr,name, gender,iban,birthDate,startDate)
        {
            HasCar = hasCar;
        }
    }
}
