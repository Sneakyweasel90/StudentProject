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
    public partial class UpdateStudentScores : Form
    {
        public UpdateStudentScores()
        {
            InitializeComponent();
        }

        //Create constructor
        public UpdateStudentScores(Student SelectedStudent)
        {
            InitializeComponent();
            Student = SelectedStudent;
        }

        //Student property
        public Student Student { get; set; }

        //Update the name and create new load for the listbox
        private void UpdateStudentScores_Load(object sender, EventArgs e)
        {
            if (lstUpdate.Items.Count > 0)
            {
                lstUpdate.SelectedIndex = 0;
            }

            lblStudentName.Text = Student.FName + " " + Student.LName;
            //clear and then run the loop to update the list box
            lstUpdate.Items.Clear();
            foreach (int score in Student.Scores)
            {
                lstUpdate.Items.Add(score);
            }
        }

        //Creates a new student link to the addupdate form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddScore changeScore = new AddScore();

            //Making sure the person has clicked ok to update the list
            if (changeScore.ShowDialog() == DialogResult.OK) 
            {
                Student.Scores.Add(changeScore.scoreUpdate);
                refreshScore();
            }
        }

        //Remove an item from the listbox and call the refresh method
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Make sure the user has selected an item
            if(lstUpdate.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item to remove.", "Error");
                return;
            }
            Student.Scores.RemoveAt(lstUpdate.SelectedIndex);
            refreshScore();
        }

        //update the person. Allows the user to add or update a score for a single person
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddScore changeScore = new AddScore();

            //Makes sure that something is selected
            if(lstUpdate.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an item to update", "Error");
                return;
            }
            int index = lstUpdate.SelectedIndex;
            changeScore.scoreUpdate = Student.Scores[index];

            changeScore.Text = "UpdateScore";//This changes the name of the form

            //Making sure the person has clicked ok to update the list
            if (changeScore.ShowDialog() == DialogResult.OK)
            {
                Student.Scores[index] = changeScore.scoreUpdate;
                refreshScore();
            }
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            Student.Scores.Clear();
            refreshScore();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void refreshScore()
        {
            lstUpdate.Items.Clear();
            foreach (int score in Student.Scores)
            {
                lstUpdate.Items.Add(score);
            }
        }
    }
}
