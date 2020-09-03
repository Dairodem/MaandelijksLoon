namespace MaandelijksLoon
{
    partial class Form1
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
            this.lbxWorkers = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.gbWorkersList = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbWorkersList.SuspendLayout();
            this.gbWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxWorkers
            // 
            this.lbxWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxWorkers.FormattingEnabled = true;
            this.lbxWorkers.ItemHeight = 15;
            this.lbxWorkers.Location = new System.Drawing.Point(3, 17);
            this.lbxWorkers.Name = "lbxWorkers";
            this.lbxWorkers.Size = new System.Drawing.Size(190, 214);
            this.lbxWorkers.TabIndex = 0;
            this.lbxWorkers.SelectedIndexChanged += new System.EventHandler(this.lbxWorkers_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(19, 240);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 31);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Verwijder werknemer";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(18, 287);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(160, 31);
            this.btnAddWorker.TabIndex = 2;
            this.btnAddWorker.Text = "Voeg werknemer toe...";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // gbWorkersList
            // 
            this.gbWorkersList.Controls.Add(this.lbxWorkers);
            this.gbWorkersList.Controls.Add(this.btnAddWorker);
            this.gbWorkersList.Controls.Add(this.btnRemove);
            this.gbWorkersList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkersList.Location = new System.Drawing.Point(12, 12);
            this.gbWorkersList.Name = "gbWorkersList";
            this.gbWorkersList.Size = new System.Drawing.Size(196, 326);
            this.gbWorkersList.TabIndex = 3;
            this.gbWorkersList.TabStop = false;
            this.gbWorkersList.Text = "Werknemerslijst";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(172, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(56, 135);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "naam\r\ngeslacht\r\ngeboorte\r\nSocialnr\r\n\r\nindienst\r\nfunctiie\r\nuren\r\nwagen\r\n";
            // 
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.btnSave);
            this.gbWorker.Controls.Add(this.label4);
            this.gbWorker.Controls.Add(this.label3);
            this.gbWorker.Controls.Add(this.lblWage);
            this.gbWorker.Controls.Add(this.label1);
            this.gbWorker.Controls.Add(this.lblInfoName);
            this.gbWorker.Controls.Add(this.btnChange);
            this.gbWorker.Controls.Add(this.lblInfo);
            this.gbWorker.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorker.Location = new System.Drawing.Point(214, 12);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(424, 327);
            this.gbWorker.TabIndex = 5;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "naam werker";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Startloon\r\n";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(172, 184);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(55, 15);
            this.lblWage.TabIndex = 7;
            this.lblWage.Text = "startloon\r\n";
            this.lblWage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 135);
            this.label1.TabIndex = 6;
            this.label1.Text = ":\r\n:\r\n:\r\n:\r\n\r\n:\r\n:\r\n:\r\n:\r\n";
            // 
            // lblInfoName
            // 
            this.lblInfoName.AutoSize = true;
            this.lblInfoName.Location = new System.Drawing.Point(20, 18);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(129, 135);
            this.lblInfoName.TabIndex = 5;
            this.lblInfoName.Text = "Naam\r\nGeslacht\r\nGeboortedatum\r\nRijksregisternummer\r\n\r\nDatum indiensttreding\r\nFunc" +
    "tie\r\nTe presteren uren\r\nBedrijfswagen";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 288);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(194, 31);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Pas gegevens aan...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(224, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Maak loonbrief op";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 348);
            this.Controls.Add(this.gbWorker);
            this.Controls.Add(this.gbWorkersList);
            this.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maandelijkse Lonen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWorkersList.ResumeLayout(false);
            this.gbWorker.ResumeLayout(false);
            this.gbWorker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxWorkers;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.GroupBox gbWorkersList;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Button btnSave;
    }
}

