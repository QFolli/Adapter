using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Turkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying slow");
        }
    }
}
