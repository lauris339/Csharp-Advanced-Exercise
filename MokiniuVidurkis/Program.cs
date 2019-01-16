using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MokiniuVidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var kiekMokiniu = random.Next(90);
            var kontroliniuKiekis = random.Next(24);
            var mokiniai = new int[kiekMokiniu];
            var rezultatai = new int[kontroliniuKiekis];
            for (int i = 0; i < kiekMokiniu; i++)
            {
                mokiniai[i] = i;
                for (int a = 0; a < kontroliniuKiekis; a++)
                {
                    rezultatai[a] = random.Next(1, 10);
                }
            }
            


        }
    }
}
