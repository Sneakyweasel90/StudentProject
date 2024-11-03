using BusinessLayer;
using System.Runtime.Versioning;

namespace NeilMannionProject
{
    public partial class Main : Form
    {
        //Create StudentList
        StudentList studList = new StudentList();
        public Main()
        {
            InitializeComponent();

            //Subscribes to the StudentList so when something changes it updates with the method
            studList.ListChanged += new StudentList.StudentDelegate(refreshStudentList);
        }

        //Create the form load with 3 basic students
        private void Student_Scores_Load(object sender, EventArgs e)
        {
            
            lstStudents.Items.Clear();
            studList.addStudent(new Student("Gene", "Belcher", new List<int> { 98, 45, 45 }));
            studList.addStudent(new Student("Louise", "Belcher", new List<int> { 10, 20, 100 }));
            studList.addStudent(new Student("Tina", "Belcher", new List<int> { 89, 98, 86 }));

            if (lstStudents.SelectedIndex == -1)
            {
                lstStudents.SelectedIndex = 0;
            }
        }

        //Close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Link the main form with the add student form. Pull information from the other form and add to student list
        private void txtAddNew_Click(object sender, EventArgs e)
        {
            AddStudent addStudentForm = new AddStudent();
            if (addStudentForm.ShowDialog() == DialogResult.OK)
            {
                Student student = addStudentForm.Tag as Student;
                if (student != null)
                {
                    studList.addStudent(student);
                }
            }
        }


        //Delete the selected student and remove the numbers from the other calculated fields
        //*If* is there to make sure that something in the list to be deleted
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("There is nothing to delete. Please add a student in.", "Error");
                return;
            }
            Student student = studList[lstStudents.SelectedIndex];
            studList.removeStudent(student);
            lblScoreTotal.Text = string.Empty;
            lblAverage.Text = string.Empty;
            lblScoreCount.Text = string.Empty;
        }


        //Method for having a refresh for when anything happens
        private void refreshStudentList()
        {
            lstStudents.Items.Clear();
            for (int i = 0; i < studList.Count; i++)
            {
                lstStudents.Items.Add(studList[i].ToString());
            }
        }

        //
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This makes sure that something is selected in the form
            if (lstStudents.SelectedIndex == -1)
            {
                lstStudents.SelectedIndex = 0;
            }

            Student student = studList[lstStudents.SelectedIndex];
            lblScoreTotal.Text = student.ScoreTotal().ToString();

            lblScoreCount.Text = student.Scores.Count().ToString();

            lblAverage.Text = student.ScoreAverage().ToString("f2");
        }

        //Update the selected student
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (lstStudents.SelectedIndex >= 0)
            {
                Student student = studList[lstStudents.SelectedIndex];
                UpdateStudentScores updateForm = new UpdateStudentScores((Student)student.Clone());

                updateForm.ShowDialog();

                if (updateForm.DialogResult == DialogResult.OK)
                {
                    studList[lstStudents.SelectedIndex] = updateForm.Student;
                }
            }
            else
            {
                MessageBox.Show("Please select an option!");
            }
        }
    }
}
