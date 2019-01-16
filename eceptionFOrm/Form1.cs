using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eceptionFOrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (txtVardas.Text == "" || txtVardas.Text == " ")
            {
                try
                {
                    throw new MemberAccessException(message: "Neivedete vardo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // mb tab tab, paraso messagebox.show("test");
                }
            }
            else if (txtPavarde.Text == "" || txtPavarde.Text == " ")
            {
                try
                {
                    throw new MemberAccessException(message: "Neivedete Pavardes");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    // mb tab tab, paraso messagebox.show("test");
                }
            }
        }
    }
}
