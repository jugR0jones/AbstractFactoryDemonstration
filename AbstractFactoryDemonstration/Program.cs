using System;

namespace AbstractFactoryDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using specific methods:");
            IPrinter canonPrinter = PrinterFactory.MakeCanon();
            canonPrinter.Print();

            IPrinter epsonPrinter = PrinterFactory.MakeEpson();
            epsonPrinter.Print();

            IPrinter brotherPrinter = PrinterFactory.MakeBrother();
            brotherPrinter.Print();

            Console.WriteLine("Using a generic method:");
            canonPrinter = PrinterFactory.Make("canon");
            canonPrinter.Print();
            epsonPrinter = PrinterFactory.Make("epson");
            epsonPrinter.Print();
            brotherPrinter = PrinterFactory.Make("brother");
            brotherPrinter.Print();

            Console.ReadLine();
        }
    }
}
