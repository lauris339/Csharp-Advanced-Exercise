using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    class Point
    {
        public int x;
        public int y;

        IIsvedimas Isvedimas;

        public Point(IIsvedimas isvedimas)
        {
            Isvedimas = isvedimas;
        }

        public void IsvestiKoordinate()
        {
            Isvedimas.Isvedimas(x, y);
        }

    }
}
