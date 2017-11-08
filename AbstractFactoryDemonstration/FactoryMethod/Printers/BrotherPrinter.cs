using System;

namespace AbstractFactoryDemonstration
{
    class BrotherPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Brother");
        }
    }
}
