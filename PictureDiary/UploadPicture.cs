using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                ig = Image.FromFile(ofd.FileName);
                bmp = (Bitmap)ig;
                pictureBox.Image = bmp;

            }
        }

        private void UploadPicture_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
