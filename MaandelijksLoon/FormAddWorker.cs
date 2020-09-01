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
        private string[] functionsArray = new string[] { "Standaard", "Programmeur", "IT-Support", "Customer Support" };
        private string[] genderArray = new string[] { "Man","Vrouw" };
        private string[] ageYears = new string[60];
        public FormAddWorker()
        {
            InitializeComponent();
        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            FillYearsArray();

            cbFunction.Items.AddRange(functionsArray);
            cbFunction.SelectedIndex = 0;
            cbGender.Items.AddRange(genderArray);
            cbGender.SelectedIndex = 0;
            cbYear.Items.AddRange(ageYears);
            cbYear.SelectedIndex = ageYears.Length-1;

            txtDateSoc.Text = UpdateSocialNumber();

        }
        private string UpdateSocialNumber()
        {
            string str = "";

            str += cbYear.SelectedItem.ToString().Substring(2,2) + ".";

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

        private void FillYearsArray()
        {
            int year = DateTime.Now.Year - (ageYears.Length+20);

            for (int c = 0; c < ageYears.Length; c++)
            {
                ageYears[c] = year.ToString();
                year++;
            }
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
    }
}
