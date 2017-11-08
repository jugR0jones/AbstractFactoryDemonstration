using System;

namespace AbstractFactoryDemonstration
{
    class EpsonPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Epson");
        }
    }
}
