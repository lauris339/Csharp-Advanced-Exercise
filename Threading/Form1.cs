using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BackgroundWorker
            //Task.Run(() => 
            
                for (int i = 0; i < int.MaxValue; i++)
                {
                    ///Thread.Sleep(10);
                }
            
            
            
        }

        private async void ASinchronineprograma()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("Rasau"))
            {
                await writer.WriteLineAsync("");
            }

            using (System.IO.StreamReader reader = new System.IO.StreamReader("rasau"))
            {
                var read = await reader.ReadLineAsync();
            }

            var result = await GetValue();
        }

        private Task<int> GetValue()
        {
            Task<int> a;
            return a;
        }

        private void paprastas()
        {

        }
    }
}
