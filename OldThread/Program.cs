using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OldThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //ThreadStart

            Thread thread = new Thread(Threadas);
            thread.Start();
        }

        private static void Threadas()
        {
            while (true)
            {
                for (int i = 0; i < 1000; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
