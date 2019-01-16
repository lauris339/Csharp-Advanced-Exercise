using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskas
{
    class IsvedimasConsole : IIsvedimas
    {
        public void Isvedimas(int x, int y)
        {
            Console.WriteLine("Takso x koordinate: {0} ir y koordinate: {1}", x, y);
        }
    }
}
