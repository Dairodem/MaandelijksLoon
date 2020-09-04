using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaandelijksLoon
{
    class CustSupport : Support
    {
        public CustSupport(string socialNr, string name, string gender, string iban, DateTime birthDate, DateTime startDate, double startWage, int workHours) : base(socialNr, name, gender, iban, birthDate, startDate, startWage, workHours)
        {
            Function = "Customer Support";
        }
        public override void FillPaycheck()
        {
            FullPaycheck = new Dictionary<string, double>();


            FullPaycheck.Add("Startloon", StartWage);
            Seniority = GetSeniority(StartWage);
            double result = StartWage + Seniority;
            if (result != StartWage)
            {
                FullPaycheck.Add("Anciëniteit", Seniority);
                FullPaycheck.Add("AfterSeniority", result);

            }

            FullPaycheck.Add("Sociale Zekerheid", 200);

            result -= 200;
            FullPaycheck.Add("AfterSocial", result);
            FullPaycheck.Add("Bedrijfsvoorheffing", GetTaxes(result, 0.1368));

            result -= GetTaxes(result, 0.1368);
            FullPaycheck.Add("AfterTaxes", result);
            result = WorkAtHomeBonus(result);
            result = ReturnEducation(result);
            FullPaycheck.Add("Nettoloon", result);

        }
        private double ReturnEducation(double wage)
        {
            FullPaycheck.Add("Opleiding", 19.50);
            FullPaycheck.Add("AfterEduc", wage+ 19.50);

            return wage + 19.50;
        }
    }
}
