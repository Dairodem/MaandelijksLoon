using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaandelijksLoon
{
    /*---------TODO---------------
     * 
     * aanpassen van werknemer
     * loonfiches opslaan naar text
     * 
     * ...
     * maanden naar het nederlands?
     * 
     */

    public partial class Form1 : Form
    {
        public List<Worker> WorkersList = new List<Worker>();
        public Worker currentWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkersList.Add(new Worker("91.05.08-511.13", "Test Werker", "Man", "BE13-4569-8544-7251", new DateTime(1991, 05, 08), new DateTime(2007, 01, 01),1900,30));
            WorkersList.Add(new Programmer("89.10.12-187.96", "Christella Demeulemeester", "Vrouw", "BE12-5362-2530-0031", new DateTime(1989, 10, 12), DateTime.Now.AddYears(-2),2200,30,true));
            WorkersList.Add(new ITSupport("79.04.20-278.04", "Marc Van De Voorde", "Man", "BE12-3225-8562-1245", new DateTime(1979, 4, 20), DateTime.Now,2050,19));
            WorkersList.Add(new CustSupport("81.12.29-916.55", "Nadia Jacobs", "Vrouw", "BE10-2680-9831-3684", new DateTime(1981, 12, 29), DateTime.Now,2050,38));

            lbxWorkers.DataSource = null;
            lbxWorkers.DataSource = WorkersList;

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            FormAddWorker formAddWorker = new FormAddWorker();
            formAddWorker.newWorker = true;

            if (formAddWorker.ShowDialog() == DialogResult.OK)
            {
                switch (formAddWorker.Function)
                {
                    case "Programmeur":
                        WorkersList.Add(new Programmer(formAddWorker.SocialNr, formAddWorker.InputName, formAddWorker.Gender, formAddWorker.IBAN,
                                            formAddWorker.BirthDate, formAddWorker.StartDate, (double)formAddWorker.StartWage, formAddWorker.WorkHours, formAddWorker.HasCar));
                        break;

                    case "IT-Support":
                        WorkersList.Add(new ITSupport(formAddWorker.SocialNr, formAddWorker.InputName, formAddWorker.Gender, formAddWorker.IBAN,
                                            formAddWorker.BirthDate, formAddWorker.StartDate, (double)formAddWorker.StartWage, formAddWorker.WorkHours));
                        break;

                    case "Customer Support":
                        WorkersList.Add(new CustSupport(formAddWorker.SocialNr, formAddWorker.InputName, formAddWorker.Gender, formAddWorker.IBAN,
                                            formAddWorker.BirthDate, formAddWorker.StartDate, (double)formAddWorker.StartWage, formAddWorker.WorkHours));
                        break;

                    case "Standaard":
                    default:
                        WorkersList.Add(new Worker(formAddWorker.SocialNr, formAddWorker.InputName, formAddWorker.Gender, formAddWorker.IBAN,
                                            formAddWorker.BirthDate, formAddWorker.StartDate, (double)formAddWorker.StartWage, formAddWorker.WorkHours));
                        break;
                }
                lbxWorkers.DataSource = null;
                lbxWorkers.DataSource = WorkersList;
            }
        }

        private void lbxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxWorkers.SelectedIndex >= 0)
            {
                Worker worker = (Worker)lbxWorkers.SelectedItem;

                lblInfo.Text = worker.GetInfo();

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormAddWorker formChange = new FormAddWorker();
            currentWorker = (Worker)lbxWorkers.SelectedItem;

            formChange.Text = $"Gegevens aanpassen van {currentWorker.Name}";
            formChange.newWorker = false;
            formChange.ChangeWorker = currentWorker;

            if (formChange.ShowDialog() == DialogResult.OK)
            {
                RemoveWorker(currentWorker);

                switch (formChange.Function)
                {
                    case "Programmeur":
                        WorkersList.Add(new Programmer(formChange.SocialNr, formChange.InputName, formChange.Gender, formChange.IBAN,
                                            formChange.BirthDate, formChange.StartDate, (double)formChange.StartWage, formChange.WorkHours, formChange.HasCar));
                        break;

                    case "IT-Support":
                        WorkersList.Add(new ITSupport(formChange.SocialNr, formChange.InputName, formChange.Gender, formChange.IBAN,
                                            formChange.BirthDate, formChange.StartDate, (double)formChange.StartWage, formChange.WorkHours));
                        break;

                    case "Customer Support":
                        WorkersList.Add(new CustSupport(formChange.SocialNr, formChange.InputName, formChange.Gender, formChange.IBAN,
                                            formChange.BirthDate, formChange.StartDate, (double)formChange.StartWage, formChange.WorkHours));
                        break;

                    case "Standaard":
                    default:
                        WorkersList.Add(new Worker(formChange.SocialNr, formChange.InputName, formChange.Gender, formChange.IBAN,
                                            formChange.BirthDate, formChange.StartDate, (double)formChange.StartWage, formChange.WorkHours));
                        break;
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Worker currWorker = (Worker)lbxWorkers.SelectedItem;
            CreatePaycheck(currWorker);
        }
        private void CreatePaycheck(Worker worker)
        {
            string folder = $"LOONBRIEVEN {DateTime.Now.AddMonths(-1).ToString("MMMM yyyy")}";
            string sign = " ";

            Directory.CreateDirectory(folder);

            worker.FillPaycheck();

            using (StreamWriter writer = new StreamWriter($"{folder}/LOONBRIEF {worker.Name.ToUpper()} {worker.SocialNr} {DateTime.Now.AddMonths(-1).ToString("MM-yyyy")}.txt"))
            {
                writer.WriteLine("────────────────────────────────────────────────");
                writer.WriteLine($"LOONBRIEF {DateTime.Now.AddMonths(-1).ToString("MMMM yyyy").ToUpper()}");
                writer.WriteLine("────────────────────────────────────────────────");
                writer.WriteLine(StringFormat("NAAM") + $": {worker.Name.ToUpper()}");
                writer.WriteLine(StringFormat("GESLACHT") + $": {worker.Gender.ToUpper()}");
                writer.WriteLine(StringFormat("GEBOORTEDATUM") + $": {worker.BirthDate.ToString("dd MMMM yyyy").ToUpper()}");
                writer.WriteLine(StringFormat("RIJKSREGISTERNUMMER") + $": {worker.SocialNr}");
                writer.WriteLine(StringFormat("DATUM INDIENSTTREDING") + $": {worker.StartDate.ToString("dd MMMM yyyy").ToUpper()}");
                writer.WriteLine(StringFormat("FUNCTIE") + $": {worker.Function.ToUpper()}");
                writer.WriteLine(StringFormat("TE PRESTEREN UREN") + $": {worker.WorkHours} /38");

                if (worker is Programmer)
                {
                    Programmer temp = (Programmer)worker;
                    writer.WriteLine(StringFormat("BEDRIJFSWAGEN") + $": {temp.HaveCar}");

                }
                writer.WriteLine("────────────────────────────────────────────────");

                foreach (KeyValuePair<string, double> pair in worker.FullPaycheck)
                {
                    if (!pair.Key.Contains("After"))
                    {
                        writer.WriteLine(StringFormat(pair.Key.ToUpper()) + $": {sign} € {NumberFormat(pair.Value)}");
                    }
                    else
                    {
                        writer.WriteLine(StringFormat(" ")                + $"  {sign} € {NumberFormat(pair.Value)}");
                    }
                }
                writer.WriteLine("────────────────────────────────────────────────");

            }


        }
        private string StringFormat(string str)
        {
            int space = 22 - str.Length;

            for (int i = 0; i < space; i++)
            {
                str += " ";
            }

            return str;
        }

        private string NumberFormat(double number)
        {
            string str = number.ToString("0.00");
            string whitespace = "";
            int space = 8 - str.Length;

            for (int i = 0; i < space; i++)
            {
                whitespace += " ";
            }

            return whitespace + str;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            foreach (Worker worker in WorkersList)
            {
                CreatePaycheck(worker);
            }
            if (checkRecap.Checked)
            {
                CreateRecap();
            }
        }
        private void CreateRecap()
        {
            double totalWages = 0;
            double totalEduc = 0;
            double totalHome = 0;

            foreach (Worker worker in WorkersList)
            {
                foreach (KeyValuePair<string, double> pair in worker.FullPaycheck)
                {
                    switch (pair.Key)
                    {
                        case "Startloon":
                            totalWages += pair.Value;
                            break;

                        case "Opleiding":
                            totalEduc += pair.Value;
                            break;

                        case "Thuiswerk":
                            totalHome += pair.Value;
                            break;

                        default:
                            break;
                    }
                }

            }

            string folder = $"LOONKOST {DateTime.Now.AddMonths(-1).ToString("MMMM yyyy")}";

            Directory.CreateDirectory(folder);
            using (StreamWriter writer = new StreamWriter($"{folder}/LOONKOST {DateTime.Now.AddMonths(-1).ToString("MM-yyyy")}.txt"))
            {
                writer.WriteLine("────────────────────────────────────────────────");
                writer.WriteLine($"LOONKOST {DateTime.Now.AddMonths(-1).ToString("MMMM yyyy").ToUpper()}");
                writer.WriteLine("────────────────────────────────────────────────");

            }
        }
        private void RemoveWorker(Worker worker)
        {
            WorkersList.Remove(worker);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveWorker((Worker)lbxWorkers.SelectedItem);
            lbxWorkers.DataSource = null;
            lbxWorkers.DataSource = WorkersList;
        }
    }
}
