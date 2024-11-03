using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeilMannionProject
{
    public partial class AddStudent : Form
    {
        //Create a basic list for the students to be added to
        private List<int> scores = new List<int>();
        public AddStudent()
        {
            InitializeComponent();
        }


        //Validate the input and then add it to the scores list and refresh the list
        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtScore.Text)))
            {
                MessageBox.Show("Please enter a number.", "Error");
                txtScore.Focus();
                return;
            }
            if(!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid score.", "Error");
                txtScore.Clear();
                txtScore.Focus();
                return;
            }
            if (Validator.IsWithinRange(int.Parse(txtScore.Text)))
            {
                scores.Add(score);
                UpdateScoresOutput();
                /*scores.Clear();
                lblScoresOutput.Text = string.Empty;*/
            }
            else
            {
                MessageBox.Show("Please enter a valid score between 0 and 100", "Error");
                txtScore.Focus();
            }
        }
        

        //Concatenates the scores to the label
        private void UpdateScoresOutput()
        {
            lblScoresOutput.Text = string.Join(" ", scores);
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtName.Text)) 
            {
                MessageBox.Show("Please input a name", "Error");
                txtName.Focus();
                return;
            }

            //Noticed this was stopping me from clicking the OK button
            /*if (!Validator.IsInteger(txtScore.Text))
            {
                MessageBox.Show("Please input a name", "Error");
                txtName.Focus();
                return;
            }*/

            Student student = new Student(txtName.Text, "", scores);
            this.Tag = student;
            this.DialogResult = DialogResult.OK;
        }


        //Clear out the score from the label and the list
        private void btnClearScore_Click(object sender, EventArgs e)
        {
            scores.Clear();
            lblScoresOutput.Text = string.Empty;
        }


        //Close this form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
