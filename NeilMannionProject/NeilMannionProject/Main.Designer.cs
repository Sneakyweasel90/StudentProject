namespace NeilMannionProject
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAddNew = new Button();
            lstStudents = new ListBox();
            label1 = new Label();
            lblScoreTotal = new Label();
            txtStudents = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label3 = new Label();
            label4 = new Label();
            lblScoreCount = new Label();
            lblAverage = new Label();
            SuspendLayout();
            // 
            // txtAddNew
            // 
            txtAddNew.Location = new Point(526, 107);
            txtAddNew.Margin = new Padding(4, 5, 4, 5);
            txtAddNew.Name = "txtAddNew";
            txtAddNew.Size = new Size(177, 60);
            txtAddNew.TabIndex = 0;
            txtAddNew.Text = "&Add New";
            txtAddNew.UseVisualStyleBackColor = true;
            txtAddNew.Click += txtAddNew_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(26, 62);
            lstStudents.Margin = new Padding(4, 5, 4, 5);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(474, 304);
            lstStudents.TabIndex = 1;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 408);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 2;
            label1.Text = "Score total:";
            // 
            // lblScoreTotal
            // 
            lblScoreTotal.BackColor = SystemColors.Info;
            lblScoreTotal.BorderStyle = BorderStyle.Fixed3D;
            lblScoreTotal.Location = new Point(353, 390);
            lblScoreTotal.Margin = new Padding(4, 0, 4, 0);
            lblScoreTotal.Name = "lblScoreTotal";
            lblScoreTotal.Size = new Size(90, 63);
            lblScoreTotal.TabIndex = 3;
            // 
            // txtStudents
            // 
            txtStudents.AutoSize = true;
            txtStudents.Font = new Font("Segoe UI", 14F);
            txtStudents.Location = new Point(26, 15);
            txtStudents.Margin = new Padding(4, 0, 4, 0);
            txtStudents.Name = "txtStudents";
            txtStudents.Size = new Size(124, 38);
            txtStudents.TabIndex = 4;
            txtStudents.Text = "Students";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(526, 177);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(177, 60);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(526, 250);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(177, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(526, 553);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(177, 70);
            btnExit.TabIndex = 7;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 488);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 8;
            label3.Text = "Score count:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 577);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 9;
            label4.Text = "Average:";
            // 
            // lblScoreCount
            // 
            lblScoreCount.BackColor = SystemColors.Info;
            lblScoreCount.BorderStyle = BorderStyle.Fixed3D;
            lblScoreCount.Location = new Point(353, 468);
            lblScoreCount.Margin = new Padding(4, 0, 4, 0);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(90, 63);
            lblScoreCount.TabIndex = 10;
            // 
            // lblAverage
            // 
            lblAverage.BackColor = SystemColors.Info;
            lblAverage.BorderStyle = BorderStyle.Fixed3D;
            lblAverage.Location = new Point(353, 553);
            lblAverage.Margin = new Padding(4, 0, 4, 0);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(90, 63);
            lblAverage.TabIndex = 11;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            CancelButton = btnExit;
            ClientSize = new Size(726, 650);
            Controls.Add(lblAverage);
            Controls.Add(lblScoreCount);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtStudents);
            Controls.Add(lblScoreTotal);
            Controls.Add(label1);
            Controls.Add(lstStudents);
            Controls.Add(txtAddNew);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Main";
            Text = "Student_Scores";
            Load += Student_Scores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button txtAddNew;
        private ListBox lstStudents;
        private Label label1;
        private Label lblScoreTotal;
        private Label txtStudents;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label label3;
        private Label label4;
        private Label lblScoreCount;
        private Label lblAverage;
    }
}
