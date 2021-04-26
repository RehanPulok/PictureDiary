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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();
            string sql = "SELECT Username, Password FROM USERS";
            SqlCommand command = new SqlCommand(sql,connection);
            SqlDataReader reader= command.ExecuteReader();
            List<User> users = new List<User>();
            User user = new User();
            bool ispassmatch= false;
            while (reader.Read())
            {
               
                user.Username = reader["Username"].ToString();
                user.Password = reader["Password"].ToString();
                if (user.Username == userNameTextBox.Text && user.Password == passwordTextBox.Text)
                {
                    EventManagment eve = new EventManagment();
                    eve.Show();
                    this.Hide();
                    ispassmatch = true;
                    break;
                }

                //users.Add(user);



            }


            if (ispassmatch=false)
            {
                MessageBox.Show("Wrong Credentials given");

            }







        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }
    }
}
