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
    public partial class Form2 : Form
    {
        public delegate void CallBack(int i);
        int i;
        CallBack callBackMethodContainer;

        public Form2(CallBack callbackMethod, int i)
        {
            InitializeComponent();
            this.i = i;
            callBackMethodContainer = callbackMethod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            callBackMethodContainer(i);
        }
    }
}
