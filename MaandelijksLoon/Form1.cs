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
    public partial class Form1 : Form
    {
        public List<Worker> WorkersList = new List<Worker>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WorkersList.Add(new Worker("91.05.08-511.13", "Test Werker", "Man", "BE13-4569-8544-7251", new DateTime(1991, 05, 08), new DateTime(2007, 01, 01)));
            WorkersList.Add(new Worker("89.10.12-187.96", "Eva Werkster", "Vrouw", "BE12-5362-2530-0031", new DateTime(1989, 10, 12), DateTime.Now));

            lbxWorkers.DataSource = WorkersList;

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            FormAddWorker formAddWorker = new FormAddWorker();

            formAddWorker.ShowDialog();
        }

    }
}
