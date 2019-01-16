using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodynas
{
    public partial class Form1 : Form
    {

        Dictionary<Image, PictureBox> pictureImage;
        Image image;


        public Form1()
        {
            pictureImage = new Dictionary<Image, PictureBox>();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            PictureBox pic = new PictureBox();
            Image img = Image.FromFile(path);
            pic.Image = img;
            pic.Size = img.Size;
            groupBox1.Controls.Add(pic);
            pictureImage.Add(img, pic);
            image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var something = pictureImage.Last();
            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            groupBox1.Controls.Remove(pictureImage[something.Key]);
            Image img = Image.FromFile(path);
            pictureImage[something.Key].Image = img;
            groupBox1.Controls.Add(pictureImage[something.Key]);
            
        }
    }
}
