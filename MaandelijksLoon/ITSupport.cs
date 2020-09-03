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
            Function = "IT-Support";
        }
        public override void FillPaycheck()
        {
            FullPaycheck = new Dictionary<string, double>();


            FullPaycheck.Add("Startloon", StartWage);
            double reduction = StartWage * 0.06;
            Seniority = GetSeniority(StartWage - reduction);
            FullPaycheck.Add("Anciëniteit", Seniority);

            double result = StartWage + Seniority;
            FullPaycheck.Add("AfterSeniority", result);
            FullPaycheck.Add("Sociale Zekerheid", 200);

            result -= 200;
            FullPaycheck.Add("AfterSocial", result);
            FullPaycheck.Add("Bedrijfsvoorheffing", GetTaxes(result, 0.1368));

            result -= GetTaxes(result, 0.1368);
            FullPaycheck.Add("AfterTaxes", result);
            result = WorkAtHomeBonus(result);
            FullPaycheck.Add("Nettoloon", result);

        }
    }
}
