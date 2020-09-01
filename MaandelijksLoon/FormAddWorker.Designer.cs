namespace MaandelijksLoon
{
    partial class FormAddWorker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDateSoc = new System.Windows.Forms.TextBox();
            this.txtAppendSoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbHired = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbYearsHired = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numDayHired = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numMonthHired = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.gbHired.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayHired)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthHired)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(111, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(192, 22);
            this.txtLastName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 91);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 22);
            this.txtName.TabIndex = 1;
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(84, 45);
            this.numMonth.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(49, 22);
            this.numMonth.TabIndex = 4;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.ValueChanged += new System.EventHandler(this.numMonth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Voornaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Geslacht:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMonth);
            this.groupBox1.Location = new System.Drawing.Point(11, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 81);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geboren op";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Jaar:";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(150, 44);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(136, 22);
            this.cbYear.TabIndex = 9;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dag:";
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(21, 45);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(49, 22);
            this.numDay.TabIndex = 10;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.ValueChanged += new System.EventHandler(this.numDay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maand:";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(111, 121);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(192, 22);
            this.cbGender.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "IBAN:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rijksregisternummer:";
            // 
            // txtDateSoc
            // 
            this.txtDateSoc.Enabled = false;
            this.txtDateSoc.Location = new System.Drawing.Point(174, 252);
            this.txtDateSoc.Name = "txtDateSoc";
            this.txtDateSoc.Size = new System.Drawing.Size(58, 22);
            this.txtDateSoc.TabIndex = 16;
            this.txtDateSoc.Text = "00.00.00";
            this.txtDateSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAppendSoc
            // 
            this.txtAppendSoc.Location = new System.Drawing.Point(255, 252);
            this.txtAppendSoc.Name = "txtAppendSoc";
            this.txtAppendSoc.Size = new System.Drawing.Size(48, 22);
            this.txtAppendSoc.TabIndex = 17;
            this.txtAppendSoc.Text = "000.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "-";
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Location = new System.Drawing.Point(111, 35);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(192, 22);
            this.cbFunction.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 14);
            this.label10.TabIndex = 19;
            this.label10.Text = "Functie:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 22;
            this.label11.Text = "BE";
            // 
            // gbHired
            // 
            this.gbHired.Controls.Add(this.label12);
            this.gbHired.Controls.Add(this.cbYearsHired);
            this.gbHired.Controls.Add(this.label13);
            this.gbHired.Controls.Add(this.numDayHired);
            this.gbHired.Controls.Add(this.label14);
            this.gbHired.Controls.Add(this.numMonthHired);
            this.gbHired.Location = new System.Drawing.Point(349, 223);
            this.gbHired.Name = "gbHired";
            this.gbHired.Size = new System.Drawing.Size(292, 81);
            this.gbHired.TabIndex = 13;
            this.gbHired.TabStop = false;
            this.gbHired.Text = "Datum Indiensttreding";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Jaar:";
            // 
            // cbYearsHired
            // 
            this.cbYearsHired.FormattingEnabled = true;
            this.cbYearsHired.Location = new System.Drawing.Point(150, 44);
            this.cbYearsHired.Name = "cbYearsHired";
            this.cbYearsHired.Size = new System.Drawing.Size(136, 22);
            this.cbYearsHired.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 14);
            this.label13.TabIndex = 11;
            this.label13.Text = "Dag:";
            // 
            // numDayHired
            // 
            this.numDayHired.Location = new System.Drawing.Point(21, 45);
            this.numDayHired.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDayHired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDayHired.Name = "numDayHired";
            this.numDayHired.Size = new System.Drawing.Size(49, 22);
            this.numDayHired.TabIndex = 10;
            this.numDayHired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 14);
            this.label14.TabIndex = 9;
            this.label14.Text = "Maand:";
            // 
            // numMonthHired
            // 
            this.numMonthHired.Location = new System.Drawing.Point(84, 45);
            this.numMonthHired.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numMonthHired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonthHired.Name = "numMonthHired";
            this.numMonthHired.Size = new System.Drawing.Size(49, 22);
            this.numMonthHired.TabIndex = 4;
            this.numMonthHired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 479);
            this.Controls.Add(this.gbHired);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAppendSoc);
            this.Controls.Add(this.txtDateSoc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Font = new System.Drawing.Font("Cambria", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Werknemer Toevoegen";
            this.Load += new System.EventHandler(this.FormAddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.gbHired.ResumeLayout(false);
            this.gbHired.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDayHired)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonthHired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateSoc;
        private System.Windows.Forms.TextBox txtAppendSoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbHired;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbYearsHired;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numDayHired;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMonthHired;
    }
}