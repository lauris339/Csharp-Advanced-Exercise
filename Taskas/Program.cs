using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    class Program
    {

        static void Main(string[] args)
        {
            Point taskas = new Point(new IsvedimasConsole());
            var taskas2 = new IsvedimasIFaila();
            taskas.x = 5;
            taskas.y = 6;
            taskas2.Isvedimas(5, 6);
            taskas.IsvestiKoordinate();

        }
    }

    class Enumeratorius : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Isvedimas(int x, int y)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
