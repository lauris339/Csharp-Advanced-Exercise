using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        delegate void CallBackMethod();


        public Form1()
        {
            InitializeComponent();
            CallBackMethod callback = Method;
            callback += Method2;
            callback += Method1;
            callback();
        }

        private void SukurtiForma2(int i)
        {
            if (i<3)
            {
                Form2 form2 = new Form2(SukurtiForma2, i);
                form2.Show();
            }
        }

        private void Method()
        {
            MessageBox.Show("Method");
        }
        private void Method1()
        {
            MessageBox.Show("Method1");
        }
        private void Method2()
        {
            MessageBox.Show("Method2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SukurtiForma2(0);
        }
    }
}
