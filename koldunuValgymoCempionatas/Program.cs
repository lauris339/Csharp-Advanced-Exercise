using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace koldunuValgymoCempionatas
{
    class Program
    {
        [STAThread]

        static void Main(string[] args)
        {
            

            string path = null;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    path = ofd.FileName;
                }
            }
            List<Dalyvis> dalyviai = new List<Dalyvis>();
            using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    var data = line.Split(';');
                    try
                    {
                        dalyviai.Add(new Dalyvis(int.Parse(data[0]), data[1], int.Parse(data[2]), int.Parse(data[3])));
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }

            DuomenuTikrinimas(dalyviai);

        }
    }
    class Persivalgymas : Exception
    {
        public string message { get; set; }

        public Persivalgymas(string message)
        {
            this.message = message;
        }

        public Persivalgymas()
        {

        }
    }

    internal class Dalyvis
    {
        public int ID { get; }
        public string Vardas { get; }
        public double ValgymoGreitis { get; set; }
        public int SkrandzioDydis { get; set; }
        public int SuvalgytuKoldunuKiekis { get; set; }


        public Dalyvis(int id, string vardas, double valgymoGreitis, int skrandzioDydis)
        {
            ID = id;
            Vardas = vardas;
            ValgymoGreitis = valgymoGreitis;
            SkrandzioDydis = skrandzioDydis;
            //SuvalgytuKoldunuKiekis = suvalgytuKoldunuKiekis;
            
        }

        public static void DuomenuTikrinimas(List<Dalyvis> dalyviai)
        {
            foreach (var item in dalyviai)
            {
                try
                {
                    if (item.SkrandzioDydis < item.SuvalgytuKoldunuKiekis)
                    {
                        throw new Persivalgymas("Persivalge");
                    }

                    int valgymoGreitis = item.SuvalgytuKoldunuKiekis / 60;
                    Console.WriteLine("{0} dalyvio valgymo greitis {1}", item.Vardas, item.ValgymoGreitis);

                }
                catch (Persivalgymas e)
                {
                    MessageBox.Show(e.message);
                    
                }
                catch (DivideByZeroException e)
                {
                    MessageBox.Show("Dalyba is nulio negalima");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Unknown error");

                }
            }
        }

    }



    
}

