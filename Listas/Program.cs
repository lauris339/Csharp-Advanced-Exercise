using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
           


            //forr TAB tab 
            for (int i = 10; i >= 0; i--)
            {
                skaiciai.Add(i);
            }
            IEnumerable<int> skaiciukai = skaiciai.Where(x => x < 3);
            foreach (var item in skaiciukai)
            {
                Console.WriteLine(item);
            }
            /*
            Console.WriteLine(skaiciai.ElementAt(6));
            Console.WriteLine(skaiciai.ElementAtOrDefault(5000));
            var masyvas = skaiciai.ToArray();
            var sarasas = masyvas.ToList();
            skaiciai.Insert(5, 50000);
            skaiciai.RemoveAt(9);
            skaiciai.Add(4);
            skaiciai.Remove(4);//salina tik viena 4 sarase
            skaiciai.RemoveAll(x => x == 4); // if(x==4)
            skaiciai.Sort();//nuo maziausio iki didziausio
            skaiciai.Reverse();//apsuka visa masyva
            //skaiciai.Clear(); istrina masyva
            foreach (var item in skaiciai)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}
