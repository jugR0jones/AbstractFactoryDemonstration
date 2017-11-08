using System;

namespace AbstractFactoryDemonstration
{
    class CanonPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Canon");
        }
    }
}
