namespace NeilMannionProject
{
    partial class AddStudent
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
            lblName = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtScore = new TextBox();
            btnAddScore = new Button();
            btnClearScore = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            lblScoresOutput = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(26, 23);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 22);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(321, 31);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(26, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 2;
            label1.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(14, 160);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 3;
            label2.Text = "Scores:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(123, 90);
            txtScore.Margin = new Padding(4, 5, 4, 5);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(135, 31);
            txtScore.TabIndex = 4;
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(281, 90);
            btnAddScore.Margin = new Padding(4, 5, 4, 5);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(164, 38);
            btnAddScore.TabIndex = 5;
            btnAddScore.Text = "&Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnClearScore
            // 
            btnClearScore.Location = new Point(281, 233);
            btnClearScore.Margin = new Padding(4, 5, 4, 5);
            btnClearScore.Name = "btnClearScore";
            btnClearScore.Size = new Size(164, 38);
            btnClearScore.TabIndex = 6;
            btnClearScore.Text = "Clear &Score";
            btnClearScore.UseVisualStyleBackColor = true;
            btnClearScore.Click += btnClearScore_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(96, 287);
            btnOK.Margin = new Padding(4, 5, 4, 5);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(164, 38);
            btnOK.TabIndex = 7;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(281, 287);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblScoresOutput
            // 
            lblScoresOutput.BackColor = SystemColors.Info;
            lblScoresOutput.BorderStyle = BorderStyle.Fixed3D;
            lblScoresOutput.Font = new Font("Segoe UI", 10F);
            lblScoresOutput.Location = new Point(123, 158);
            lblScoresOutput.Margin = new Padding(4, 0, 4, 0);
            lblScoresOutput.Name = "lblScoresOutput";
            lblScoresOutput.Size = new Size(283, 50);
            lblScoresOutput.TabIndex = 9;
            // 
            // AddStudent
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(500, 363);
            Controls.Add(lblScoresOutput);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnClearScore);
            Controls.Add(btnAddScore);
            Controls.Add(txtScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddStudent";
            Text = "AddStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtScore;
        private Button btnAddScore;
        private Button btnClearScore;
        private Button btnOK;
        private Button btnCancel;
        private Label lblScoresOutput;
    }
}