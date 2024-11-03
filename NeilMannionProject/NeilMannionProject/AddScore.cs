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
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        //Making a connectiong to get and bring back the information
        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!Validator.IsPresent(txtInput.Text))
            {
                MessageBox.Show("Please enter a number.", "Error");
                txtInput.Focus();
                return;
            }
            if(!Validator.IsInteger(txtInput.Text) || !Validator.IsWithinRange(int.Parse(txtInput.Text)))
            {
                MessageBox.Show("Please enter a valid number between 0 and 100", "Error");
                txtInput.Clear();
                txtInput.Focus();
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.scoreUpdate = Convert.ToInt32(txtInput.Text);
                this.Close();
            }
        }

        //Close out the add score form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Loads the score to the list box
        private void AddUpdatScores_Load(object sender, EventArgs e)
        {
            if (this.scoreUpdate != null)
            {
                txtInput.Text = this.scoreUpdate.ToString();
            }
        }

        //creating a property for moving things across forms
        public int scoreUpdate { get; set; }
    }
}
