using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apskritimas
{
    class Program
    {
        static void Main(string[] args)
        {
            var kiek = 0;
            Random random = new Random();
            int centras = random.Next(100);
            System.Drawing.Point centroTaskas = new System.Drawing.Point(random.Next(-100, 100), random.Next(-100, 100));
            int taskuKiekis = random.Next(10000);
            List<System.Drawing.Point> visiTaskai = new List<System.Drawing.Point>();
            for (int i = 0; i < taskuKiekis; i++)
            {
                System.Drawing.Point tempTaskas = new System.Drawing.Point(random.Next(-200, 200), random.Next(-200, 200));
                visiTaskai.Add(tempTaskas);
            }
            foreach (var item in visiTaskai)
            {
                
                var d = Math.Sqrt(Math.Pow(centroTaskas.X - item.X, 2) + Math.Pow(centroTaskas.Y - item.Y, 2));
                if (d < centras)
                {
                    Console.WriteLine("Taskas su koordinatemis {0} {1} ieina i apskritima", item.X, item.Y);
                    kiek++;
                }
            }
            Console.WriteLine(kiek);
        }
    }
}
