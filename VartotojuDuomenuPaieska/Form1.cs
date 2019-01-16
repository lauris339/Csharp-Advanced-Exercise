using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VartotojuDuomenuPaieska
{
    class Vartotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }

        public Vartotojas(string vardas, string pavarde)
        {
            Vardas = vardas;
            Pavarde = pavarde;
        }
    }


    public partial class Form1 : Form
    {
        private readonly List<Vartotojas> Vartotojai;
        string path = null;

        public Form1()
        {
            InitializeComponent();
            Vartotojai = new List<Vartotojas>();
            
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
                    Vartotojai.Add(new Vartotojas(data[0], data[1]));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bOK_Click(object sender, EventArgs e)
        {
            try
            {
                var check = Vartotojai.Where(x => x.Vardas == txtIeskoti.Text);
                if (check.Count() == 0)
                {
                    throw new IndexOutOfRangeException("Nerastas vartotojas");
                }
                foreach (var item in txtIeskoti.Text.ToCharArray())
                {
                    if (char.IsDigit(item))
                    {
                        throw new FormatException();
                    }
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult dialogResult = MessageBox.Show("Ar sukurti nauja vartotoja", "Sukurti nauja vartotoja", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(path, true))
                    {
                        writer.WriteLine(txtIeskoti.Text);
                    }
                }

            }
            
        }

        private void bFilePath_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
