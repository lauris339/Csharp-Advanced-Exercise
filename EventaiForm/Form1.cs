using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventaiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //DoubleClick += Click;
            pictureBox1.Paint += Paint;
            pictureBox1.MouseDown += MouseButtonDown;
            pictureBox1.MouseMove += MouseMove;
        }

        private void Paint(object sender, EventArgs e)
        {

        }
        Point location;

        private void MouseButtonDown(object sender, MouseEventArgs e)
        {
            location = e.Location;
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var X = pictureBox1.Location.X + (location.X - e.Location.X);
                var Y = pictureBox1.Location.Y + (location.Y - e.Location.Y);
                pictureBox1.Location = new Point(X, Y);
            }
        }

        /*private void Click(object sender, EventArgs e)
        {
            textBox1.Text += "Paspaust ";
            DoubleClick -= Click;
            pictureBox1.Paint += (send, eventa) =>
            {
                Pen p = new Pen(Color.Black, 2);
                eventa.Graphics.DrawLine(p, 10, 10, 100, 100);
            };

        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
