using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionai
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Test1();
        }

        private static void Test1()
        {
            var i = new int[2];
            i[2] = 2;
        }

    }
}
