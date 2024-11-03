namespace NeilMannionProject
{
    partial class UpdateStudentScores
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
            btnOK = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblScores = new Label();
            lstUpdate = new ListBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnClearScores = new Button();
            lblStudentName = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(123, 353);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 40);
            btnOK.TabIndex = 0;
            btnOK.Text = "&OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(250, 353);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(15, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 19);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblScores
            // 
            lblScores.AutoSize = true;
            lblScores.Font = new Font("Segoe UI", 10F);
            lblScores.Location = new Point(15, 80);
            lblScores.Name = "lblScores";
            lblScores.Size = new Size(51, 19);
            lblScores.TabIndex = 3;
            lblScores.Text = "Scores:";
            // 
            // lstUpdate
            // 
            lstUpdate.FormattingEnabled = true;
            lstUpdate.ItemHeight = 17;
            lstUpdate.Location = new Point(89, 97);
            lstUpdate.Name = "lstUpdate";
            lstUpdate.Size = new Size(164, 225);
            lstUpdate.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(279, 97);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 48);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(279, 148);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 48);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(279, 205);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(112, 48);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "&Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(279, 262);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(112, 48);
            btnClearScores.TabIndex = 8;
            btnClearScores.Text = "Clear &Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.BorderStyle = BorderStyle.Fixed3D;
            lblStudentName.Location = new Point(89, 33);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(286, 46);
            lblStudentName.TabIndex = 9;
            // 
            // UpdateStudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 430);
            Controls.Add(lblStudentName);
            Controls.Add(btnClearScores);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lstUpdate);
            Controls.Add(lblScores);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Font = new Font("Segoe UI", 10F);
            Name = "UpdateStudentScores";
            Text = "Update Student Scores";
            Load += UpdateStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private Label lblName;
        private Label lblScores;
        private ListBox lstUpdate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnClearScores;
        private Label lblStudentName;
    }
}