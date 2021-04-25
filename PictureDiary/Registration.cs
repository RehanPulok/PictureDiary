using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
                    
                    //Registration.
                    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
                    connection.Open();
                    string gender = "";
                    if (maleRadioButton.Checked)
                    {
                        gender = "Male";

                    }
                    else
                    {
                        gender = "Female";
                    }
                    string sql = "INSERT INTO Users (FirstName, LastName, Username, Password, Gender) VALUES ('"+firstNameTextBox.Text+"','"+lastNameTextBox.Text+"','"+usernameTextBox.Text+"','"+passwordTextBox.Text +"','"+gender+"')";
                    SqlCommand command = new SqlCommand(sql,connection);
                    
                    int result= command.ExecuteNonQuery();
                    if (result>0)
                    {
                        MessageBox.Show("User Added");
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error!!");
                    }
                    

                }
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
