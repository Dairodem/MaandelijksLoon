using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
     * fake files (history) from year *2019* else total
     * 
     */
    public partial class Form1 : Form
    {
        public List<Worker> WorkersList = new List<Worker>();

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
            formChange.Text = "Werkgever aanpassen";
            
        }
    }
}
