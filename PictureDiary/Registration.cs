using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureDiary
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a first name!");
            }
            else if (usernameTextBox.Text == "")
            {
                MessageBox.Show("Please enter an username!");
            }
            else if (passwordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("This can not be empty!");
            }
            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Please enter a last name!");
            }
            else if (maleRadioButton.Checked == false && femaleRadioButton.Checked == false)
            {
                MessageBox.Show("Please select a gender!");
            }
            else
            {
                if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Passwords need to be matched");
                }
                else
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                    //Registration.
                }
            }
        }
    }
}
