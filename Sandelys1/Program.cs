using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Sandelys1
{
    class Program
    {
        static void Main(string[] args)
        {
            Preke preke = new Preke();
            DataContext data = new DataContext(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Laurynas\Desktop\C_adv\C adv\Sandelys1\Database1.mdf; Integrated Security = True");
            var table = data.GetTable<Preke>();
            /*
            preke.Name = "Braskes";
            table.InsertOnSubmit(preke);
            data.SubmitChanges();
            table.DeleteOnSubmit(preke);
            data.SubmitChanges();
            */
            var vieta = data.GetTable<Vieta>();
            var sujungimas = table.Join(vieta, x=> x.Name, y => y.PrekesPavadinimas, (a,b) => b.VietosPavadinimas );
            Console.WriteLine(sujungimas.First().ToString());

            var sujungimas2 = from eilute in table join eil in vieta on eilute.Name equals eil.PrekesPavadinimas select eil.VietosPavadinimas;

            var uzklausa = from prek in table where prek.Name == "Vinys" select prek;

            var uzklausa2 = table.Where(x => x.Name == "Vinys").OrderByDescending(x => x.Id);
        }
    }
}
