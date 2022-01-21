using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TurkeyToDuckAdapter : IDuck
    {
        private readonly Turkey _turkey;

        public TurkeyToDuckAdapter(Turkey turkey)
        {
            this._turkey = turkey;
        }
        public void Fly()
        {
            this._turkey.Fly();
        }

        public void Quack()
        {
            this._turkey.Gobble();
        }
    }
}
