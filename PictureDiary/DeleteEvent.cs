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
    public partial class DeleteEvent : Form
    {
        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void DeleteEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EventManagment eventmanagment = new EventManagment();
            eventmanagment.Show();
            this.Hide();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM Events WHERE ID = " + Convert.ToInt32(EventIDTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                EventTextBox.Text = reader["EventName"].ToString();
                //EventDateTimePicker.Text = reader["Date"].ToString();

                //CaptionTextBox.Text = reader["Caption"].ToString();

            }
            else
            {
                EventTextBox.Text = null;
                MessageBox.Show("Please give an appropriate event ID");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "DELETE FROM Events WHERE ID= " + Convert.ToInt32(EventIDTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Event Deleted");
                //UploadPicture upload = new UploadPicture();
                EventManagment events = new EventManagment();
                this.Hide();
                events.Show();


                //upload.Show();
            }
            else
            {
                MessageBox.Show("ERROR!!");
            }
            connection.Close();
        }
    }

}

