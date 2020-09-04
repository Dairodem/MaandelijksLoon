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
    public partial class FormAddWorker : Form
    {
        Dictionary<string, decimal> functionsToWages = new Dictionary<string, decimal>()
        {
            {"Standaard", 1900 },
            {"Programmeur", 2200 },
            {"IT-Support", 2050 },
            {"Customer Support",2050 }

        };
        private string[] genderArray = new string[] { "Man","Vrouw" };

        public string InputName;
        public string Function;
        public string Gender;
        public string IBAN;
        public string SocialNr;
        public decimal StartWage;
        public int WorkHours;
        public bool HasCar;
        public bool newWorker;
        public DateTime BirthDate;
        public DateTime StartDate;
        public Worker ChangeWorker;


        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            FillYearsComboBox(cbYear, 1950, DateTime.Now.Year - 1950);
            FillYearsComboBox(cbYearHired, 1950 , DateTime.Now.Year - 1948);

            cbFunction.DataSource = null;
            cbFunction.DataSource = new BindingSource(functionsToWages, null);
            cbFunction.DisplayMember = "Key";
            cbFunction.ValueMember = "Value";

            cbFunction.SelectedIndex = 0;
            cbYear.SelectedIndex = 0;
            cbYearHired.SelectedIndex = cbYearHired.Items.Count-2;

            cbGender.Items.AddRange(genderArray);
            cbGender.SelectedIndex = 0;
            if (!newWorker)
            {
                btnAdd.Text = "Pas Gegevens aan";
                GetWorkerInfo();
            }

            numDayHired.Value = DateTime.Now.Day;
            numMonthHired.Value = DateTime.Now.Month;

            txtDateSoc.Text = UpdateSocialNumber();
            txtBaseWage.Text = GetWage().ToString();

        }
        private void numMonth_ValueChanged(object sender, EventArgs e)
        {
            txtDateSoc.Text = UpdateSocialNumber();
        }
        private void numDay_ValueChanged(object sender, EventArgs e)
        {
            txtDateSoc.Text = UpdateSocialNumber();

        }
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDateSoc.Text = UpdateSocialNumber();

        }
        private void cbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFunction.SelectedIndex == 1)
            {
                checkCar.Enabled = true;
            }
            else
            {
                checkCar.Checked = false;
                checkCar.Enabled = false;
            }

            if (cbFunction.SelectedIndex == 2)
            {
                numWorkHours.Value = 38;
                numWorkHours.Enabled = false;
            }
            else
            {
                numWorkHours.Enabled = true;
            }

            foreach (KeyValuePair<string,decimal> function in functionsToWages)
            { 
                if (cbFunction.Text == function.Key)
                {

                    numStartWage.Value = function.Value;
                }

            }
        }
        private void numStartWage_ValueChanged(object sender, EventArgs e)
        {
            txtBaseWage.Text = GetWage().ToString();  
        }
        private void numWorkHours_ValueChanged(object sender, EventArgs e)
        {
            txtBaseWage.Text = GetWage().ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isError = false;

            if (txtName.Text == "")
            {
                epName.SetError(txtName, "Geen naam ingevuld!");
                isError = true;
            }
            else
            {
                epName.Clear();
            }

            if (txtLastName.Text == "")
            {
                epLastName.SetError(txtLastName, "Geen familienaam ingevuld!");
                isError = true;
            }
            else
            {
                epLastName.Clear();
            }

            if (txtIban.Text == "")
            {
                epIBAN.SetError(txtIban, "Geen Rekeningnummer ingevuld!");
                isError = true;
            }
            else
            {
                epIBAN.Clear();
            }
            if (!isError)
            {
                InputName = txtName.Text + " " + txtLastName.Text;
                Function = cbFunction.Text;
                Gender = cbGender.Text;
                IBAN = "BE" + txtIban.Text;
                SocialNr = txtDateSoc.Text + "-" + txtAppendSoc.Text;
                StartWage = numStartWage.Value;
                WorkHours = (int)numWorkHours.Value;
                BirthDate = new DateTime(Convert.ToInt32(cbYear.Text), (int)numMonth.Value, (int)numDay.Value);
                StartDate = new DateTime(Convert.ToInt32(cbYearHired.Text), (int)numMonthHired.Value, (int)numDayHired.Value);
                HasCar = checkCar.Checked;

                this.DialogResult = DialogResult.OK;

            }
        }

        private decimal GetWage()
        {
            decimal wage = numStartWage.Value * (numWorkHours.Value / 38);

            return Math.Round(wage,2);
        }
        private string UpdateSocialNumber()
        {
            string str = "";

            str += cbYear.SelectedItem.ToString().Substring(2, 2) + ".";

            if (numMonth.Value < 10)
            {
                str += "0";
            }
            str += numMonth.Value.ToString() + ".";

            if (numDay.Value < 10)
            {
                str += "0";
            }
            str += numDay.Value.ToString();

            return str;
        }
        private void FillYearsComboBox(ComboBox comboBox, int startYear, int range)
        {
            int year = startYear;

            for (int c = 0; c < range; c++)
            {
                comboBox.Items.Add(year.ToString());
                year++;
            }
        }
        private void GetWorkerInfo()
        {
            foreach (KeyValuePair<string, decimal> function in functionsToWages)
            {
                if (ChangeWorker.Function == function.Key)
                {
                    cbFunction.SelectedIndex =  functionsToWages.Keys.ToList().IndexOf(function.Key);
                }
            }
            cbGender.SelectedItem = ChangeWorker.Gender;
            txtName.Text = ChangeWorker.Name.Substring(0,ChangeWorker.Name.IndexOf(' '));
            txtLastName.Text = ChangeWorker.Name.Substring(ChangeWorker.Name.IndexOf(' ')+1);
            numDay.Value = ChangeWorker.BirthDate.Day;
            numMonth.Value = ChangeWorker.BirthDate.Month;
            cbYear.SelectedItem = ChangeWorker.BirthDate.Year.ToString();
            txtAppendSoc.Text = ChangeWorker.SocialNr.Substring(ChangeWorker.SocialNr.IndexOf('-') + 1);
            txtIban.Text = ChangeWorker.Iban.Substring(2);
            numWorkHours.Value = ChangeWorker.WorkHours;

            if (ChangeWorker is Programmer)
            {
                Programmer temp = (Programmer)ChangeWorker;
                checkCar.Checked = temp.HasCar;
            }
            numDayHired.Value = ChangeWorker.StartDate.Day;
            numMonthHired.Value = ChangeWorker.StartDate.Month;
            cbYearHired.SelectedItem = ChangeWorker.StartDate.Year.ToString();

            gbHired.Enabled = false;

        }


    }
}
