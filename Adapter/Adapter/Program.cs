using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey turkey = new Turkey();
            TurkeyToDuckAdapter adaptedTurkey = new TurkeyToDuckAdapter(turkey);

            adaptedTurkey.Fly();
            adaptedTurkey.Quack();
        }
    }
}
