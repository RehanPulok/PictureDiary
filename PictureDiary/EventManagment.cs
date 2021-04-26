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
    public partial class EventManagment : Form
    {
        public EventManagment()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createEventButton_Click(object sender, EventArgs e)
        {
            CreateEvent create = new CreateEvent();
            create.Show();
            this.Hide();
        }

        private void EventManagment_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["My Connection"].ConnectionString);
            connection.Open();
            string sql = "SELECT * FROM Events";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<EventList> events = new List<EventList>();
            while (reader.Read())
            {
                EventList even = new EventList();
                even.ID = (int)reader["ID"];
                even.EventName = reader["EventName"].ToString();
                even.Date = reader["Date"].ToString();
                even.LastUpdated = reader["LastUpdated"].ToString();
                even.Caption = reader["Caption"].ToString();

                events.Add(even);
            }
            EventDataGridView.DataSource = events;
            
        }

        private void EventManagment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void updateEventButton_Click(object sender, EventArgs e)
        {
            UpdateEvent upevent = new UpdateEvent();
            this.Hide();
            upevent.Show();
        }
    }
}

/*
while (reader.Read())
{
   // EventList event = new EventList();
}
private void EventManagment_FormClosing(object sender, FormClosingEventArgs e)
{

}



}

private void EventManagment_FormClosing(object sender, FormClosingEventArgs e)
{
Application.Exit();
}

}
}
*/