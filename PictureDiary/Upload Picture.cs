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
    public partial class UploadPicture : Form
    {
        Image ig;
        Bitmap bmp;
        OpenFileDialog ofd = new OpenFileDialog();
        public UploadPicture()
        {
            InitializeComponent();
        }

        /*
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "SELECT ID FROM Events WHERE EventName = " + EventTextBox.Text);
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                EventTextBox.Text = reader["EventName"].ToString();
                DateTextBox.Text = reader["Date"].ToString();

            }
        }
        */

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ig = Image.FromFile(ofd.FileName);
                bmp = (Bitmap)ig;
                pictureBox.Image = bmp;

            }
        }

        private void UploadPicture_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EventManagment even = new EventManagment();
            even.Show();
            this.Hide();



            this.Hide();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Events (Picture) VALUES ('" + pictureBox.Image + "') ";
            SqlCommand command = new SqlCommand(sql, connection);

            int result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Picture Added");

            }
            else
            {
                MessageBox.Show("Error!!");
            }
        } } }
        /*

        private void UploadPicture_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();

            string sql = "SELECT ID FROM Events WHERE EventName = " + EventIDTextBox.Text;
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                EventIDTextBox.Text = reader["ID"].ToString();
                

            }


        }
    }
}
        */
