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
            this.btnChange = new System.Windows.Forms.Button();
            this.gbWorkersList.SuspendLayout();
            this.gbWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxWorkers
            // 
            this.lbxWorkers.FormattingEnabled = true;
            this.lbxWorkers.ItemHeight = 15;
            this.lbxWorkers.Location = new System.Drawing.Point(19, 20);
            this.lbxWorkers.Name = "lbxWorkers";
            this.lbxWorkers.Size = new System.Drawing.Size(159, 214);
            this.lbxWorkers.TabIndex = 0;
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
            this.gbWorkersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWorkersList.Location = new System.Drawing.Point(12, 13);
            this.gbWorkersList.Name = "gbWorkersList";
            this.gbWorkersList.Size = new System.Drawing.Size(202, 326);
            this.gbWorkersList.TabIndex = 3;
            this.gbWorkersList.TabStop = false;
            this.gbWorkersList.Text = "Werknemerslijst";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(17, 21);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(53, 70);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "info\r\nnaam\r\ngeboorte\r\nindienst\r\n...";
            // 
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.btnChange);
            this.gbWorker.Controls.Add(this.lblInfo);
            this.gbWorker.Location = new System.Drawing.Point(220, 12);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(200, 327);
            this.gbWorker.TabIndex = 5;
            this.gbWorker.TabStop = false;
            this.gbWorker.Text = "naam werker";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(20, 243);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(160, 31);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Pas gegevens aan...";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 368);
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
    }
}

