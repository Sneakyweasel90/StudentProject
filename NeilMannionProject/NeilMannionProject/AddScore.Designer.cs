namespace NeilMannionProject
{
    partial class AddScore
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
            lblScore = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 11F);
            lblScore.Location = new Point(46, 63);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(73, 30);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score:";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(53, 135);
            btnOk.Margin = new Padding(4, 5, 4, 5);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(129, 50);
            btnOk.TabIndex = 1;
            btnOk.Text = "&OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(214, 135);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(129, 50);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(144, 58);
            txtInput.Margin = new Padding(4, 5, 4, 5);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(211, 31);
            txtInput.TabIndex = 3;
            // 
            // AddScore
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 240);
            Controls.Add(txtInput);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(lblScore);
            Margin = new Padding(4, 5, 4, 5);
            Name = "AddScore";
            Text = "AddScore";
            Load += AddUpdatScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private Button btnOk;
        private Button btnCancel;
        private TextBox txtInput;
    }
}