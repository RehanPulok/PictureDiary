using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureDiary
{
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }

        private void UpdateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "SELECT * FROM Events WHERE ID = "+Convert.ToInt32(EventIDTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                EventTextBox.Text = reader["EventName"].ToString();
                EventDateTimePicker.Text = reader["Date"].ToString();
                /*
               var bytes = (byte[])reader[4];
               using (MemoryStream ms = new MemoryStream(bytes))
               {
                   pictureBox.Image = Image.FromStream(ms);
               }


            Image byteArrayToImage(byte[] byteArrayIn)
           {
               MemoryStream ms = new MemoryStream(byteArrayIn);
               Image returnImage = Image.FromStream(ms);
               return returnImage;
           }
                  */
                //pictureBox.Image = byteArrayToImage((byte[])reader[4]);
                CaptionTextBox.Text = reader["Caption"].ToString();

            }
            else
            {
                EventTextBox.Text = CaptionTextBox.Text = EventDateTimePicker.Text = null;
                MessageBox.Show("Please give an appropriate event ID");
            }
        }

        private Image byteArrayToImage(byte[] vs)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "UPDATE EVENTS SET EventName='"+EventTextBox.Text+ "', LastUpdated= '"+EventDateTimePicker.Text+ "', Caption= '"+CaptionTextBox.Text+"' WHERE ID= " + Convert.ToInt32(EventIDTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Event Updated");
                //UploadPicture upload = new UploadPicture();
                EventManagment events = new EventManagment();
                this.Hide();
                events.Show();


                //upload.Show();
            }
            else
            {
                MessageBox.Show("You Havent made any change!!");
            }
            connection.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EventManagment eventmanagment = new EventManagment();
            eventmanagment.Show();
            this.Hide();

        }

        
    }
}
