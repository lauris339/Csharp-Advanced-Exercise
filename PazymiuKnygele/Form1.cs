using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PazymiuKnygele
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<int>> StudentaiSuPazymiais;


        public Form1()
        {
            InitializeComponent();
            DataToLoad();
            foreach (var item in StudentaiSuPazymiais)
            {
                comboMokinys.Items.Add(item.Key);
            }
            
        }

        private void DataToLoad()
        {
            string path = null;
            StudentaiSuPazymiais = new Dictionary<string, List<int>>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
               
            }
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(' ');
                    string name = data.First();
                    var dataArray = data.ToList();
                    dataArray.Remove(name);
                    List<int> pazymiai = new List<int>();
                    foreach (var item in dataArray)
                    {
                        pazymiai.Add(int.Parse(item));
                    }
                    StudentaiSuPazymiais.Add(name, pazymiai);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboMokinys_SelectedIndexChanged(object sender, EventArgs e)
        {
            textVidurkis.Text = StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Average().ToString("F2");

            StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Sort();

            textPazymiai.Text = string.Empty;

            foreach (var item in StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()])
            {
                textPazymiai.Text += item.ToString() + " ";
            }
            textVidurkis.ForeColor = Color.Black;
            if (StudentaiSuPazymiais[comboMokinys.SelectedItem.ToString()].Average() < 5)
            {
                textVidurkis.ForeColor = Color.Red;
            }
            textVisiPazymiai.Text = string.Empty;
            foreach (var item in StudentaiSuPazymiais)
            {
                item.Value.Sort();
                foreach (var items in item.Value)
                {
                    textVisiPazymiai.Text += items.ToString() + " ";

                }
                textVisiPazymiai.Text += Environment.NewLine;
            }
        }
    }
}
