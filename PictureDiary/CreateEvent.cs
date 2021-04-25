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
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();
            
            string sql = "INSERT INTO Event (EventName, Date, LastUpdated, Picture) VALUES ('" + eventNameTextBox.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker1.Text + "','" + null + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Event Added");
                UploadPicture up = new UploadPicture();
                up.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error!!");
            }
            
        }

        private void CreateEvent_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createeveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();
            
            string sql = "INSERT INTO Events (EventName, Date, LastUpdated, Picture) VALUES ('" + EventTextBox.Text + "','" + eventdateTimePicker.Text + "','" + eventdateTimePicker.Text + "','" + null + "')";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Event Added");
                UploadPicture upload = new UploadPicture();
                this.Hide();
                upload.Show();
            }
            else
            {
                MessageBox.Show("Error!!");
            }
            
        }
    }
}
